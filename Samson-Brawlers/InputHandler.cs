using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Samson_Brawlers
{
    public class InputHandler
    {
        // Get Menu Input and Validate it
        public string MenuInput()
        {
            string input = "";

            do
            {
                try
                {
                    Console.Write("\t\t\t\t\t-> ");
                    input = Console.ReadLine();

                    // Will trigger the exception
                    int inputInt = Convert.ToInt32(input);

                    if (inputInt < 0)
                    {
                        throw new InputNotAChoiceException();
                    }
                    else if (inputInt > 4)
                    {
                        throw new InputNotAChoiceException();
                    }

                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\t\t\t\t\tPLEASE INPUT A NUMBER VALUE!\n");
                }
                catch (InputNotAChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);
            
            return input;
        }

        // Template for Q.A.
        public int MultipleChoiceQuestion(string question, string[] choices)
        {
            int inputInt = 0;

            // Display the Question and Choices
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine($"\t\t\t|  {question.ToUpper(), -50}  |");

            for (int i = 0; i < choices.Length; i++)
            {
                string choice = $"{i + 1} -> {choices[i]}";
                Console.WriteLine($"\t\t\t|  {choice,-50}  |");
            }

            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            do
            {
                try
                {
                    Console.Write("\t\t\t  -> ");
                    string input = Console.ReadLine();

                    // Check if the input is valid
                    inputInt = Convert.ToInt32(input);

                    if(inputInt < 1)
                    {
                        throw new InputNotAChoiceException();
                    }
                    else if(inputInt > choices.Length)
                    {
                        throw new InputNotAChoiceException();
                    }

                    Console.WriteLine();
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\t\t\tPLEASE INPUT A NUMBER VALUE!\n");
                }
                catch (InputNotAChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

            return inputInt;
        }



        // =============================================================
        // PHYSICAL APPEARANCE
        // =============================================================

        // GENDER
        public string GenderInput()
        {
            string question = "CHOOSE A GENDER:";
            string[] choices = { "MALE", "FEMALE" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // BODY TYPE
        public string BodyTypeInput()
        {
            string question = "CHOOSE A BODY TYPE:";
            string[] choices = { "STANDARD", "HEAVYWEIGHT", "AGILE", "GRAPPLER", "GIANT" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // HEIGHT
        public string HeightInput()
        {
            string question = "CHOOSE THE CHARACTERS HEIGHT:";
            string[] choices = { "SMALL (3'0 - 5'0)", "AVERAGE (5'5 - 6'0)", "TALL (6'5 - 7'5)" };
            
            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // SKIN COLOR
        public string SkinColorInput()
        {
            string question = "CHOOSE A SKIN TONE/COLOR:";
            string[] choices = { "FAIR", "LIGHT TAN", "MEDIUM", "DARK BROWN", "BLACK" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // SKIN WRINKLES
        public bool SkinWrinklesInput()
        {
            string question = "ADD SKIN WRINKLES:";
            string[] choices = { "YES", "NO" };

            int choice = MultipleChoiceQuestion(question, choices) - 1;

            return choice == 0;
        }

        // HAIR STYLE
        public string HairStyleInput()
        {
            string question = "CHOOSE A HAIR STYLE:";
            string[] choices = { "UNDERCUT", "SLICKED BACK", "BRAIDED HAIR", "MAN BUN", "BUZZ CUT", "HIGH PONYTAIL", "PIXIE CUT", "LOOSE CURLS", "BOB CUT", "DREADLOCKS" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }


        // HAIR COLOR
        public string HairColorInput()
        {
            string question = "CHOOSE A HAIR COLOR:";
            string[] choices = { "CHARCOAL BLACK", "DARK BROWN", "YELLOWSTONE", "FIERY RED", "SMOKEY WHITE", "SKY BLUE", "REBECCA PURPLE", "UNICORN PINK" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // HEAD SHAPE
        public string HeadShapeInput()
        {
            string question = "CHOOSE A HEAD SHAPE:";
            string[] choices = { "SQUARE", "OVAL", "ROUND", "TRIANGULAR", "DIAMOND" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // EYE SHAPE
        public string EyeShapeInput()
        {
            string question = "CHOOSE AN EYE SHAPE:";
            string[] choices = {"ALMOND", "ROUND", "HOODED", "UPTURNED", "NARROW/SLITTED"};

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // EYE COLOR
        public string EyeColorInput()
        {
            string question = "CHOOSE A EYE COLOR:";
            string[] choices = { "CHARCOAL BLACK", "DARK BROWN", "YELLOWSTONE", "FIERY RED", "SMOKEY WHITE", "SKY BLUE", "REBECCA PURPLE", "UNICORN PINK" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // FACIAL HAIR STYLE
        public string FacialHairStyleInput()
        {
            string question = "CHOOSE A FACIAL HAIR STYLE:";
            string[] choices = {"FULL BEARD", "GOATEE", "MUSTACHE", "STUBBLE", "SIDEBURNS", "NONE"};

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // =============================================================
        // CLOTHING & ACCESSORIES
        // =============================================================

        // OUTFIT SET
        public string OutfitSetInput()
        {
            string question = "SELECT AN OUTFIT SET:";
            string[] choices = { "MARTIAL ARTS UNIFORM", "CHINESE TRADITIONAL OUTFIT", "GYM OUTFIT", "CASUAL WEAR", "ARMOR SUIT" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // TOP CLOTHING
        public string TopClothingInput()
        {
            string question = "SELECT THE TOP CLOTHING:";
            string[] choices = { "BLOUSE", "JACKET", "T-SHIRT", "TANK TOP", "ROBES", "TAEKWONDO OUTFIT TOP" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        //  BOTTOM CLOTHING
        public string BottomClothingInput()
        {
            string question = "SELECT THE BOTTOM CLOTHING:";
            string[] choices = { "BAGGY JEANS", "SKIRT", "TAEKWONDO OUTFIT BOTTOM", "LEGGINGS", "CARGO PANTS", "SLACKS" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // FOOTWEAR
        public string FootWearInput()
        {
            string question = "SELECT A FOOTWEAR:";
            string[] choices = { "BOOTS", "SLIPPERS", "SNEAKERS", "HEELS", "LOAFERS" };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // ACCESSORIES
        public string AccessoriesInput()
        {
            string question = "SELECT AN ACCESSORIES:";
            string[] choices =
            {
                "SAMURAI HELMET",
                "BASEBALL CAP",
                "WWII HELEMET",
                "VIKING HELMET",
                "BANDANA",
                "ANTLERS",
                "DARK INVADER SPACE HELMET",
                "CASIO WATCH",
                "HANDCUFFS",
                "PIERCINGS",
                "COVID-19 MASK",
                "NINJA MASK",
                "EYE GLASSES",
                "LUCIFER WINGS",
                "CAPE"
            };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // TATTOO
        public bool TattooInput()
        {
            string question = "ADD CHARACTERS TATTOO:";
            string[] choices = { "YES", "NO" };

            int choice = MultipleChoiceQuestion(question, choices) - 1;

            return choice == 0;
        }

        // SCAR
        public bool ScarInput()
        {
            string question = "ENABLE SCAR APPEARANCE:";
            string[] choices = { "ON", "OFF" };

            int choice = MultipleChoiceQuestion(question, choices) - 1;

            return choice == 0;
        }

        // AURA
        public bool AuraInput()
        {
            string question = "ENABLE CHARACTERS AURA APPEARANCE:";
            string[] choices = { "ON", "OFF" };

            int choice = MultipleChoiceQuestion(question, choices) - 1;

            return choice == 0;
        }

        // =============================================================
        // WEAPONS & ATTACKS
        // =============================================================

        // MELEE WEAPON
        public string MeleeWeaponInput()
        {
            string question = "SELECT A MELEE WEAPON:";
            string[] choices =
                {
                    "BRASS KNUCKLE",
                    "NUN-CHUCKS",
                    "BASEBALL BAT",
                    "WOODEN STICK",
                    "FIST"
                };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // STANCE

        public string StanceInput()
        {
            string question = "CHOOSE THE CHARACTERS STANCE:";
            string[] choices =
            {
                "KARATE FIGHTING STANCE",
                "ORTHODOX BOXING STANCE",
                "CROUCHING STANCE",
                "SUMO STANCE",
                "BOW STANCE",
                "MONKEY STANCE"
            };

            return choices[MultipleChoiceQuestion(question, choices) - 1];
        }

        // FIGHTING STYLE

        public string FightingStyleInput()
        {
            Console.WriteLine("\t\t+-----------------------------------------------------------------------+");
            Console.WriteLine("\t\t|\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t|\t\t\tCHOOSE A FIGHTING STYLE\t\t\t\t|");
            Console.WriteLine("\t\t|\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 1 -> BOXING\t\t\t| Focuses on powerful punches, \t\t|");
            Console.WriteLine("\t\t|\t\t\t\t| defensive head movement, and precise \t|");
            Console.WriteLine("\t\t|\t\t\t\t| footwork, emphasizing endurance and \t|");
            Console.WriteLine("\t\t|\t\t\t\t| timing.\t\t\t\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 2 -> MUAY THAI\t\t| A striking art that uses punches,\t| ");
            Console.WriteLine("\t\t|\t\t\t\t| kicks, elbows, and knees, combined \t|");
            Console.WriteLine("\t\t|\t\t\t\t| with clinching techniques for \t|");
            Console.WriteLine("\t\t|\t\t\t\t| close-range combat.\t\t\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 3 -> KICKBOXING\t\t| Blends punching and kicking \t\t|");
            Console.WriteLine("\t\t|\t\t\t\t| techniques, often with a focus on \t|");
            Console.WriteLine("\t\t|\t\t\t\t| continuous striking and dynamic \t|");
            Console.WriteLine("\t\t|\t\t\t\t| movement.\t\t\t\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 4 -> KARATE\t\t\t| A traditional martial art emphasizing\t| ");
            Console.WriteLine("\t\t|\t\t\t\t| sharp strikes, disciplined forms, and |");
            Console.WriteLine("\t\t| \t\t\t\t| defensive blocking techniques.\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 5 -> JUJUTSU\t\t\t| A grappling art designed to \t\t|");
            Console.WriteLine("\t\t|\t\t\t\t| neutralize opponents using joint \t|");
            Console.WriteLine("\t\t| \t\t\t\t| locks, chokes, and throws, leveraging |");
            Console.WriteLine("\t\t| \t\t\t\t| an opponent’s force.\t\t\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 6 -> TAEKWONDO\t\t| Known for its flashy, high kicks and \t|");
            Console.WriteLine("\t\t|\t\t\t\t| fast-paced combinations, emphasizing \t|");
            Console.WriteLine("\t\t| \t\t\t\t| precision and flexibility in attacks.\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 7 -> SUMO\t\t\t| A traditional Japanese grappling\t|");
            Console.WriteLine("\t\t|\t\t\t\t| sport where two wrestlers aim to \t|");
            Console.WriteLine("\t\t|\t\t\t\t| push or throw each other out.\t\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+");
            Console.WriteLine("\t\t| 8 -> JUDO\t\t\t| Combines throws, pins, and \t\t|");
            Console.WriteLine("\t\t|\t\t\t\t| submissions, focusing on using \t|");
            Console.WriteLine("\t\t|\t\t\t\t| balance and leverage to overpower \t|");
            Console.WriteLine("\t\t|\t\t\t\t| opponents.\t\t\t\t|");
            Console.WriteLine("\t\t+-------------------------------+---------------------------------------+\n");

            int inputInt = 0;
            string[] choices =
            {
                "BOXING",
                "MUAY THAI",
                "KICKBOXING",
                "KARATE",
                "JUJUTSU",
                "TAEKWONDO",
                "SUMO",
                "JUDO"
            };

            do
            {
                try
                {
                    Console.Write("\t\t\t  -> ");
                    string input = Console.ReadLine();

                    // Check if the input is valid
                    inputInt = Convert.ToInt32(input);

                    if (inputInt < 1)
                    {
                        throw new InputNotAChoiceException();
                    }
                    else if (inputInt > choices.Length)
                    {
                        throw new InputNotAChoiceException();
                    }

                    Console.WriteLine();
                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\t\t\t PLEASE INPUT A NUMBER VALUE!\n");
                }
                catch (InputNotAChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

            return choices[inputInt - 1];
        }
        

        // STATISTICS
        public List<int> StatisticsInput()
        {
            List<int> stats = new List<int>() { 0, 0, 0, 0, 0, 0};

            int availablePts = 20;

            DisplayStats(stats, availablePts);

            Console.WriteLine("\t\t \t Choose a Stat to modify and ");
            Console.WriteLine("\t\t \t Enter \"+\" to add 1 point or \"-\" to minus 1 point");
            Console.WriteLine("\t\t \t (eg. 1+)\n");
            Console.WriteLine("\t\t\t Press \"R\" to Reset Values\n");

            do
            {
                try
                {
                    Console.Write("\t\t\t  -> ");
                    string input = Console.ReadLine();

                    if (input == "R" || input == "r")
                    {
                        for (int i = 0; i < stats.Count; i++)
                        {
                            stats[i] = 0;
                        }
                        availablePts = 20;
                        DisplayStats(stats, availablePts);
                        continue;
                    }

                    int statIndex = Convert.ToInt32(input.Substring(0, 1)) - 1;

                    if (input.Length > 2)
                    {
                        throw new FormatException();
                    }


                    if (input[1] == '+')
                    {
                        if (stats[statIndex] < 10)
                        {
                            stats[statIndex] += 1;
                            availablePts--;
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t\t MAXIMUM POINTS HAVE BEEN REACHED FOR THIS STAT!\n");
                            continue;
                        }
                    }
                    else if (input[1] == '-')
                    {
                        if (stats[statIndex] > 0)
                        {
                            stats[statIndex] -= 1;
                            availablePts++;
                        }
                        else
                        {
                            Console.WriteLine("\n\t\t\t 0 IS NOW THE CURRENT VALUE!\n");
                            continue;
                        }
                    }
                    else
                    {
                        throw new FormatException();
                    }


                    Console.WriteLine();
                    DisplayStats(stats, availablePts);

                    if (availablePts == 0)
                    {
                        break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\t\t\t INVALID INPUT, ENTER THE CORRECT VALUE!\n");
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("\n\t\t\t INVALID INPUT, ENTER THE CORRECT VALUE!\n");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("\n\t\t\t INVALID INPUT, ENTER THE CORRECT VALUE!\n");
                }
            }
            while (true);

            return stats;
        }

        public void DisplayStats(List<int> stats, int availablePts)
        {
            Console.WriteLine("\t\t+-----------------------------------------------------------------------+");
            Console.WriteLine("\t\t|\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t|\t\t\t CHARACTER STATISTICS\t\t\t\t|");
            Console.WriteLine("\t\t|\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t+-----------------------------------------------------------------------+");
            Console.WriteLine($"\t\t| AVAILABLE POINTS: {availablePts}\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine("\t\t| STATS\t\t\t| CURRENT VALUE\t| DESCRIPTION\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 1 -> ATTACK POWER\t| {stats[0], -13} | Increases the damage dealt by\t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| attacks.\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 2 -> DEFENSE\t\t| {stats[1],-13} | Reduces damage taken.\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 3 -> SPEED\t\t| {stats[2],-13} | Affects movement and attack\t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| speed.\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 4 -> STAMINA\t\t| {stats[3],-13} | Determines endurance for \t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| special moves or blocking\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 5 -> HEALTH\t\t| {stats[4],-13} | Extends the character's\t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| overall hit points.\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 6 -> Special Meter\t| {stats[5],-13} | Increases the rate at which\t|");
            Console.WriteLine("\t\t|      Gain\t\t|\t\t| special or ultimate meter \t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| charge.\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+\n");
        }

        // =============================================================
        // CHARACTER BIOGRAPHY
        // =============================================================

        // Name
        public string NameInput()
        {
            string input = "";

            Console.WriteLine("\t\t\t ENTER YOUR CHARACTERS NAME:");
            Console.WriteLine("\t\t\t (MAX. 25 CHARS : NO SPECIAL CHAR)\n");

            do
            {
                try
                {
                    Console.Write("\t\t\t -> ");
                    input = Console.ReadLine();

                    if (input == "")
                    {
                        throw new FormatException("\n\t\t\t PLEASE ENTER A VALUE!\n");
                    }

                    if(input.Length > 25)
                    {
                        throw new FormatException("\n\t\t\t MAXIMUM CHARACTER HAS BEEN REACHED!\n");
                    }

                    bool hasSpecialChars = Regex.IsMatch(input, "[^a-zA-Z0-9]");

                    if (hasSpecialChars)
                    {
                        throw new InvalidCharacterException();
                    }

                    break;
                }
                catch(InvalidCharacterException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

            return input;
        }

        public string TitleInput()
        {
            string input = "";

            Console.WriteLine("\t\t\t ENTER YOUR CHARACTERS TITLE:");
            Console.WriteLine("\t\t\t (MAX. 50 CHARS)\n");

            do
            {
                try
                {
                    Console.Write("\t\t\t -> ");
                    input = Console.ReadLine();

                    if (input == "")
                    {
                        throw new FormatException("\n\t\t\t PLEASE ENTER A VALUE!\n");
                    }

                    if (input.Length > 50)
                    {
                        throw new FormatException("\n\t\t\t MAXIMUM CHARACTER HAS BEEN REACHED!\n");
                    }

                    break;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

            return input;
        }

    }
}
