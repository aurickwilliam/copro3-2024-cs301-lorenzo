using System;

namespace Samson_Brawlers
{
    public struct Statistics : IGetInput
    {
        private int attackPower;
        private int defense;
        private int speed;
        private int stamina;
        private int health;
        private int specialMeterGain;
        public int availablePts;

        public InputHandler input;

        public Statistics(int attack, int defense, int speed, int stamina, int health, int specialMeterGain)
        {
            this.attackPower = attack;
            this.defense = defense;
            this.speed = speed;
            this.stamina = stamina;
            this.health = health;
            this.specialMeterGain = specialMeterGain;
        }

        public void GetInput()
        {
            List<int> stats = new List<int>() { 0, 0, 0, 0, 0, 0 };

            availablePts = 20;


            DisplayStats(stats);
            do
            {
                try
                {
                    Console.Write("\t\t\t  -> ");
                    string input = Console.ReadLine();

                    if (input == "")
                    {
                        throw new InvalidInputException("\n\t\t\t PLEASE ENTER A VALUE!\n");
                    }


                    if (input == "R" || input == "r")
                    {
                        for (int i = 0; i < stats.Count; i++)
                        {
                            stats[i] = 0;
                        }
                        availablePts = 20;
                        Console.Clear();
                        DisplayStats(stats);
                        continue;
                    }


                    if (!(input.Length == 3 || input.Length == 4))
                    {
                        throw new InvalidInputException();
                    }

                    int statIndex = Convert.ToInt32(input.Substring(0, 1)) - 1;
                    char operation = input.ToCharArray()[1];
                    int value = Convert.ToInt32(input.Substring(2));

                    //Console.WriteLine(statIndex);
                    //Console.WriteLine(operation);
                    //Console.WriteLine(value);

                    if (operation == '+')
                    {
                        if (stats[statIndex] + value <= 10)
                        { 
                            stats[statIndex] += value;
                            availablePts -= value;
                            Console.WriteLine("\n\t\t\t STAT INCREASED!\n");
                        }
                        else
                        {
                            throw new InvalidStatPointException();
                        }
                    }
                    else if (operation == '-')
                    {
                        if (stats[statIndex] - value >= 0)
                        {
                            stats[statIndex] -= value;
                            availablePts += value;
                            Console.WriteLine("\n\t\t\t STAT DECREASED!\n");
                        }
                        else
                        {
                            throw new InvalidStatPointException("\n\t\t\t INVALID VALUE, STAT WILL BE NEGATIVE!\n");
                        }
                    }
                    else
                    {
                        throw new InvalidInputException();
                    }

                    Thread.Sleep(1000);

                    Console.Clear();
                    DisplayStats(stats);

                    InputHandler inputHandler = new InputHandler();
                    if (availablePts == 0)
                    {
                        if (!inputHandler.MultipleChoiceInput("SAVE YOUR STATS:"))
                        {
                            Console.Clear();
                            DisplayStats(stats);
                            continue;
                        }
                        
                        SetStatsValues(stats);
                        break;
                    }
                }
                catch (InvalidInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("\n\t\t\t INVALID INPUT, ENTER THE CORRECT VALUE!\n");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("\n\t\t\t INVALID INPUT, ENTER THE CORRECT VALUE!\n");
                }
                catch (InvalidStatPointException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("\n\t\t\t INVALID INPUT, PLEASE FOLLOW THE GUIDE!\n");
                }
            }
            while (true);
        }

        public void DisplayStats(List<int> stats)
        {
            Console.WriteLine("\t\t+-----------------------------------------------------------------------+");
            Console.WriteLine("\t\t|\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t|\t\t\t CHARACTER STATISTICS\t\t\t\t|");
            Console.WriteLine("\t\t|\t\t\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t+-----------------------------------------------------------------------+");
            Console.WriteLine($"\t\t| AVAILABLE POINTS: {availablePts}\t\t\t\t\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine("\t\t| STATS\t\t\t| CURRENT VALUE\t| DESCRIPTION\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 1 -> ATTACK POWER\t| {stats[0],-13} | Increases the damage dealt by\t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| attacks.\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 2 -> DEFENSE\t\t| {stats[1],-13} | Reduces damage taken.\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 3 -> SPEED\t\t| {stats[2],-13} | Affects movement and attack\t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| speed.\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 4 -> STAMINA\t\t| {stats[3],-13} | Determines endurance for \t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| special moves or blocking\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 5 -> HEALTH\t\t| {stats[4],-13} | Extends the character's\t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| overall hit points.\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+");
            Console.WriteLine($"\t\t| 6 -> Special Meter\t| {stats[5],-13} | Increases the rate at which\t|");
            Console.WriteLine("\t\t|      Gain\t\t|\t\t| special or ultimate meter \t|");
            Console.WriteLine("\t\t|\t\t\t|\t\t| charge.\t\t\t|");
            Console.WriteLine("\t\t+-----------------------+---------------+-------------------------------+\n");

            Console.WriteLine("\t\t \t Choose a Stat to modify and ");
            Console.WriteLine("\t\t \t Enter \"+\" add or \"-\" to minus");
            Console.WriteLine("\t\t \t Then enter the value of the points.");
            Console.WriteLine("\t\t \t (eg. 1+2, 3-1)\n");
            Console.WriteLine("\t\t\t Press \"R\" to Reset Values\n");
        }

        public void SetStatsValues(List<int> stats)
        {
            attackPower = stats[0];
            defense = stats[1];
            speed = stats[2];
            stamina = stats[3];
            health = stats[4];
            specialMeterGain = stats[5];
        }

        public List<int> GetStatsValue()
        {
            return new List<int> { attackPower, defense, speed, stamina, health, specialMeterGain };
        }
    }
}
