using System;

namespace ch02_pr3_RectangleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            String response;

            do
            {
                Console.Write("\nEnter length: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Area: " + (width * length));
                Console.WriteLine("Perimeter: " + ((2 * width) + (2 * length)));

                Console.Write("\nContinue (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y") || response.Equals("Y"));
        }
    }
}
