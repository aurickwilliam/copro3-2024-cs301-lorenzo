using System;

namespace Samson_Brawlers
{
    public class ClothesAccessories : InputHandler, IGetInput
    {
        private string outfitSet;
        private string topClothing;
        private string bottomClothing;
        private string footWear;
        private string accessories;
        private int isTattoo;
        private int isAura;

        public string OutfitSet { get { return outfitSet; } set { outfitSet = value; } }
        public string TopClothing { get { return topClothing; } set { topClothing = value; } }
        public string BottomClothing { get {return bottomClothing; } set { bottomClothing = value; } }
        public string FootWear { get { return footWear; } set { footWear = value; } }
        public string Accessories { get { return accessories; } set { accessories = value; } }
        public int IsTattoo { get { return isTattoo; } set { isTattoo = value; } }
        public int IsAura { get { return isAura; } set { isAura = value; } }
        
        public void GetInput()
        {
            outfitSet = MultipleChoiceInput("SELECT AN OUTFIT SET:", 
                    [
                        "MARTIAL ARTS UNIFORM",
                        "CHINESE TRADITIONAL OUTFIT",
                        "GYM OUTFIT",
                        "CASUAL WEAR",
                        "ARMOR SUIT"
                    ]);

            topClothing = MultipleChoiceInput("SELECT THE TOP CLOTHING:",
                    [
                        "BLOUSE",
                        "JACKET",
                        "T-SHIRT",
                        "TANK TOP",
                        "ROBES",
                        "TAEKWONDO OUTFIT TOP"
                    ]);

            bottomClothing = MultipleChoiceInput("SELECT THE BOTTOM CLOTHING:",
                    [
                        "BAGGY JEANS",
                        "SKIRT",
                        "TAEKWONDO OUTFIT BOTTOM",
                        "LEGGINGS",
                        "CARGO PANTS",
                        "SLACKS"
                    ]);

            footWear = MultipleChoiceInput("SELECT A FOOTWEAR:", 
                    [
                        "BOOTS",
                        "SLIPPERS",
                        "SNEAKERS",
                        "HEELS",
                        "LOAFERS"
                    ]);

            accessories = MultipleChoiceInput("SELECT AN ACCESSORIES:", 
                    [
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
                    ]);

            isTattoo = MultipleChoiceInput("ADD CHARACTERS TATTOO:");

            isAura = MultipleChoiceInput("ENABLE SCAR APPEARANCE:");
        }
    }
}
