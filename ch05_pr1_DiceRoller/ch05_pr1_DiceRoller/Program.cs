using System;

namespace ch05_pr1_DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Dice Roller");

            // Prompt user to roll the dice
            String response = GetString("\nRoll the dice? (y/n): ");       

            while (response.Equals("y") || response.Equals("Y"))
            {
                // Roll 2 dice
                int die1 = RollDie();
                int die2 = RollDie();

                // Output results
                Console.WriteLine("Die 1: " + die1);
                Console.WriteLine("Die 2: " + die2);
                Console.WriteLine("Total: " + (die1 + die2));

                // Output special message
                if(die1 == 1 && die2 == 1)
                {
                    Console.WriteLine("Snake Eyes!");
                } else if (die1 == 6 && die2 == 6)
                {
                    Console.WriteLine("Boxcars!");
                }

                // Prompt user to continue
                response = GetString("\nRoll again? (y/n): ");
            }

            
        }

        public static string GetString(String prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int RollDie() {
            Random rand = new Random();
            return rand.Next(6) + 1;
        }
    }
}
