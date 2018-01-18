using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            string deleteName = (string)lstCharacters.SelectedItem;
            
            if (DBHelper.DeleteCharacter(deleteName))
            {
                MessageBox.Show("Character deleted");
            }
        }
    }
}
