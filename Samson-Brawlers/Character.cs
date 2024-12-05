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
            string stance, bool isSkinWrinkles, bool isTattoo, bool isScar, bool isAura, int attackPower,
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
            name = inputHandler.TextInput("ENTER YOUR CHARACTERS NAME:", 25, 8, false, true);
            title = inputHandler.TextInput("ENTER YOUR CHARACTERS TITLE:", 50, 8, true, true);
        }

    }
}
