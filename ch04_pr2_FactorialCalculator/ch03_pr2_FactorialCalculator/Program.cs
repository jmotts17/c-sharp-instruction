using System;

namespace ch04_pr2_FactorialCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Welcome to the Factorial Calculator");

            // Variable declaration
            String response = "";

            do
            {
                // Prompt user for input
                Console.Write("\nEnter an integer that's greater than 0 and less than 10: ");
                int num = Int32.Parse(Console.ReadLine());

                // Declare factorial variable
                long factorial = 1;

                // Calculate factorial
                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }

                // Output results
                Console.WriteLine("The factorial of " + num + " is " + factorial + ".");

                // Prompt user to continue
                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y") || response.Equals("Y"));
        }
    }
}
