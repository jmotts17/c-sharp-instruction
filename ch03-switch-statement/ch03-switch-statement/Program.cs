using System;

namespace ch03_switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Switch Statement Demo");
            // prompt user for a # between 1 and 7
            // convert that # to a day of week (Mon - Sun)

            Console.Write("Enter a number between 1 and 7: ");
            int n = Int32.Parse(Console.ReadLine());
            String dow = "";

            switch (n)
            {
                case 1:
                    dow = "Monday";
                    break;
                case 2:
                    dow = "Tuesday";
                    break;
                case 3:
                    dow = "Wednesday";
                    break;
                case 4:
                    dow = "Thursday";
                    break;
                case 5:
                    dow = "Friday";
                    break;
                case 6:
                    dow = "Saturday";
                    break;
                case 7:
                    dow = "Sunday";
                    break;
                default:
                    dow = "Invalid dow";
                    break;
            }

            Console.WriteLine("Day of week is '" + dow + "'.");

            Console.WriteLine("Bye!");
        }
    }
}
