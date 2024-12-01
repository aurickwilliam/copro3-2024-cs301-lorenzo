using System;

namespace Samson_Brawlers
{
    public class Character
    {
        private string name, title, gender, bodyType, height, skinColor, hairStyle, hairColor,
            headShape, eyeShape, eyeColor, facialHairStyle, outfitSet, topClothing, bottomClothing,
            footWear, accessories, meleeWeapon, fightingStyle, stance;
        private bool isSkinWrinkles, isTattoo, isScar, isAura;
        private int attackPower = 0, defense = 0, speed = 0, stamina = 0, health = 0, specialMeterGain = 0;


        public Character(string name, string title, string gender, string bodyType, string height, 
            string skinColor, string hairStyle, string hairColor, string headShape, string eyeShape,
            string eyeColor, string facialHairStyle, string outfitSet, string topClothing, 
            string bottomClothing, string footWear, string accessories, string meleeWeapon, string fightingStyle, 
            string stance, bool isSkinWrinkles, bool isTattoo, bool isScar, bool isAura, int attackPower,
            int defense, int speed, int stamina, int health, int specialMeterGain) 
        { 
            this.name = name;
            this.title = title;
            this.gender = gender;
            this.bodyType = bodyType;
            this.height = height;
            this.skinColor = skinColor;
            this.hairStyle = hairStyle;
            this.hairColor = hairColor;
            this.headShape = headShape;
            this.eyeShape = eyeShape;
            this.eyeColor = eyeColor;
            this.facialHairStyle = facialHairStyle;
            this.outfitSet = outfitSet;
            this.topClothing = topClothing;
            this.bottomClothing = bottomClothing;
            this.footWear = footWear;
            this.accessories = accessories;
            this.meleeWeapon = meleeWeapon;
            this.fightingStyle = fightingStyle;
            this.stance= stance;
            this.isSkinWrinkles = isSkinWrinkles;
            this.isTattoo = isTattoo;
            this.isScar = isScar;
            this.isAura = isAura;
            this.attackPower = attackPower;
            this.defense = defense;
            this.speed = speed;
            this.stamina = stamina;
            this.health = health;
            this.specialMeterGain = specialMeterGain;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public string BodyType {  get { return bodyType; } set { bodyType = value; } }
        public string Height { get { return height; } set { height = value; } }
        public string SkinColor { get { return skinColor; } set { skinColor = value; } }
        public string HairStyle { get { return hairStyle; } set { hairStyle = value; } }
        public string HairColor { get {return hairColor; } set { hairColor = value; } }
        public string HeadShape {  get { return headShape; } set { headShape = value; } }
        public string EyeShape {  get { return eyeShape; } set { eyeShape = value; } }
        public string EyeColor { get { return eyeColor; } set {eyeColor = value; } }
        public string FacialHairStyle { get {return facialHairStyle; } set { facialHairStyle = value; }}
        public string OutfitSet { get { return outfitSet; } set { outfitSet = value; } }
        public string TopClothing {  get { return topClothing; } set { topClothing = value; } }
        public string BottomClothing { get {return bottomClothing; } set { bottomClothing = value; } }
        public string FootWear { get { return footWear; } set { footWear = value; } }
        public string Accessories {  get { return accessories; } set { accessories = value; } }
        public string MeleeWeapon { get { return meleeWeapon; } set { meleeWeapon = value; } }
        public string FightingStyle { get { return fightingStyle; } set { fightingStyle = value; } }
        public string Stance {  get { return stance; } set { stance = value; } }
        public bool SkinWrinkles { get { return isSkinWrinkles; } set { isSkinWrinkles = value; } }
        public bool Tattoo { get { return isTattoo; } set { isTattoo = value; } }
        public bool Scar {  get { return isScar; } set { isScar = value; } }
        public bool Aura { get { return isAura; } set { isAura = value; } }
        public int AttackPower { get { return attackPower; } set { attackPower = value; } }
        public int Defense { get { return defense; } set { defense = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Stamina {  get { return stamina; } set { stamina = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int SpecialMeterGain {  get { return specialMeterGain; } set { specialMeterGain = value; } }
    }
}
