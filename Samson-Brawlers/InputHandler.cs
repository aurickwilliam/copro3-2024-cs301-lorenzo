using System;
using System.Text.RegularExpressions;

namespace Samson_Brawlers
{
    public class InputHandler
    {
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

        public string MultipleChoiceInput(string question, string[] choices)
        {

            // Display the Question and Choices
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine($"\t\t\t|  {question.ToUpper(),-50}  |");

            for (int i = 0; i < choices.Length; i++)
            {
                string choice = $"{i + 1} -> {choices[i]}";
                Console.WriteLine($"\t\t\t|  {choice,-50}  |");
            }

            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            int inputInt = 0;
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
                    Console.WriteLine("\n\t\t\tPLEASE INPUT A NUMBER VALUE!\n");
                }
                catch (InputNotAChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

            Console.Clear();

            return choices[inputInt - 1];
        }

        public string MultipleChoiceInput(string[] promptArray, string[] choices)
        {

            foreach (string line in promptArray)
            {
                Console.WriteLine(line);
            }

            int inputInt = 0;

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

            Console.Clear();

            return choices[inputInt - 1];
        }

        public int MultipleChoiceInput(string question)
        {
            string[] choices = ["YES", "NO"];

            // Display the Question and Choices
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine($"\t\t\t|  {question.ToUpper(),-50}  |");

            for (int i = 0; i < choices.Length; i++)
            {
                string choice = $"{i + 1} -> {choices[i]}";
                Console.WriteLine($"\t\t\t|  {choice,-50}  |");
            }

            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            int inputInt = 0;
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
                    Console.WriteLine("\n\t\t\tPLEASE INPUT A NUMBER VALUE!\n");
                }
                catch (InputNotAChoiceException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

            Console.Clear();

            return inputInt == 1 ? 1 : 0;
        }


        public string TextInput(string question, int maxChar, int minChar, bool hasSpecialChar, bool isAlphanumeric, string type)
        {
            string input = "";

            string specialChar = hasSpecialChar ? "/" : "X";
            string alphanumeric = isAlphanumeric ? "/" : "X";
            Database database = new Database();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine($"\t\t\t|  {question.ToUpper(),-50}  |");
            Console.WriteLine($"\t\t\t| - MAX. {maxChar} CHARS : MIN. {minChar} CHARS\t\t       |");
            Console.WriteLine($"\t\t\t| - ({specialChar}) SPECIAL CHAR\t\t\t\t       |");
            Console.WriteLine($"\t\t\t| - ({alphanumeric}) ALPHANUMERIC\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            do
            {
                try
                {
                    Console.Write("\t\t\t -> ");
                    input = Console.ReadLine();

                    // Check if the input is empty
                    if (input == "")
                    {
                        throw new InvalidInputException("\n\t\t\t PLEASE ENTER A VALUE!\n");
                    }

                    // Check the minimum and maximum char
                    if (input.Length > maxChar)
                    {
                        throw new InvalidInputException("\n\t\t\t MAXIMUM CHARACTER HAS BEEN REACHED!\n");
                    }
                    else if (input.Length < minChar)
                    {
                        throw new InvalidInputException($"\n\t\t\t MINIMUM CHARACTER IS {minChar}!\n");
                    }
                    

                    // Check if the input has a Special Character using RegEx
                    if (!hasSpecialChar)
                    {
                        bool inputHasSpecialChar = Regex.IsMatch(input, "[^a-zA-Z0-9]");

                        if (inputHasSpecialChar)
                        {
                            throw new InvalidCharacterException();
                        }
                    }

                    // Check if the input is Alphanumeric
                    if (!isAlphanumeric)
                    {
                        bool inputIsAlphanumeric = input.Any(char.IsDigit);

                        if (inputIsAlphanumeric)
                        {
                            throw new InvalidCharacterException();
                        }
                    }

                    if(type == "name")
                    {
                        if(database.CheckIfValueAlreadyExist("name", input))
                        {
                            throw new ValueAlreadyExistException();
                        }
                    }
                    else if (type == "title")
                    {
                        input = input.Replace("'", "\\'");
                        input = input.Replace("\"", "\\\"");
                    }

                    break;
                }
                catch (InvalidCharacterException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ValueAlreadyExistException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (true);

            Console.Clear();

            return input;
        }
    }
}