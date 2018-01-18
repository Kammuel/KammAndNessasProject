using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            populateCharacterBox();
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            //yes, the naming convention is bad right here
            AddCharacter Add = new AddCharacter();

            Add.ShowDialog();
        }

        private void populateCharacterBox()
        {
            lstCharacters.Items.Clear();
            List<Character> characters = DBHelper.GetCharacters();

            foreach(Character c in characters)
            {
                lstCharacters.Items.Add(c.Name);
            }
        }

        private void btnUpdateCharacter_Click(object sender, EventArgs e)
        {
            if(lstCharacters.SelectedIndex >= 0)
            {
                string name = (string)lstCharacters.SelectedItem;

                Character newChar = getCharacter(name);

                UpdateCharacter update = new UpdateCharacter(newChar);
                update.ShowDialog();
            }
            
        }

        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            string deleteName = (string)lstCharacters.SelectedItem;
            if(DBHelper.DeleteCharacter(deleteName))
            {
                MessageBox.Show("Character Deleted!");
            }
            this.Refresh();
        }

        public Character getCharacter(string Name)
        {
            Character newChar = new Character();
            //connect to database
            SqlCommand selCommand = new SqlCommand();
            selCommand.Connection = DBHelper.GetConnection();

            //Pull all the information for each character
            selCommand.CommandText =
                "SELECT CharacterID, Name, Race, Gender, Height, Weight " +
                "FROM Characters " +
                "WHERE Name = @Name";

            selCommand.Parameters.AddWithValue("@Name", Name);

            try
            {
                //open connection to database
                selCommand.Connection.Open();
                SqlDataReader rdr = selCommand.ExecuteReader();
                //while hasNext()
                while (rdr.Read())
                {
                    //create a new fake character object our information
                    //from SQL will be copied into
                    newChar.CharacterID = (int)rdr["CharacterID"];
                    newChar.Name = (string)rdr["Name"];
                    newChar.Race = (string)rdr["Race"];
                    newChar.Gender = (string)rdr["Gender"];
                    newChar.Height = (int)rdr["Height"];
                    newChar.Weight = (int)rdr["Weight"];


                }
            }

            finally
            {
                //close the door to the connection to the database
                selCommand.Connection.Dispose();
            }
            return newChar;
        }
    }
}
