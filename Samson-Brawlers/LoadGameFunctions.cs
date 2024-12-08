﻿using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Xml.Linq;

namespace Samson_Brawlers
{
    public class LoadGameFunctions
    {
        private string selectedCharacterName;

        public bool GetSelectedCharacter(Database database)
        {
            List<string> names = database.GetAllCharacters();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t   LIST OF CHARACTERS\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+");

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"\t\t\t| {i + 1} ->  {names[i], -46} |");
            }
            Console.WriteLine($"\t\t\t| 0 ->  {"GO BACK", -46} |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t| SELECT A CHARACTER:\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            int input = 0;
            do
            {
                try
                {
                    Console.Write("\t\t\t  -> ");
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input == 0)
                    {
                        return false;
                    }

                    if (input < 0)
                    {
                        throw new InputNotAChoiceException();
                    }
                    else if (input > names.Count)
                    {
                        throw new InputNotAChoiceException();
                    }

                    Console.Clear();
                    this.selectedCharacterName = names[input - 1];
                    return true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\t\t\t  PLEASE INPUT A NUMBER VALUE!\n");
                }
                catch (InputNotAChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while(true);
        }

        public void DisplayCharacterInfo(Database database)
        {
            List<string> characterInfo = database.GetSpecificCharacterInfo(selectedCharacterName);
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t CHARACTER INFORMATION\t\t       |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| NAME\t\t     | {characterInfo[0],-31} |");
            Console.WriteLine($"\t\t\t| TITLE\t\t     | {characterInfo[1],-31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| GENDER\t     | {characterInfo[2],-31} |");
            Console.WriteLine($"\t\t\t| BODY TYPE\t     | {characterInfo[3],-31} |");
            Console.WriteLine($"\t\t\t| HEIGHT\t     | {characterInfo[4],-31} |");
            Console.WriteLine($"\t\t\t| SKIN COLOR\t     | {characterInfo[5],-31} |");
            Console.WriteLine($"\t\t\t| HAIR STYLE\t     | {characterInfo[6],-31} |");
            Console.WriteLine($"\t\t\t| HAIR COLOR\t     | {characterInfo[7],-31} |");
            Console.WriteLine($"\t\t\t| HEAD SHAPE\t     | {characterInfo[8],-31} |");
            Console.WriteLine($"\t\t\t| EYE SHAPE\t     | {characterInfo[9],-31} |");
            Console.WriteLine($"\t\t\t| EYE COLOR\t     | {characterInfo[10],-31} |");
            Console.WriteLine($"\t\t\t| FACIAL HAIR STYLE  | {characterInfo[11],-31} |");
            Console.WriteLine($"\t\t\t| SKIN WRINKLES\t     | {(characterInfo[12] == "1" ? "True" : "False"),-31} |");
            Console.WriteLine($"\t\t\t| SCAR\t\t     | {(characterInfo[13] =="1" ? "True" : "False"),-31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| OUTFIT SET\t     | {characterInfo[14],-31} |");
            Console.WriteLine($"\t\t\t| TOP CLOTHING\t     | {characterInfo[15],-31} |");
            Console.WriteLine($"\t\t\t| BOTTOM CLOTHING    | {characterInfo[16],-31} |");
            Console.WriteLine($"\t\t\t| FOOT WEAR\t     | {characterInfo[17],-31} |");
            Console.WriteLine($"\t\t\t| ACCESSORIES\t     | {characterInfo[18],-31} |");
            Console.WriteLine($"\t\t\t| TATTOO\t     | {(characterInfo[19] == "1" ? "True" : "False"),-31} |");
            Console.WriteLine($"\t\t\t| AURA\t\t     | {(characterInfo[20] == "1" ? "True" : "False"),-31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| MELEE WEAPON\t     | {characterInfo[21],-31} |");
            Console.WriteLine($"\t\t\t| FIGHTING STYLE     | {characterInfo[22],-31} |");
            Console.WriteLine($"\t\t\t| STANCE\t     | {characterInfo[23],-31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| ATTACK POWER\t     | {characterInfo[24],-31} |");
            Console.WriteLine($"\t\t\t| DEFENSE\t     | {characterInfo[25],-31} |");
            Console.WriteLine($"\t\t\t| SPEED\t\t     | {characterInfo[26],-31} |");
            Console.WriteLine($"\t\t\t| STAMINA\t     | {characterInfo[27],-31} |");
            Console.WriteLine($"\t\t\t| HEALTH\t     | {characterInfo[28],-31} |");
            Console.WriteLine($"\t\t\t| SPECIAL METER GAIN | {characterInfo[29],-31} |");
            Console.WriteLine($"\t\t\t+--------------------+---------------------------------+\n");

            Console.WriteLine("\t\t\t Press 'Enter' to Go Back...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            Console.Clear();
        }

        public void DeleteSelectedCharacter(Database database)
        {
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t       \t DELETING A CHARACTER!\t       \t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine($"\t\t\t| CHARACTER NAME: {selectedCharacterName, -36} |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            InputHandler inputHandler = new InputHandler();
            int deleteValidation = inputHandler.MultipleChoiceInput("ARE YOU SURE?");

            if (deleteValidation == 1)
            {
                if (database.DeleteCharacter(selectedCharacterName))
                {
                    Console.WriteLine("\t\t\t+------------------------------------------------------+");
                    Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                    Console.WriteLine("\t\t\t|\t    CHARACTER SUCCESSFULLY DELETED!\t       |");
                    Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                    Console.WriteLine("\t\t\t+------------------------------------------------------+\n");
                }
                else
                {
                    Console.WriteLine("\t\t\t+------------------------------------------------------+");
                    Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                    Console.WriteLine("\t\t\t|\t    \t  DELETING FAILED!\t\t       |");
                    Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                    Console.WriteLine("\t\t\t+------------------------------------------------------+\n");
                }

                Console.WriteLine("\t\t\tPress \"Enter\" to Go Back...");
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            }
            Console.Clear();
        }
    }
}
