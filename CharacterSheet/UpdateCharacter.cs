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
    public partial class UpdateCharacter : Form
    {
        public Character c;
        public UpdateCharacter(Character newChar)
        {
            InitializeComponent();
            this.c = newChar;

            txtName.Text = c.Name;
            cboGender.SelectedItem = c.Gender;
            cboRace.SelectedItem = c.Race;
            numWeight.Value = c.Weight;
            numHeight.Value = c.Height;

            MessageBox.Show(Convert.ToString(c.CharacterID));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(ValidateSheet())
            {


                SqlConnection con = DBHelper.GetConnection();

                SqlCommand addCommand = new SqlCommand();
                addCommand.Connection = con;
                addCommand.CommandText = "UPDATE Characters " +
               "SET Name = @Name, Race = @Race, Gender = @Gender, Height = @Height, Weight = @Weight " +
               "WHERE CharacterID = @CharacterID";

                addCommand.Parameters.AddWithValue("@CharacterID", c.CharacterID);
                addCommand.Parameters.AddWithValue("@Name", c.Name);
                addCommand.Parameters.AddWithValue("@Race", c.Race);
                addCommand.Parameters.AddWithValue("@Gender", c.Gender);
                addCommand.Parameters.AddWithValue("@Height", c.Height);
                addCommand.Parameters.AddWithValue("@Weight", c.Weight);

                try
                {
                    con.Open();
                    int rowsAffected =
                        addCommand.ExecuteNonQuery();
                    //if updated successfully
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Character was updated.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong.");
                    }
                }
                finally
                {
                    con.Dispose();
                    //con.Close();
                }
            }

            else
            {
                MessageBox.Show("Something seems to have gone wrong with the update.");
            }
        }

        public bool ValidateSheet()
        {
            if(cboRace.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a race.");
                return false;
            }

            if(cboGender.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a gender.");
                return false;
            }

            if(txtName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
                return false;
            }

            return true;
        }
    }
}
