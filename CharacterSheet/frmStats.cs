﻿using System;
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
    //Stats Form
    public partial class frmStats : Form
    {
        public Character newChar2;

        public frmStats(Character newChar)
        {
            
            InitializeComponent();
            this.newChar2 = newChar;
        }

        //our points available to spend
        //cmon work now
        public int pointsLeft = 27;
       
        public void frmStats_Load(object sender, EventArgs e)
        {
            updatePage();
            txtNewCharName.Text = newChar2.Name;
        }

        public void updatePage()
        {
            txtPointsLeft.Text = Convert.ToString(pointsLeft);
            

            numStrength.Value = newChar2.Strength;
            numCharisma.Value = newChar2.Charisma;
            numDexterity.Value = newChar2.Dexterity;
            numIntelligence.Value = newChar2.Intelligence;
            numFortitude.Value = newChar2.Fortitude;
            numWisdom.Value = newChar2.Wisdom;
        }
        

        private void StatsChanged(object sender, MouseEventArgs e)
        {
            NumericUpDown box = (NumericUpDown)sender;

            if(box.Name == "numStrength")
            {
                int oldStrength = newChar2.Strength;

                if (oldStrength == numStrength.Value)
                {
                    MessageBox.Show("8 is the minimum starting value.");
                }

                //if down button was pressed on Strength
                else if (oldStrength > numStrength.Value)
                {
                    newChar2.Strength--;
                    pointsLeft++;
                }

                else if(oldStrength < numStrength.Value)
                {
                    newChar2.Strength++;
                    pointsLeft--;
                }
                
            }

            if(box.Name == "numWisdom")
            {
                int oldWisdom = newChar2.Wisdom;

                if (oldWisdom == numWisdom.Value)
                {
                    MessageBox.Show("8 is the minimum starting value.");
                }

                else if(oldWisdom > numWisdom.Value)
                {
                    newChar2.Wisdom--;
                    pointsLeft++;
                }
                
                else if(oldWisdom < numWisdom.Value)
                {
                    newChar2.Wisdom++;
                    pointsLeft--;
                }
                
            }

            if (box.Name == "numCharisma")
            {
                int oldCharisma = newChar2.Charisma;

                if (oldCharisma == numCharisma.Value)
                {
                    MessageBox.Show("8 is the minimum starting value.");
                }

                else if (oldCharisma > numCharisma.Value)
                {
                    newChar2.Charisma--;
                    pointsLeft++;
                }

                else if(oldCharisma < numCharisma.Value)
                {
                    newChar2.Charisma++;
                    pointsLeft--;
                }
            }

            if (box.Name == "numIntelligence")
            {
                int oldIntelligence = newChar2.Intelligence;

                if (oldIntelligence == numIntelligence.Value)
                {
                    MessageBox.Show("8 is the minimum starting value.");
                }

                else if (oldIntelligence > numIntelligence.Value)
                {
                    newChar2.Intelligence--;
                    pointsLeft++;
                }

                else if(oldIntelligence < numIntelligence.Value)
                {
                    newChar2.Intelligence++;
                    pointsLeft--;
                }
            }

            if (box.Name == "numDexterity")
            {
                int oldDexterity = newChar2.Dexterity;

                if (oldDexterity == numDexterity.Value)
                {
                    MessageBox.Show("8 is the minimum starting value.");
                }

                else if (oldDexterity > numDexterity.Value)
                {
                    newChar2.Dexterity--;
                    pointsLeft++;
                }

                else if(oldDexterity < numDexterity.Value)
                {
                    newChar2.Dexterity++;
                    pointsLeft--;
                }
            }

            if (box.Name == "numFortitude")
            {
                int oldFortitude = newChar2.Fortitude;

                if (oldFortitude == numFortitude.Value)
                {
                    MessageBox.Show("8 is the minimum starting value.");
                }

                else if (oldFortitude > numFortitude.Value)
                {
                    
                    
                    newChar2.Fortitude--;
                    pointsLeft++;
                    
                    
                }
                
                else if(oldFortitude < numFortitude.Value)
                {
                    newChar2.Fortitude++;
                    pointsLeft--;
                }
            }

            updatePage();

        }
    }
}
