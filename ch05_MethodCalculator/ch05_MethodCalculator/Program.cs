using System;

namespace ch05_MethodCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Method Calculator");

            String response;
            double result = 0;
        }

        public static double Sum(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Difference(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Product(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Quotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
