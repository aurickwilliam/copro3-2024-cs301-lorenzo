using System;
using System.Collections.Generic;
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
        public List<string> GetAllCharacters()
        {
            List<string> listOfCharName = new List<string>();
            try
            {
                connection.Open();

                string query = "SELECT * FROM characters;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listOfCharName.Add(reader["name"].ToString());        
                }
                
                reader.Close();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return listOfCharName;
        }

        public List<string> GetSpecificCharacterInfo(string name)
        {
            List<string> lisOfCharacterInfo = new List<string>();
            try
            {
                connection.Open();
                string query = $"SELECT * FROM characters WHERE name='{name}';";
                MySqlCommand cmd = new MySqlCommand( query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    lisOfCharacterInfo.Add(reader["name"].ToString());
                    lisOfCharacterInfo.Add(reader["title"].ToString());
                    lisOfCharacterInfo.Add(reader["gender"].ToString());
                    lisOfCharacterInfo.Add(reader["bodyType"].ToString());
                    lisOfCharacterInfo.Add(reader["height"].ToString());
                    lisOfCharacterInfo.Add(reader["skinColor"].ToString());
                    lisOfCharacterInfo.Add(reader["hairStyle"].ToString());
                    lisOfCharacterInfo.Add(reader["hairColor"].ToString());
                    lisOfCharacterInfo.Add(reader["headShape"].ToString());
                    lisOfCharacterInfo.Add(reader["eyeShape"].ToString());
                    lisOfCharacterInfo.Add(reader["eyeColor"].ToString());
                    lisOfCharacterInfo.Add(reader["facialHairStyle"].ToString());
                    lisOfCharacterInfo.Add(reader["skinWrinkles"].ToString());
                    lisOfCharacterInfo.Add(reader["scar"].ToString());
                    lisOfCharacterInfo.Add(reader["outfitSet"].ToString());
                    lisOfCharacterInfo.Add(reader["topClothing"].ToString());
                    lisOfCharacterInfo.Add(reader["bottomClothing"].ToString());
                    lisOfCharacterInfo.Add(reader["footWear"].ToString());
                    lisOfCharacterInfo.Add(reader["accessories"].ToString());
                    lisOfCharacterInfo.Add(reader["tattoo"].ToString());
                    lisOfCharacterInfo.Add(reader["aura"].ToString());
                    lisOfCharacterInfo.Add(reader["meleeWeapon"].ToString());
                    lisOfCharacterInfo.Add(reader["fightingStyle"].ToString());
                    lisOfCharacterInfo.Add(reader["stance"].ToString());
                    lisOfCharacterInfo.Add(reader["attackPower"].ToString());
                    lisOfCharacterInfo.Add(reader["defense"].ToString());
                    lisOfCharacterInfo.Add(reader["speed"].ToString());
                    lisOfCharacterInfo.Add(reader["stamina"].ToString());
                    lisOfCharacterInfo.Add(reader["health"].ToString());
                    lisOfCharacterInfo.Add(reader["specialMeterGain"].ToString());
                }

                reader.Close();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return lisOfCharacterInfo;
        }

        public bool InsertNewCharacter(Character character)
        {
            bool isSuccessful = false;
            try
            {
                connection.Open();
                string query = $"INSERT INTO characters (name, title, gender, bodyType, height, skinColor, hairStyle, hairColor, headShape, " +
                    $"eyeShape, eyeColor, facialHairStyle, skinWrinkles, scar, outfitSet, topClothing, bottomClothing, footWear, accessories, " +
                    $"tattoo, aura, meleeWeapon, fightingStyle, stance, attackPower, defense, speed, stamina, health, specialMeterGain) " +
                    $"VALUES ('{character.Name}', '{character.Title}', '{character.physicalAppearance.Gender}', '{character.physicalAppearance.BodyType}', '{character.physicalAppearance.Height}', '{character.physicalAppearance.SkinColor}'," +
                    $" '{character.physicalAppearance.HairStyle}', '{character.physicalAppearance.HairColor}', '{character.physicalAppearance.HeadShape}', '{character.physicalAppearance.EyeShape}'," +
                    $" '{character.physicalAppearance.EyeColor}', '{character.physicalAppearance.FacialHairStyle}', {character.physicalAppearance.IsSkinWrinkles}," +
                    $" {character.physicalAppearance.IsScar}, '{character.clothesAccessories.OutfitSet}', '{character.clothesAccessories.TopClothing}'," +
                    $" '{character.clothesAccessories.BottomClothing}', '{character.clothesAccessories.FootWear}', '{character.clothesAccessories.Accessories}'," +
                    $" {character.clothesAccessories.IsTattoo}, {character.clothesAccessories.IsAura}, '{character.weaponsAttacks.MeleeWeapon}', '{character.weaponsAttacks.FightingStyle}'," +
                    $" '{character.weaponsAttacks.Stance}', {character.stats.AttackPower}, {character.stats.Defense}, {character.stats.Speed}, {character.stats.Stamina}, {character.stats.Health}, {character.stats.SpecialMeterGain});";

                MySqlCommand cmd = new MySqlCommand( query, connection);

                if(cmd.ExecuteNonQuery() == 1)
                {
                    isSuccessful = true;
                }
                

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isSuccessful;
        }

        public bool DeleteCharacter(string name)
        {
            bool isDeleteSuccessful = false;
            try
            {
                connection.Open();
                string query = $"DELETE FROM characters WHERE name='{name}';";
                MySqlCommand cmd = new MySqlCommand ( query, connection);
                
                if (cmd.ExecuteNonQuery() == 1)
                {
                    isDeleteSuccessful = true;
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isDeleteSuccessful; 
        }

        public bool CheckIfValueAlreadyExist(string colName, string value)
        {
            bool isExisting = false;
            try
            {
                connection.Open();
                string query = $"SELECT {colName} FROM characters WHERE {colName}='{value}';";
                MySqlCommand cmd = new MySqlCommand (query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isExisting = true;
                }

                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return isExisting;
        }

        public List<List<string>> GetAllCharacterInfo()
        {
            List<List<string>> allCharacterList = new List<List<string>>();

            try
            {
                connection.Open();

                string query = "SELECT * FROM characters;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    List<string> characterList = new List<string>();
                    characterList.Add(reader["name"].ToString());
                    characterList.Add(reader["title"].ToString());
                    characterList.Add(reader["gender"].ToString());
                    characterList.Add(reader["bodyType"].ToString());
                    characterList.Add(reader["height"].ToString());
                    characterList.Add(reader["skinColor"].ToString());
                    characterList.Add(reader["hairStyle"].ToString());
                    characterList.Add(reader["hairColor"].ToString());
                    characterList.Add(reader["headShape"].ToString());
                    characterList.Add(reader["eyeShape"].ToString());
                    characterList.Add(reader["eyeColor"].ToString());
                    characterList.Add(reader["facialHairStyle"].ToString());
                    characterList.Add(reader["skinWrinkles"].ToString());
                    characterList.Add(reader["scar"].ToString());
                    characterList.Add(reader["outfitSet"].ToString());
                    characterList.Add(reader["topClothing"].ToString());
                    characterList.Add(reader["bottomClothing"].ToString());
                    characterList.Add(reader["footWear"].ToString());
                    characterList.Add(reader["accessories"].ToString());
                    characterList.Add(reader["tattoo"].ToString());
                    characterList.Add(reader["aura"].ToString());
                    characterList.Add(reader["meleeWeapon"].ToString());
                    characterList.Add(reader["fightingStyle"].ToString());
                    characterList.Add(reader["stance"].ToString());
                    characterList.Add(reader["attackPower"].ToString());
                    characterList.Add(reader["defense"].ToString());
                    characterList.Add(reader["speed"].ToString());
                    characterList.Add(reader["stamina"].ToString());
                    characterList.Add(reader["health"].ToString());
                    characterList.Add(reader["specialMeterGain"].ToString());
                    allCharacterList.Add(characterList);
                }

                reader.Close();
                connection.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return allCharacterList;
        }
    }
}
