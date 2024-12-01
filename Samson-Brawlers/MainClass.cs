using System;

namespace Samson_Brawlers
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+=======================================================================================================+");
            Console.WriteLine("|\t\t\t  _________                           \t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t /   _____/____    _____   __________   ____              \t\t\t|");
            Console.WriteLine("|\t\t\t \\_____  \\\\__  \\  /     \\ /  ___/  _ \\ /    \\             \t\t\t|");
            Console.WriteLine("|\t\t\t /        \\/ __ \\|  Y Y  \\\\___ (  <_> )   |  \\            \t\t\t|");
            Console.WriteLine("|\t\t\t/_______  (____  /__|_|  /____  >____/|___|  /            \t\t\t|");
            Console.WriteLine("|\t\t\t        \\/     \\/      \\/     \\/           \\/             \t\t\t|");
            Console.WriteLine("|\t\t\t__________                      .__                       \t\t\t|");
            Console.WriteLine("|\t\t\t\\______   \\____________ __  _  _|  |   ___________  ______\t\t\t|");
            Console.WriteLine("|\t\t\t |    |  _/\\_  __ \\__  \\\\ \\/ \\/ /  | _/ __ \\_  __ \\/  ___/\t\t\t|");
            Console.WriteLine("|\t\t\t |    |   \\ |  | \\// __ \\\\     /|  |_\\  ___/|  | \\/\\___ \\ \t\t\t|");
            Console.WriteLine("|\t\t\t |______  / |__|  (____  /\\/\\_/ |____/\\___  >__|  /____  >\t\t\t|");
            Console.WriteLine("|\t\t\t        \\/             \\/                 \\/           \\/ \t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t+-----------------------+\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t|\tMAIN MENU\t|\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t+-----------------------+\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t|  1 -> NEW GAME\t|\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t|  2 -> LOAD GAME\t|\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t|  3 -> CAMPAIGN MODE\t|\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t|  4 -> CREDITS\t\t|\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t|  0 -> EXIT GAME\t|\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t+-----------------------+\t\t\t\t\t|");
            Console.WriteLine("|\t\t\t\t\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("+=======================================================================================================+\n");

            // Objects
            MainClass main = new MainClass();
            InputHandler inputHandler = new InputHandler();

            string menuChoice = inputHandler.MenuInput();
           
            switch(menuChoice)
            {
                case "1":
                    Console.WriteLine("\n\t\t\t+------------------------------------------------------+");
                    Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                    Console.WriteLine("\t\t\t|\t\tCREATE YOUR OWN CHARACTER\t       |");
                    Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                    Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

                    main.CreateCharacter(inputHandler);

                    break;
            }
        }

        public void CreateCharacter(InputHandler inputHandler)
        {
            
        }
    }
}
