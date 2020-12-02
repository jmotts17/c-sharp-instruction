using System;

namespace ch03_pr1_TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output welcome message
            Console.WriteLine("Welcome to the Temperature Converter");

            // Variable Declaration
            String response;

            do
            {
                // Prompt user for input
                Console.Write("\nEnter degrees in Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());

                // Calculate & Output Results
                double celsius = (fahrenheit - 32) * 5 / 9;
                Console.WriteLine("Degrees in Celsius: " + Math.Round(celsius, 2));

                // Prompt user to continue
                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y") || response.Equals("Y"));
        }
    }
}
