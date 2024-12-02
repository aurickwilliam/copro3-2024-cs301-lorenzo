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

            bool isGameRunning = true;

            while(isGameRunning)
            {
                main.MainMenuTitle();

                string menuChoice = inputHandler.MenuInput();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("\n\t\t\t+------------------------------------------------------+");
                        Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                        Console.WriteLine("\t\t\t|\t\tCREATE YOUR OWN CHARACTER\t       |");
                        Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
                        Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

                        main.CreateCharacter(inputHandler);

                        break;
                    case "2":
                        break;
                    case "3":
                        story.DisplayStory();
                        break;
                    case "4":
                        break;
                }



                Console.WriteLine("\n\n\n");
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

        public void CreateCharacter(InputHandler inputHandler)
        {
            // PHYSICAL APPEARANCE
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t   PHYSICAL APPEARANCE\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");

            string gender = inputHandler.GenderInput();
            string bodyType = inputHandler.BodyTypeInput();
            string height = inputHandler.HeightInput();
            string skinColor = inputHandler.SkinColorInput();
            bool skinWrinkles = inputHandler.SkinWrinklesInput();
            string hairStyle = inputHandler.HairStyleInput();
            string hairColor = inputHandler.HairColorInput();
            string headShape = inputHandler.HeadShapeInput();
            string eyeShape = inputHandler.EyeShapeInput();
            string eyeColor = inputHandler.EyeColorInput();
            string facialHairStyle = inputHandler.FacialHairStyleInput();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t CLOTHING & ACCESSORIES\t       \t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");

            string outfitSet = inputHandler.OutfitSetInput();
            string topClothing = inputHandler.TopClothingInput();
            string bottomClothing = inputHandler.BottomClothingInput();
            string footWear = inputHandler.FootWearInput();
            string accessories = inputHandler.AccessoriesInput();
            bool tattoo = inputHandler.TattooInput();
            bool scar = inputHandler.ScarInput();
            bool aura = inputHandler.AuraInput();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t   WEAPONS & ATTACKS\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");

            string meleeWeapon = inputHandler.MeleeWeaponInput();
            string fightingStyle = inputHandler.FightingStyleInput();
            string stance = inputHandler.StanceInput();

            List<int> stats = inputHandler.StatisticsInput();

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t\t CHARACTERS BIOGRAPHY\t\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            string name = inputHandler.NameInput();
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");
            string title = inputHandler.TitleInput();
            Console.WriteLine("\t\t\t+------------------------------------------------------+\n");

            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t|\t     CHARACTER CREATED SUCCESSFULLY!\t       |");
            Console.WriteLine("\t\t\t|\t\t\t\t\t\t       |");
            Console.WriteLine("\t\t\t+------------------------------------------------------+");

            Console.WriteLine("\n\n\nData:");
            Console.WriteLine("\nPHYSICAL APPEARANCE");
            Console.WriteLine("GENDER: " + gender);
            Console.WriteLine("BODY TYPE: " + bodyType);
            Console.WriteLine("HEIGHT: " + height);
            Console.WriteLine("SKIN COLOR: " + skinColor);
            Console.WriteLine("SKIN WRINKLES: " + skinWrinkles);
            Console.WriteLine("HAIR STYLE: " + hairStyle);
            Console.WriteLine("HAIR COLOR: " + hairColor);
            Console.WriteLine("HEAD SHAPE: " + headShape);
            Console.WriteLine("EYE SHAPE: " + eyeShape);
            Console.WriteLine("EYE COLOR: " + eyeColor);
            Console.WriteLine("FACIAL HAIR STYLE: " + facialHairStyle);

            Console.WriteLine("\nCLOTHING & ACCESSORIES");
            Console.WriteLine("OUTFIT SET: " + outfitSet);
            Console.WriteLine("TOP CLOTHING: " + topClothing);
            Console.WriteLine("BOTTOM CLOTHING: " + bottomClothing);
            Console.WriteLine("FOOTWEAR: " + footWear);
            Console.WriteLine("ACCESSORIES: " + accessories);
            Console.WriteLine("TATTOO: " + tattoo);
            Console.WriteLine("SCAR: " + scar);
            Console.WriteLine("AURA: " + aura);

            Console.WriteLine("\nWEAPONS & ATTACKS");
            Console.WriteLine("MELEE WEAPON: " + meleeWeapon);
            Console.WriteLine("FIGHTING STYLE: " + fightingStyle);
            Console.WriteLine("STANCE: " + stance);

            Console.WriteLine("\nSTATISTICS");
            Console.WriteLine("ATTACK POWER: " + stats[0]);    
            Console.WriteLine("DEFENSE: " + stats[1]);    
            Console.WriteLine("SPEED: " + stats[2]);    
            Console.WriteLine("STAMINA: " + stats[3]);    
            Console.WriteLine("HEALTH: " + stats[4]);    
            Console.WriteLine("SPECIAL METER GAIN: " + stats[5]);

            Console.WriteLine("\nBIOGRAPHY");
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("TITLE: " + title);

            Character character = new Character(
                    name,
                    title,
                    gender,
                    bodyType,
                    height,
                    skinColor,
                    hairStyle,
                    hairColor,
                    headShape,
                    eyeShape,
                    eyeColor,
                    facialHairStyle,
                    outfitSet,
                    topClothing,
                    bottomClothing,
                    footWear,
                    accessories,
                    meleeWeapon,
                    fightingStyle,
                    stance,
                    skinWrinkles,
                    tattoo,
                    scar,
                    aura,
                    stats[0],
                    stats[1],
                    stats[2],
                    stats[3],
                    stats[4],
                    stats[5]
                );

            characters.Add( character );
        }
    }
}
