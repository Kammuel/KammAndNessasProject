using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet
{
    public class Character
    {
        public String Name { get; set; }
        public String Race { get; set; }
        public String Gender { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }


        public int Strength { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Fortitude { get; set; }
        public int Dexterity { get; set; }

        public Character(String name, String Gender, String race, int height, int weight)
        {
            this.Name = name;
            this.Race = race;
            this.Gender = Gender;
            this.Height = height;
            this.Weight = weight;
            this.Strength = 10;
            this.Wisdom = 10;
            this.Intelligence = 10;
            this.Charisma = 10;
            this.Fortitude = 10;
            this.Dexterity = 10;

            if (this.Race == "Half-Orc")
            {
                this.Strength += 2;
                this.Intelligence -= 2;
                this.Charisma -= 2;
            }

            if (this.Race == "Elf")
            {
                this.Wisdom += 2;
                this.Fortitude -= 2;
            }

            if (this.Race == "Halfling")
            {
                this.Dexterity += 2;
                this.Fortitude -= 2;
            }

            if (this.Race == "Gnome")
            {
                this.Strength -= 2;
                this.Wisdom += 2;
            }

            if (this.Race == "Dwarf")
            {
                this.Strength += 2;
                this.Dexterity -= 2;
            }
        }

        public Character getCharacter()
        {
            return this;
        }




    }
}
