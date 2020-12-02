using System;

namespace ch03_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loops");
            // index for loop that will print "hello" n times
            // n is an int entered by the user

            Console.Write("Enter a whole number: ");
            int n = Int32.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Hello " + i);
            }
        }
    }
}
