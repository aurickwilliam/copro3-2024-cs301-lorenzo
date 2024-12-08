using System;

namespace Samson_Brawlers
{
    public class Character
    {
        private string name, title;
        public Statistics stats;
        public PhysicalAppearance physicalAppearance = new PhysicalAppearance();
        public ClothesAccessories clothesAccessories = new ClothesAccessories();
        public WeaponsAttacks weaponsAttacks = new WeaponsAttacks();
        public InputHandler inputHandler = new InputHandler();

        public Character(string name, string title, string gender, string bodyType, string height, 
            string skinColor, string hairStyle, string hairColor, string headShape, string eyeShape,
            string eyeColor, string facialHairStyle, string outfitSet, string topClothing, 
            string bottomClothing, string footWear, string accessories, string meleeWeapon, string fightingStyle, 
            string stance, int isSkinWrinkles, int isTattoo, int isScar, int isAura, int attackPower,
            int defense, int speed, int stamina, int health, int specialMeterGain) 
        { 
            this.name = name;
            this.title = title;
            physicalAppearance.Gender = gender;
            physicalAppearance.BodyType = bodyType;
            physicalAppearance.Height = height;
            physicalAppearance.SkinColor = skinColor;
            physicalAppearance.HairStyle = hairStyle;
            physicalAppearance.HairColor = hairColor;
            physicalAppearance.HeadShape = headShape;
            physicalAppearance.EyeShape = eyeShape;
            physicalAppearance.EyeColor = eyeColor;
            physicalAppearance.FacialHairStyle = facialHairStyle;
            physicalAppearance.IsSkinWrinkles = isSkinWrinkles;
            physicalAppearance.IsScar = isScar;
            clothesAccessories.OutfitSet = outfitSet;
            clothesAccessories.TopClothing = topClothing;
            clothesAccessories.BottomClothing = bottomClothing;
            clothesAccessories.FootWear = footWear;
            clothesAccessories.Accessories = accessories;
            clothesAccessories.IsTattoo = isTattoo;
            clothesAccessories.IsAura = isAura;
            weaponsAttacks.MeleeWeapon = meleeWeapon;
            weaponsAttacks.FightingStyle = fightingStyle;
            weaponsAttacks.Stance= stance;
            
            stats = new Statistics(attackPower, defense, speed, stamina, health, specialMeterGain);
        }

        public Character()
        {
            
        }

        public string Name { get { return name; } set { name = value; } }
        public string Title { get { return title; } set { title = value; } }


        public void GetBiographyInput()
        {
            name = inputHandler.TextInput("ENTER YOUR CHARACTERS NAME:", 25, 8, false, true, "name");
            title = inputHandler.TextInput("ENTER YOUR CHARACTERS TITLE:", 30, 8, true, true, "title");
        }

        public void DisplayAllInfo()
        {
            Console.WriteLine("\t\t\t+------------------------------------------------------+");
            Console.WriteLine("\t\t\t|\t\t CHARACTER INFORMATION\t\t       |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| NAME\t\t     | {name, -31} |");
            Console.WriteLine($"\t\t\t| TITLE\t\t     | {title.Replace("\\", ""),-31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| GENDER\t     | {physicalAppearance.Gender,-31} |");
            Console.WriteLine($"\t\t\t| BODY TYPE\t     | {physicalAppearance.BodyType,-31} |");
            Console.WriteLine($"\t\t\t| HEIGHT\t     | {physicalAppearance.Height,-31} |");
            Console.WriteLine($"\t\t\t| SKIN COLOR\t     | {physicalAppearance.SkinColor,-31} |");
            Console.WriteLine($"\t\t\t| HAIR STYLE\t     | {physicalAppearance.HairStyle,-31} |");
            Console.WriteLine($"\t\t\t| HAIR COLOR\t     | {physicalAppearance.HairColor,-31} |");
            Console.WriteLine($"\t\t\t| HEAD SHAPE\t     | {physicalAppearance.HeadShape,-31} |");
            Console.WriteLine($"\t\t\t| EYE SHAPE\t     | {physicalAppearance.EyeShape,-31} |");
            Console.WriteLine($"\t\t\t| EYE COLOR\t     | {physicalAppearance.EyeColor,-31} |");
            Console.WriteLine($"\t\t\t| FACIAL HAIR STYLE  | {physicalAppearance.FacialHairStyle,-31} |");
            Console.WriteLine($"\t\t\t| SKIN WRINKLES\t     | {(physicalAppearance.IsSkinWrinkles == 1 ? "True" : "False"),-31} |");
            Console.WriteLine($"\t\t\t| SCAR\t\t     | {(physicalAppearance.IsScar == 1 ? "True" : "False"),-31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| OUTFIT SET\t     | {clothesAccessories.OutfitSet, -31} |");
            Console.WriteLine($"\t\t\t| TOP CLOTHING\t     | {clothesAccessories.TopClothing,-31} |");
            Console.WriteLine($"\t\t\t| BOTTOM CLOTHING    | {clothesAccessories.BottomClothing,-31} |");
            Console.WriteLine($"\t\t\t| FOOT WEAR\t     | {clothesAccessories.FootWear,-31} |");
            Console.WriteLine($"\t\t\t| ACCESSORIES\t     | {clothesAccessories.Accessories,-31} |");
            Console.WriteLine($"\t\t\t| TATTOO\t     | {(clothesAccessories.IsTattoo == 1 ? "True" : "False"),-31} |");
            Console.WriteLine($"\t\t\t| AURA\t\t     | {(clothesAccessories.IsAura == 1 ? "True" : "False"),-31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| MELEE WEAPON\t     | {weaponsAttacks.MeleeWeapon, -31} |");
            Console.WriteLine($"\t\t\t| FIGHTING STYLE     | {weaponsAttacks.FightingStyle, -31} |");
            Console.WriteLine($"\t\t\t| STANCE\t     | {weaponsAttacks.Stance, -31} |");
            Console.WriteLine("\t\t\t+--------------------+---------------------------------+");
            Console.WriteLine($"\t\t\t| ATTACK POWER\t     | {stats.AttackPower, -31} |");
            Console.WriteLine($"\t\t\t| DEFENSE\t     | {stats.Defense,-31} |");
            Console.WriteLine($"\t\t\t| SPEED\t\t     | {stats.Speed,-31} |");
            Console.WriteLine($"\t\t\t| STAMINA\t     | {stats.Stamina,-31} |");
            Console.WriteLine($"\t\t\t| HEALTH\t     | {stats.Health,-31} |");
            Console.WriteLine($"\t\t\t| SPECIAL METER GAIN | {stats.SpecialMeterGain,-31} |");
            Console.WriteLine($"\t\t\t+--------------------+---------------------------------+\n");
        }
    }
}
