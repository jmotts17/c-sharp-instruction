using System;

namespace ch02_control_structures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the control structure app");

            // while loop - 'continue' loop, similar to Java projects
            String choice = "y";
            while(choice.Equals("Y") || choice.Equals("y")) {
                Console.Write("Enter color letter (r,g,b,p): ");
                String c = Console.ReadLine();

                if (c.Equals("r")) {
                    Console.WriteLine("You picked red!");
                } else if (c.Equals("g")) {
                    Console.WriteLine("You picked green!");
                } else if (c.Equals("b")) {
                    Console.WriteLine("You picked blue!");
                } else if (c.Equals("p")) {
                    Console.WriteLine("You picked purple!");
                } else {
                    Console.WriteLine("Incorrect color letter.");
                }

                // accept a numeric value
                Console.Write("Enter a whole number: ");
                int nbr = Int32.Parse(Console.ReadLine());
                Console.WriteLine("You entered #: " + nbr);

                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
           
            Console.WriteLine("Bye!");
        }
    }
}
