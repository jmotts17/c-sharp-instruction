using System;

namespace cc01_MakeChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Make Chocolate!");

            String response;

            do
            {
                Console.Write("\nPlease enter the number of small bars: ");
                int smallBars = int.Parse(Console.ReadLine());
                Console.Write("Please enter the number of big bars: ");
                int bigBars = int.Parse(Console.ReadLine());
                Console.Write("Please enter the goal: ");
                int goal = int.Parse(Console.ReadLine());

                int result = makeChocolate(smallBars, bigBars, goal);

                if(result == -1)
                {
                    Console.WriteLine($"Result: {result} | Not possible.");
                } else
                {
                    Console.WriteLine($"Result: {result} small bars used.");
                }

                Console.Write("\nContinue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y"));

            Console.WriteLine("\nBye");
        }

        public static int makeChocolate(int small, int big, int goal)
        {
            int remainder = goal % 5;
            big *= 5;

            if(small + big < goal)
            {
                return -1;
            } else if (small + big == goal)
            {
                return small;
            } else
            {
                return remainder;
            }
        }
    }
}
