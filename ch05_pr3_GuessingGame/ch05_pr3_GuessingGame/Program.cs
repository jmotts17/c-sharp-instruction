using System;

namespace ch05_pr3_GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            OutputWelcomeMessage();

            // Variable declaration
            String response = "";
            
            // Random number reference
            Random rand = new Random();

            do
            {
                // Generate a random number
                int randomNumber = rand.Next(100) + 1;
                // Variable Declaration
                int guess = 0;
                int count = 0;

                while (guess != randomNumber)
                {
                    // Prompt user for a guess
                    guess = GetIntWithinRange("\nEnter number: ", 0, 100);
                    // Increment user guess count
                    count++;
                    // Output user hints based on guess vs random number
                    if (guess - randomNumber > 10)
                    {
                        Console.WriteLine("Way too high!");
                    }
                    else if (guess - randomNumber > 0)
                    {
                        Console.WriteLine("Too High!");
                    }
                    else if (randomNumber - guess > 10)
                    {
                        Console.WriteLine("Way too low!");
                    } else if (randomNumber - guess > 0)
                    {
                        Console.WriteLine("Too low!");
                    } 
                }
                // Output results + special message
                Console.WriteLine("You got it in " + count + " tries.");
                OutputSpecialMessage(count);

                // Prompt user to continue
                response = GetStringWithinRange("\nContinue? (y/n): ", "y", "n");
            } while (response.Equals("Y") || response.Equals("y"));


        }

        public static void OutputWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guess the Number Game");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("I'm thinking of a number from 1 to 100");
            Console.WriteLine("Try to guess it.");
        }

        public static int GetIntWithinRange(String prompt, int min, int max)
        {
            int num = 0;
            Boolean success = false;
            while (!success)
            {
                try
                {
                    Console.Write(prompt);
                    num = int.Parse(Console.ReadLine());
                    if (num > min && num <= max)
                    {
                        success = true;
                    } else
                    {
                        Console.WriteLine("Invalid entry. Enter a number between 1 and 100.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Enter a number between 1 and 100.");
                }
            }
            return num;
        }

        public static string GetStringWithinRange(String prompt, String s1, String s2)
        {
            String response = "";
            Boolean success = false;
            while (!success)
            {
                Console.Write(prompt);
                response = Console.ReadLine();
                if (response.Equals(s1) || response.Equals(s2)) {
                    success = true;
                } else
                {
                    Console.WriteLine("Invalid entry. Please enter " + s1 + " or " + s2 + ".");
                }
            }

            return response;
        }

        public static void OutputSpecialMessage(int count)
        {
            if(count <= 3)
            {
                Console.WriteLine("Great work! You are a mathematical wizard.");
            } else if (count > 3 && count <=6)
            {
                Console.WriteLine("Not too bad! You've got some potential.");
            } else
            {
                Console.WriteLine("What took you so long? Maybe you should take some lessons.");
            }
        }
    }
}
