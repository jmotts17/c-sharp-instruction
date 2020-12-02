using System;

namespace ch04_pr1_TableOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Welcome to the Squares and Cubes table");

            // Variable declaration
            String response;

            do
            {
                // Prompt user for input
                Console.Write("\nEnter an integer: ");
                int num = Int32.Parse(Console.ReadLine());

                // Output table header
                Console.WriteLine("\nNumber   Squared  Cubed");
                Console.WriteLine("======   =======  =====");

                // Calculate and output results
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(i + "\t " + (i * i) + "\t  " + (i * i * i));
                }

                // Prompt user to continue
                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("Y") || response.Equals("y"));
        }
    }
}
