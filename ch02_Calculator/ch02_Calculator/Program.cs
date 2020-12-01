using System;

namespace ch02_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the beginners calculator!");

            String response;
            double result = 0;

            do
            {
                Boolean flag = true;
                Console.Write("\nFirst Number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Second Number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter operation (+, -, *, /): ");
                String operation = Console.ReadLine();

                if(operation.Equals("+")) {
                    result = num1 + num2;
                } else if (operation.Equals("-")) {
                    result = num1 - num2;
                } else if (operation.Equals("*")) {
                    result = num1 * num2;
                } else if (operation.Equals("/")) {
                    result = num1 / num2;
                } else
                {
                    Console.WriteLine("Invalid operation");
                    flag = false;
                }

                if(flag) {
                    Console.WriteLine("\n" + num1 + " " + operation + " " + num2 + " = " + result);
                }

                Console.Write("\nContinue (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y") || response.Equals("Y"));

        }
    }
}
