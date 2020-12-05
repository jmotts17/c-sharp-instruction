using System;

namespace ch12_pr3_MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Movie List Application");

            String response;

            do
            {
                CategoryMenu();
                int selection = int.Parse(Console.ReadLine());

                Console.Write("Continue? (y/n): ");
                response = Console.ReadLine();
            } while (response.Equals("y"));

        }

        public static void CategoryMenu()
        {
            Console.WriteLine("\nMovie Categories");
            Console.WriteLine("1. Animated");
            Console.WriteLine("2. Drama");
            Console.WriteLine("3. Horror");
            Console.WriteLine("4. Scifi");
            Console.Write("\nEnter a category number: ");
        }
    }
}
