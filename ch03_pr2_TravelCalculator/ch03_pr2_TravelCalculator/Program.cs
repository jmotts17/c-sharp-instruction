using System;

namespace ch03_pr2_TravelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Welcome to the Travel Time Calculator");

            // Variable declaration
            String response;
            double miles, mph;
            int hours, minutes;

            do
            {
                // Prompt for user input
                Console.Write("\nEnter miles:          ");
                miles = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter miles per hour: ");
                mph = Convert.ToDouble(Console.ReadLine());

                // Calculate hours and minutes
                hours = (int) Math.Floor(miles / mph);
                minutes = (int)(((miles / mph) * 60) % 60);

                // Output results
                Console.WriteLine("\nEstimated travel time");
                Console.WriteLine("---------------------");
                Console.WriteLine("Hours:   " + hours);
                Console.WriteLine("Minutes: " + minutes);

                // Prompt user to continue
                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("Y") || response.Equals("y"));
        }
    }
}
