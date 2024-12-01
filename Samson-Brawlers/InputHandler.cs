using System;


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
                    Console.WriteLine("PLEASE INPUT A VALUE!");
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
        public string MultipleChoiceQuestion(string question, string[] choices)
        {
            string input = "";

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+");


            do
            {
                try
                {
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("PLEASE INPUT A VALUE!");
                }
            }
            while (true);

            return input;
        }



        // ====================
        // PHYSICAL APPEARANCE
        // ====================

        // GENDER
        public string GenderInput()
        {
            string gender = "";




            return "";
        }
    }
}
