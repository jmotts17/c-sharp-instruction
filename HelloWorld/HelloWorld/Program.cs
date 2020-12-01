using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is a single line comment

            /*
             * This is a block comment 
            */

            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your first name: ");
            String firstName = Console.ReadLine();
            Console.Write("Hello,");
            Console.WriteLine(" " + firstName + "!");
        }
    }
}
