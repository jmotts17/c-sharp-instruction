using System;

namespace ch11_ArraysDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do some arrays!!");

            String[] names = { "Chris", "Josh", "Derek", "Monroe" };
            Console.WriteLine("\nElement at position 1: " + names[1]);

            Console.WriteLine("\nIndexed For Loop");

            // indexed for loop
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Element at position " + i + ": " + names[i]);
            }

            Console.WriteLine("\nFor Each Loop");

            // for each loop
            foreach (String name in names)
            {
                Console.WriteLine("Name: " + name);
            }

            Console.WriteLine("\nBye");
        }
    }
}
