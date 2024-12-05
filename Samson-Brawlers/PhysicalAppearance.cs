using System;


namespace Samson_Brawlers
{
    public class PhysicalAppearance : InputHandler, IGetInput
    {
        private string gender;
        private string bodyType;
        private string height;
        private string skinColor;
        private string hairStyle;
        private string hairColor;
        private string headShape;
        private string eyeShape;
        private string eyeColor;
        private string facialHairStyle;
        private bool isSkinWrinkles;
        private bool isScar;
        
        public string Gender { get { return gender; } set { gender = value; } }
        public string BodyType { get { return bodyType; } set { bodyType = value; } }
        public string Height { get { return height; } set { height = value; } }
        public string SkinColor { get { return skinColor; } set { skinColor = value; } }
        public string HairStyle { get { return hairStyle; } set { hairStyle = value; } }
        public string HairColor { get {return hairColor; } set {hairColor = value; } }
        public string HeadShape { get { return headShape; } set { headShape = value; } }
        public string EyeShape { get { return eyeShape; } set { eyeShape = value; } }   
        public string EyeColor { get { return eyeColor; } set {eyeColor = value; } }
        public string FacialHairStyle { get { return facialHairStyle; } set { facialHairStyle = value; } }
        public bool IsSkinWrinkles { get { return isSkinWrinkles; } set {isSkinWrinkles = value; } }
        public bool IsScar {  get { return isScar; } set { isScar = value; } }

        public void GetInput()
        {


            gender = MultipleChoiceInput("CHOOSE A GENDER:", ["MALE", "FEMALE"]);

            bodyType = MultipleChoiceInput("CHOOSE A BODY TYPE:", 
                    [ 
                        "STANDARD",
                        "HEAVYWEIGHT",
                        "AGILE",
                        "GRAPPLER",
                        "GIANT" 
                    ]);
            height = MultipleChoiceInput("CHOOSE THE CHARACTERS HEIGHT:",
                    [
                        "SMALL (3'0 - 5'0)",
                        "AVERAGE (5'5 - 6'0)",
                        "TALL (6'5 - 7'5)"
                    ]);

            skinColor = MultipleChoiceInput("CHOOSE A SKIN TONE/COLOR:",
                    [
                        "FAIR",
                        "LIGHT TAN",
                        "MEDIUM",
                        "DARK BROWN",
                        "BLACK"
                    ]);

            hairStyle = MultipleChoiceInput("CHOOSE A HAIR STYLE:",
                    [
                        "UNDERCUT",
                        "SLICKED BACK",
                        "BRAIDED HAIR",
                        "MAN BUN",
                        "BUZZ CUT",
                        "HIGH PONYTAIL",
                        "PIXIE CUT",
                        "LOOSE CURLS",
                        "BOB CUT",
                        "DREADLOCKS"
                    ]);

            hairColor = MultipleChoiceInput("CHOOSE A HAIR COLOR:",
                    [
                        "CHARCOAL BLACK",
                        "DARK BROWN",
                        "YELLOWSTONE",
                        "FIERY RED",
                        "SMOKEY WHITE",
                        "SKY BLUE",
                        "REBECCA PURPLE",
                        "UNICORN PINK"
                    ]);

            headShape = MultipleChoiceInput("CHOOSE A HEAD SHAPE:",
                    [
                        "SQUARE",
                        "OVAL",
                        "ROUND",
                        "TRIANGULAR",
                        "DIAMOND"
                    ]);

            eyeShape = MultipleChoiceInput("CHOOSE AN EYE SHAPE:",
                    [
                        "ALMOND",
                        "ROUND",
                        "HOODED",
                        "UPTURNED",
                        "NARROW/SLITTED"
                    ]);

            eyeColor = MultipleChoiceInput("CHOOSE A EYE COLOR:",
                    [
                        "CHARCOAL BLACK",
                        "DARK BROWN",
                        "YELLOWSTONE",
                        "FIERY RED",
                        "SMOKEY WHITE",
                        "SKY BLUE",
                        "REBECCA PURPLE",
                        "UNICORN PINK"
                    ]);

            FacialHairStyle = MultipleChoiceInput("CHOOSE A FACIAL HAIR STYLE:",
                    [
                        "FULL BEARD",
                        "GOATEE",
                        "MUSTACHE",
                        "STUBBLE",
                        "SIDEBURNS",
                        "NONE"
                    ]);

            isSkinWrinkles = MultipleChoiceInput("ADD SKIN WRINKLES:");

            isScar = MultipleChoiceInput("ENABLE SCAR APPEARANCE:");
        }
    }
}
