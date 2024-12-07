using System;
using MySql.Data.MySqlClient;

namespace Samson_Brawlers
{
    public class Database
    {
        private string serverName = "localhost";
        private string usernameId = "root";
        private string password = "YuR1o_[rosie407]";
        private string databaseName = "samson_brawlers";

        private string connectionString;
        private MySqlConnection connection;

        public Database()
        {

            connectionString = $"server={serverName};uid={usernameId};pwd={password};database={databaseName}";
            connection = new MySqlConnection();
            connection.ConnectionString = connectionString;
        }
        public void GetAllCharacters()
        {
            try
            {
                connection.Open();

                string query = "SELECT * FROM characters;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();


                Console.WriteLine("\t\t\t+------------------------------------------------------+");
                Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                Console.WriteLine("\t\t\t|\t\t   LIST OF CHARACTERS\t\t       |");
                Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                Console.WriteLine("\t\t\t+------------------------------------------------------+");

                List<string> listOfCharName = new List<string>();
                int index = 0;
                while (reader.Read())
                {
                    Console.WriteLine($"\t\t\t| {index} ->  {reader["name"], -46}|");
                    index++;
                    listOfCharName.Add(reader["name"].ToString());        
                }

                reader.Close();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void InsertNewCharacter()
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO characters (name, title, gender, bodyType, height, skinColor, hairStyle, hairColor, headShape, " +
                    "eyeShape, eyeColor, facialHairStyle, skinWrinkles, scar, outfitSet, topClothing, bottomClothing, footWear, accessories, " +
                    "tattoo, aura, meleeWeapon, fightingStyle, stance, attackPower, defense, speed, stamina, health, specialMeterGain) " +
                    "VALUES ('shibal', 'aigoo', 'sad', 'ada', 'dad', 'ada', 'ada', 'ada', 'ada', 'ada', 'ada', 'ada', 1, 0, 'adaw', 'ada', 'ada'," +
                    " 'ada', 'adaw', 1, 1, 'adwad', 'dawdwa', 'adaw', 10, 5, 3, 5, 2, 1);";

                MySqlCommand cmd = new MySqlCommand( query, connection);

                if(cmd.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("Added!");
                }
                else
                {
                    Console.WriteLine("Error!");
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void DeleteCharacter()
        {

        }

        public void DisplaySelectedCharacter()
        {

        }
    }
}
