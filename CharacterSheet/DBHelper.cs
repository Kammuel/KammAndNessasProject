using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterSheet
{
    class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source = localhost; Initial Catalog = CharacterDB; " +
                "Integrated Security = True; Pooling = False");
        }

        //this is our helper method to populate the listbox
        //on the main form with the character objects
        public static List<Character> GetCharacters()
        {
            //create an empty list of characters to be filled
            //from the SQL query to get all
            List<Character> characters = new List<Character>();

            //connect to database
            SqlCommand selCommand = new SqlCommand();
            selCommand.Connection = GetConnection();

            //Pull all the information for each character
            selCommand.CommandText =
                "SELECT CharacterID, Name, Race, Gender, Height, Weight," +
                "Strength, Wisdom, Intelligence, Charisma, Fortitude, Dexterity " +
                "FROM Characters";

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
                    var newChar = new Character();
                    newChar.CharacterID = (int)rdr["CharacterID"];
                    newChar.Name = (string)rdr["Name"];
                    newChar.Race = (string)rdr["Race"];
                    newChar.Height = (int)rdr["Height"];
                    newChar.Weight = (int)rdr["Weight"];
                    
                    characters.Add(newChar);
                }
            }

            finally
            {
                //close the door to the connection to the database
                selCommand.Connection.Dispose();
            }

            //return character list
            return characters;
        }

        public static bool DeleteCharacter(string deleteName)
        {

            SqlConnection con = DBHelper.GetConnection();

            SqlCommand delCommand = new SqlCommand();
            delCommand.Connection = con;
            delCommand.CommandText = "DELETE FROM Characters " +
           "WHERE Name = @Name";

            delCommand.Parameters.AddWithValue("@Name", deleteName);

            try
            {
                con.Open();
                int rowsAffected =
                    delCommand.ExecuteNonQuery();
                //GameCharacter added successfully
                if (rowsAffected == 1)
                {
                    return true;
                }

                return false;
            }
            finally
            {
                con.Dispose();
                //con.Close();
            }
        }
    }
}
