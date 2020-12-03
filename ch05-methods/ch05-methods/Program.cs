using System;

namespace ch05_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Call some methods");
            // Prompt user to enter a whole number
            // convert the input to a number
            // print the number

            int n = GetInt("Enter a whole number: ");
            Console.WriteLine("You entered the number: " + n);

            int age = GetInt("\nEnter actor age: ");
            Console.WriteLine("Actor's age is: " + age);

            Console.WriteLine("\nBye!");
        }

        private static int GetInt(String prompt)
        {
            Console.Write(prompt);
            int n = Int32.Parse(Console.ReadLine());
            return n;
        }
    }
}
