using System;

namespace ch03_round_format
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rounding and formatting!");
            double d1 = 55.321678;
            double d2 = Math.Round(d1, 2);
            double d3 = Math.Round(d1, 4);
            Console.WriteLine(d2); // 55.32
            Console.WriteLine(d3); // 55.3217

            // format d1 as us currency
            Console.WriteLine(d1.ToString("C"));
        }
    }
}
