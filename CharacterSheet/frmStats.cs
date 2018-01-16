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
    //Stats Form
    public partial class frmStats : Form
    {
        public Character c;

        //Form on load
        public frmStats(Character newChar)
        {
            InitializeComponent();
            this.c = newChar;
        }

        //points available to spend
        public int pointsLeft = 27;

        //update page on load and set the character name box text
        public void frmStats_Load(object sender, EventArgs e)
        {
            updatePage();
            txtNewCharName.Text = c.Name;
        }

        public void updatePage()
        {
            txtPointsLeft.Text = Convert.ToString(pointsLeft);


            numStrength.Value = c.Strength;
            numCharisma.Value = c.Charisma;
            numDexterity.Value = c.Dexterity;
            numIntelligence.Value = c.Intelligence;
            numFortitude.Value = c.Fortitude;
            numWisdom.Value = c.Wisdom;
        }


        private void StatsChanged(object sender, MouseEventArgs e)
        {
            NumericUpDown box = (NumericUpDown)sender;



            if (box.Name == "numStrength")
            {
                int oldStrength = c.Strength;

                if (oldStrength == numStrength.Value)
                {
                    MessageBox.Show("Stats may have a minimum of 8 and a maximum of 18.");
                }

                //if down button was pressed on Strength
                else if (oldStrength > numStrength.Value)
                {
                    c.Strength--;
                    pointsLeft++;
                }

                else if (oldStrength < numStrength.Value)
                {
                    if (pointsLeft == 0)
                    {
                        MessageBox.Show("You have no points left to spend!");
                    }
                    else
                    {
                        c.Strength++;
                        pointsLeft--;
                    }

                }

            }

            if (box.Name == "numWisdom")
            {
                int oldWisdom = c.Wisdom;

                if (oldWisdom == numWisdom.Value)
                {
                    MessageBox.Show("Stats may have a minimum of 8 and a maximum of 18.");
                }

                else if (oldWisdom > numWisdom.Value)
                {
                    c.Wisdom--;
                    pointsLeft++;
                }

                else if (oldWisdom < numWisdom.Value)
                {
                    if (pointsLeft == 0)
                    {
                        MessageBox.Show("You have no points left to spend!");
                    }
                    else
                    {
                        c.Wisdom++;
                        pointsLeft--;
                    }

                }

            }

            if (box.Name == "numCharisma")
            {
                int oldCharisma = c.Charisma;

                if (oldCharisma == numCharisma.Value)
                {
                    MessageBox.Show("Stats may have a minimum of 8 and a maximum of 18.");
                }

                else if (oldCharisma > numCharisma.Value)
                {
                    c.Charisma--;
                    pointsLeft++;
                }

                else if (oldCharisma < numCharisma.Value)
                {
                    if (pointsLeft == 0)
                    {
                        MessageBox.Show("You have no points left to spend!");
                    }
                    else
                    {
                        c.Charisma++;
                        pointsLeft--;
                    }

                }
            }

            if (box.Name == "numIntelligence")
            {
                int oldIntelligence = c.Intelligence;

                if (oldIntelligence == numIntelligence.Value)
                {
                    MessageBox.Show("Stats may have a minimum of 8 and a maximum of 18.");
                }

                else if (oldIntelligence > numIntelligence.Value)
                {
                    c.Intelligence--;
                    pointsLeft++;
                }

                else if (oldIntelligence < numIntelligence.Value)
                {
                    if (pointsLeft == 0)
                    {
                        MessageBox.Show("You have no points left to spend!");
                    }
                    else
                    {
                        c.Intelligence++;
                        pointsLeft--;
                    }

                }
            }

            if (box.Name == "numDexterity")
            {
                int oldDexterity = c.Dexterity;

                if (oldDexterity == numDexterity.Value)
                {
                    MessageBox.Show("Stats may have a minimum of 8 and a maximum of 18.");
                }

                else if (oldDexterity > numDexterity.Value)
                {
                    c.Dexterity--;
                    pointsLeft++;
                }

                else if (oldDexterity < numDexterity.Value)
                {
                    if (pointsLeft == 0)
                    {
                        MessageBox.Show("You have no points left to spend!");
                    }
                    else
                    {
                        c.Dexterity++;
                        pointsLeft--;
                    }

                }
            }

            if (box.Name == "numFortitude")
            {
                int oldFortitude = c.Fortitude;

                if (oldFortitude == numFortitude.Value)
                {
                    MessageBox.Show("Stats may have a minimum of 8 and a maximum of 18.");
                }

                else if (oldFortitude > numFortitude.Value)
                {
                    c.Fortitude--;
                    pointsLeft++;
                }

                else if (oldFortitude < numFortitude.Value)
                {
                    if (pointsLeft == 0)
                    {
                        MessageBox.Show("You have no points left to spend!");
                    }
                    else
                    {
                        c.Fortitude++;
                        pointsLeft--;
                    }

                }
            }

            updatePage();

        }

        private void btnSaveCharacter_Click(object sender, EventArgs e)
        {
            if(pointsLeft > 0)
            {
                MessageBox.Show("You have points left to spend!  You should do that before saving your character");
            }

            else
            {
                SqlConnection con = DBHelper.GetConnection();

                SqlCommand addCommand = new SqlCommand();
                addCommand.Connection = con;
                addCommand.CommandText = "INSERT INTO Characters " +
               "(Name, Race, Gender, Height, Weight, Strength, Wisdom, Intelligence, Charisma, Fortitude, Dexterity) " +
                "VALUES " +
               "( @Name, @Race, @Gender, @Height, @Weight, @Strength, @Wisdom, @Intelligence, @Charisma, @Fortitude, @Dexterity) ";

                addCommand.Parameters.AddWithValue("@Name", c.Name);
                addCommand.Parameters.AddWithValue("@Race", c.Race);
                addCommand.Parameters.AddWithValue("@Gender", c.Gender);
                addCommand.Parameters.AddWithValue("@Height", c.Height);
                addCommand.Parameters.AddWithValue("@Weight", c.Weight);
                addCommand.Parameters.AddWithValue("@Strength", c.Strength);
                addCommand.Parameters.AddWithValue("@Wisdom", c.Wisdom);
                addCommand.Parameters.AddWithValue("@Intelligence", c.Intelligence);
                addCommand.Parameters.AddWithValue("@Charisma", c.Charisma);
                addCommand.Parameters.AddWithValue("@Fortitude", c.Fortitude);
                addCommand.Parameters.AddWithValue("@Dexterity", c.Dexterity);

                try
                {
                    con.Open();
                    int rowsAffected =
                        addCommand.ExecuteNonQuery();
                    //GameCharacter added successfully
                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Character was added to the system.");
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
                Application.Exit();
            }

            
        }
    }
}
