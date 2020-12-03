using System;

namespace ch05_optional_arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Optional args!\n");
            int nb1 = 22;
            int nb2 = 44;
            int nb3 = 11;

            Console.WriteLine("Sum is "+ Sum(nb1, nb2));
            Console.WriteLine("Sum is " + Sum(nb1, nb2, nb3));

            Console.WriteLine("\nBye!");
        }

        static int Sum(int n1, int n2, int n3 = 0)
        {
            return n1 + n2 + n3;
        }
    }
}
