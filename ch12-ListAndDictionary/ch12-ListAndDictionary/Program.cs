using System;
using System.Collections.Generic;

namespace ch12_ListAndDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create some list and a dictionary");

            // a list
            List<double> prices = new List<double>();
            prices.Add(11.11);
            prices.Add(5.99);
            prices.Add(250.25);

            Console.WriteLine("\n" + prices[1]);

            Console.WriteLine("\nFor Loop");
            for(int i = 0; i < prices.Count; i++)
            {
                Console.WriteLine("Price " + i + ": " + prices[i]);
            }

            Console.WriteLine("\nFor Each Loop");
            foreach (double price in prices)
            {
                Console.WriteLine(price);
            }

            Console.WriteLine("\nBye");
        }
    }
}
