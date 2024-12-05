using System;

namespace Samson_Brawlers
{
    public class WeaponsAttacks : InputHandler, IGetInput
    {
        private string meleeWeapon;
        private string fightingStyle;
        private string stance;

        public string MeleeWeapon {  get { return meleeWeapon; } set { meleeWeapon = value; } }
        public string FightingStyle { get { return fightingStyle; } set { fightingStyle = value; } }
        public string Stance { get { return stance; } set { stance = value; } }

        public void GetInput()
        {
            meleeWeapon = MultipleChoiceInput("SELECT A MELEE WEAPON:",
                    [
                        "BRASS KNUCKLE",
                        "NUN-CHUCKS",
                        "BASEBALL BAT",
                        "WOODEN STICK",
                        "FIST"
                    ]);

            string[] fightingStylePrompt =
                [
                    "\t\t+-----------------------------------------------------------------------+",
                    "\t\t|\t\t\t\t\t\t\t\t\t|",
                    "\t\t|\t\t\tCHOOSE A FIGHTING STYLE\t\t\t\t|",
                    "\t\t|\t\t\t\t\t\t\t\t\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 1 -> BOXING\t\t\t| Focuses on powerful punches, \t\t|",
                    "\t\t|\t\t\t\t| defensive head movement, and precise \t|",
                    "\t\t|\t\t\t\t| footwork, emphasizing endurance and \t|",
                    "\t\t|\t\t\t\t| timing.\t\t\t\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 2 -> MUAY THAI\t\t| A striking art that uses punches,\t| ",
                    "\t\t|\t\t\t\t| kicks, elbows, and knees, combined \t|",
                    "\t\t|\t\t\t\t| with clinching techniques for \t|",
                    "\t\t|\t\t\t\t| close-range combat.\t\t\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 3 -> KICKBOXING\t\t| Blends punching and kicking \t\t|",
                    "\t\t|\t\t\t\t| techniques, often with a focus on \t|",
                    "\t\t|\t\t\t\t| continuous striking and dynamic \t|",
                    "\t\t|\t\t\t\t| movement.\t\t\t\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 4 -> KARATE\t\t\t| A traditional martial art emphasizing\t|",
                    "\t\t|\t\t\t\t| sharp strikes, disciplined forms, and |",
                    "\t\t| \t\t\t\t| defensive blocking techniques.\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 5 -> JUJUTSU\t\t\t| A grappling art designed to \t\t|",
                    "\t\t|\t\t\t\t| neutralize opponents using joint \t|",
                    "\t\t| \t\t\t\t| locks, chokes, and throws, leveraging |",
                    "\t\t| \t\t\t\t| an opponent’s force.\t\t\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 6 -> TAEKWONDO\t\t| Known for its flashy, high kicks and \t|",
                    "\t\t|\t\t\t\t| fast-paced combinations, emphasizing \t|",
                    "\t\t| \t\t\t\t| precision and flexibility in attacks.\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 7 -> SUMO\t\t\t| A traditional Japanese grappling\t|",
                    "\t\t|\t\t\t\t| sport where two wrestlers aim to \t|",
                    "\t\t|\t\t\t\t| push or throw each other out.\t\t|",
                    "\t\t+-------------------------------+---------------------------------------+",
                    "\t\t| 8 -> JUDO\t\t\t| Combines throws, pins, and \t\t|",
                    "\t\t|\t\t\t\t| submissions, focusing on using \t|",
                    "\t\t|\t\t\t\t| balance and leverage to overpower \t|",
                    "\t\t|\t\t\t\t| opponents.\t\t\t\t|",
                    "\t\t+-------------------------------+---------------------------------------+\n"
                ];


            fightingStyle = MultipleChoiceInput(fightingStylePrompt, 
                    [
                        "BOXING",
                        "MUAY THAI",
                        "KICKBOXING",
                        "KARATE",
                        "JUJUTSU",
                        "TAEKWONDO",
                        "SUMO",
                        "JUDO"
                    ]);

            stance = MultipleChoiceInput("CHOOSE THE CHARACTERS STANCE:",
                    [
                        "KARATE FIGHTING STANCE",
                        "ORTHODOX BOXING STANCE",
                        "CROUCHING STANCE",
                        "SUMO STANCE",
                        "BOW STANCE",
                        "MONKEY STANCE"
                    ]);
        }

    }
}
