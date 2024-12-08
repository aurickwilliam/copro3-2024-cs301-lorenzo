using System;

namespace Samson_Brawlers
{
    public class MainClass
    {
        private List<Character> characters = new List<Character>();

        static void Main(string[] args)
        {
            // Objects
            MainClass main = new MainClass();
            InputHandler inputHandler = new InputHandler();
            StoryMode story = new StoryMode();
            Credits credits = new Credits();

            bool isGameRunning = true;

            while(isGameRunning)
            {
                main.MainMenuTitle();

                string menuChoice = inputHandler.MenuInput();

                Console.Clear();

                switch (menuChoice)
                {
                    case "1":
                        main.NewGame();
                        break;
                    case "2":
                        main.LoadGame();
                        break;
                    case "3":
                        story.Display();
                        break;
                    case "4":
                        credits.Display();
                        break;
                    case "0":
                        Console.WriteLine("\n\t\t\t\t\t\tEXITED!\n");
                        isGameRunning = false;
                        break;
                }
            }
        }

        public void MainMenuTitle()
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
        }

        public void NewGame()
        {
            Character character = new Character();
            Database database = new Database();

            Console.WriteLine("\n\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\tCREATE YOUR OWN CHARACTER\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            // PHYSICAL APPEARANCE
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t   PHYSICAL APPEARANCE\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");

            character.physicalAppearance.GetInput();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t CLOTHING & ACCESSORIES\t       \t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");

            character.clothesAccessories.GetInput();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t   WEAPONS & ATTACKS\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");

            character.weaponsAttacks.GetInput();


            character.stats.GetInput();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t CHARACTERS BIOGRAPHY\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");

            character.GetBiographyInput();

            LoadingAnimation(3);
            if (database.InsertNewCharacter(character))
            {
                Console.WriteLine("\t\t\t+------------------------------------------------------+");
                Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                Console.WriteLine("\t\t\t|\t     CHARACTER CREATED SUCCESSFULLY!\t       |");
                Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                Console.WriteLine("\t\t\t+------------------------------------------------------+");
                character.DisplayAllInfo();
            }
            else
            {
                Console.WriteLine("\t\t\t+------------------------------------------------------+");
                Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                Console.WriteLine("\t\t\t|\t       CHARACTER CREATION FAILED!\t       |");
                Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                Console.WriteLine("\t\t\t+------------------------------------------------------+");
            }            

            characters.Add( character );
            Console.WriteLine("\n\t\t\tPress \"ENTER\" to Go Back to Main Menu...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) ;
            Console.Clear();
        }

        public void LoadGame()
        {
            Database database = new Database();
            LoadGameFunctions load = new LoadGameFunctions();
            bool isLoadGameRunning = true;
            do
            {
                Console.WriteLine("\t\t\t+------------------------------------------------------+");
                Console.WriteLine("\t\t\t| \t\tSELECT AN OPERATION\t\t       |");
                Console.WriteLine("\t\t\t+------------------------------------------------------+");
                Console.WriteLine("\t\t\t| 1 -> DISPLAY CHARACTER INFO\t\t\t       |");
                Console.WriteLine("\t\t\t| 2 -> DELETE A CHARACTER\t\t\t       |");
                Console.WriteLine("\t\t\t| 0 -> GO BACK\t\t\t\t\t       |");
                Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

                int input;
                do
                {
                    try
                    {
                        Console.Write("\t\t\t  -> ");
                        input = Convert.ToInt32(Console.ReadLine());

                        if (input < 0)
                        {
                            throw new InputNotAChoiceException();
                        }
                        else if (input > 3)
                        {
                            throw new InputNotAChoiceException();
                        }

                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("\n\t\t\t  PLEASE ENTER A NUMBER VALUE!\n");
                    }
                    catch (InputNotAChoiceException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                while (true);

                Console.Clear();

                switch (input)
                {
                    case 1:
                        if (!load.GetSelectedCharacter(database))
                        {
                            break;
                        }
                        load.DisplayCharacterInfo(database);
                        break;
                    case 2:
                        if (!load.GetSelectedCharacter(database))
                        {
                            break;
                        }
                        load.DeleteSelectedCharacter(database);
                        break;
                    case 0:
                        isLoadGameRunning = false;
                        break;
                }
                Console.Clear();
            }
            while (isLoadGameRunning);
        }
        
        public void LoadingAnimation(int seconds)
        {
            string[] graphics = 
                [
                    "\t\t\t\t\t\t /",
                    "\t\t\t\t\t\t -",
                    "\t\t\t\t\t\t \\",
                    "\t\t\t\t\t\t |",
                    "\t\t\t\t\t\t /",
                    "\t\t\t\t\t\t -",
                    "\t\t\t\t\t\t \\",
                    "\t\t\t\t\t\t |"
                ];

            int loopCount = (seconds * 1000) / 300;

            for(int i = 0; i < seconds * 1.5; i++)
            {
                foreach(string graphic in graphics)
                {
                    Console.WriteLine();
                    Console.WriteLine(graphic);
                    Thread.Sleep(100);
                    Console.Clear();
                }
            }
        }
    }
}
