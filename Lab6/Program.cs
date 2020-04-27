using System;

namespace Lab6
{
    class Program
    {
        private static void Main(string[] args)
        {
            string userWantsToContinue;
            int diceSides;

            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n): ");
            string userWantsToStart = Console.ReadLine();
            if (userWantsToStart.ToUpper() == "Y")
            {

                do
                {
                    Console.Write("How many sides should each dice have? ");
                    diceSides = int.Parse(Console.ReadLine());

                    Console.WriteLine("You rolled:");

                    DiceRoll(diceSides);
                    DiceRoll(diceSides);

                    Console.Write("Roll again? (y/n): ");
                    userWantsToContinue = Console.ReadLine();
                } while (userWantsToContinue.ToUpper() == "Y");
            }
        }

        public static int DiceRoll(int diceSides)
        { 
            var roll = new Random();
            Console.WriteLine(roll.Next(1, (diceSides + 1)));
            return diceSides;
        }
    }
}
