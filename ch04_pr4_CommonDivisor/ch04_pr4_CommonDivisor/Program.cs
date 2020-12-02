using System;

namespace ch04_pr4_CommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Greatest Common Divisor Finder");

            // Variable declaration
            String response = "";

            do
            {
                Console.Write("\nEnter first number: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Int32.Parse(Console.ReadLine());

                // Calculate GCD
                while (num1 != num2)
                {
                    if (num1 > num2)
                    {
                        num1 = num1 - num2;
                    }
                    else
                    {
                        num2 = num2 - num1;
                    }
                }

                // Output results
                Console.WriteLine("Greatest Common Divisor: " + num2);

                // Prompt user to continue
                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y") || response.Equals("Y"));

        }
    }
}
