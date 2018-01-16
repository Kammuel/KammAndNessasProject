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
    public partial class AddCharacter : Form
    {
        //everything below here will be transferred
        public AddCharacter()
        {
            InitializeComponent();
        }

        public void AddCharacter_Load(object sender, EventArgs e)
        {
            lstRaces.Items.Add("Human");
            lstRaces.Items.Add("Half-Orc");
            lstRaces.Items.Add("Halfling");
            lstRaces.Items.Add("Dwarf");
            lstRaces.Items.Add("Half-Elf");
            lstRaces.Items.Add("Elf");
            lstRaces.Items.Add("Gnome");


        }

        public Character newChar;

        //public static Character newChar = new Character();
        public static Character createCharacter(String name, String gender, 
                                                String race, int height, int weight)
        {
            return new Character(name, gender, race, height, weight);
        }

        public void btnStats_Click(object sender, EventArgs e)
        {
            String gender = "";

            if (radMale.Checked)
            {
                gender = "Male";
            }

            if (radFemale.Checked)
            {
                gender = "Female";
            }

            else
            {
                gender =  "Other";
            }
            
            
            String race = lstRaces.SelectedItem.ToString();
            int height = (int)numHeight.Value;
            int weight = (int)numWeight.Value;

            newChar = createCharacter(txtName.Text, gender, race, height, weight);
            
            frmStats stats = new frmStats(newChar);
            

            stats.ShowDialog(); 

        }
        
    }
}
