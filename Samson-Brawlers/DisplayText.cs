using System;

namespace Samson_Brawlers
{
    public abstract class DisplayText
    {
        public abstract void Display();

        public bool GoBackToMainMenu()
        {
            Console.WriteLine("\n\t Press 'Enter' to Go Back to Main Menu...");
            while(Console.ReadKey(true).Key != ConsoleKey.Enter);

            return true;
        }
    }
}
