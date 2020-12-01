using System;

namespace ch03_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generate random #s!");

            // Random r = new Random();
            // using 'var' type, but not necessary, but this is a demo
            var r = new Random();
            // generate random # between 0 and 9.999
            int n1 = r.Next(10);
            Console.WriteLine(n1);
            // die roll... random # between 1 and 6
            int n2 = r.Next(6) + 1;
            Console.WriteLine(n2);

            // die roll 2... another way
            int n3 = r.Next(1, 7);
            Console.WriteLine(n3);
        }
    }
}
