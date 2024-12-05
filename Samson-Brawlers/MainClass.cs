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
                        main.CreateCharacter();
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
                        Console.WriteLine("\t\t\t\t\t\tEXITED!");
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

        public void CreateCharacter()
        {
            Character character = new Character();

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

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\t\t\t .");
                Thread.Sleep(800);
            }

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t     CHARACTER CREATED SUCCESSFULLY!\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+");

            Console.WriteLine("\n\n\nData:");
            Console.WriteLine("\nPHYSICAL APPEARANCE");
            Console.WriteLine("GENDER: " + character.physicalAppearance.Gender);
            Console.WriteLine("BODY TYPE: " + character.physicalAppearance.BodyType);
            Console.WriteLine("HEIGHT: " + character.physicalAppearance.Height);
            Console.WriteLine("SKIN COLOR: " + character.physicalAppearance.SkinColor);
            Console.WriteLine("SKIN WRINKLES: " + character.physicalAppearance.IsSkinWrinkles);
            Console.WriteLine("HAIR STYLE: " + character.physicalAppearance.HairStyle);
            Console.WriteLine("HAIR COLOR: " + character.physicalAppearance.HairColor);
            Console.WriteLine("HEAD SHAPE: " + character.physicalAppearance.HeadShape);
            Console.WriteLine("EYE SHAPE: " + character.physicalAppearance.EyeShape);
            Console.WriteLine("EYE COLOR: " + character.physicalAppearance.EyeColor);
            Console.WriteLine("FACIAL HAIR STYLE: " + character.physicalAppearance.FacialHairStyle);

            Console.WriteLine("\nCLOTHING & ACCESSORIES");
            Console.WriteLine("OUTFIT SET: " + character.clothesAccessories.OutfitSet);
            Console.WriteLine("TOP CLOTHING: " + character.clothesAccessories.TopClothing);
            Console.WriteLine("BOTTOM CLOTHING: " + character.clothesAccessories.BottomClothing);
            Console.WriteLine("FOOTWEAR: " + character.clothesAccessories.FootWear);
            Console.WriteLine("ACCESSORIES: " + character.clothesAccessories.Accessories);
            Console.WriteLine("TATTOO: " + character.clothesAccessories.IsTattoo);
            Console.WriteLine("SCAR: " + character.physicalAppearance.IsScar);
            Console.WriteLine("AURA: " + character.clothesAccessories.IsAura);

            Console.WriteLine("\nWEAPONS & ATTACKS");
            Console.WriteLine("MELEE WEAPON: " + character.weaponsAttacks.MeleeWeapon);
            Console.WriteLine("FIGHTING STYLE: " + character.weaponsAttacks.FightingStyle);
            Console.WriteLine("STANCE: " + character.weaponsAttacks.Stance);

            List<int> stats = character.stats.GetStatsValue();

            Console.WriteLine("\nSTATISTICS");
            Console.WriteLine("ATTACK POWER: " + stats[0]);
            Console.WriteLine("DEFENSE: " + stats[1]);
            Console.WriteLine("SPEED: " + stats[2]);
            Console.WriteLine("STAMINA: " + stats[3]);
            Console.WriteLine("HEALTH: " + stats[4]);
            Console.WriteLine("SPECIAL METER GAIN: " + stats[5]);

            Console.WriteLine("\nBIOGRAPHY");
            Console.WriteLine("NAME: " + character.Name);
            Console.WriteLine("TITLE: " + character.Title);

            characters.Add( character );
        }

        public void LoadGame()
        {
            Console.WriteLine("LIST OF CHARACTERS: \n");
            for( int i = 0; i < characters.Count; i++ )
            {
                Console.WriteLine("- " + characters[i].Name);
            }
        }
    }
}
