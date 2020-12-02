using System;

namespace ch03_pr3_InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Welcome to the Interest Calculator");

            // Variable declaration
            String response;

            do
            {
                // Prompt user for input
                Console.Write("\nEnter loan amount:   ");
                Double loanAmount = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter interest rate: ");
                Double interestRate = Convert.ToDouble(Console.ReadLine());

                // Calculate results
                Double interest = Math.Round(loanAmount * interestRate, 2, MidpointRounding.AwayFromZero);

                // Output results
                Console.WriteLine("\nLoan amount: \t" + loanAmount.ToString("C"));
                Console.WriteLine("Interest Rate: \t" + interestRate.ToString("P"));
                Console.WriteLine("Interest: \t" + interest.ToString("C"));

                // Prompt user to continue
                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("Y") || response.Equals("y"));


        }
    }
}
