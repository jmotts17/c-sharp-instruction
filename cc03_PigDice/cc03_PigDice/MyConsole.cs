using System;
using System.Collections.Generic;
using System.Text;

namespace cc03_PigDice
{
    class MyConsole
    {
        public static String GetString(String prompt)
        {
            Console.Write(prompt);
            String s = Console.ReadLine();
            return s;
        }

        public static int GetInt(String prompt)
        {
            int n = 0;
            Boolean success = false;
            while (!success)
            {
                try
                {
                    Console.Write(prompt);
                    n = Int32.Parse(Console.ReadLine());
                    success = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Try again.");
                }
            }
            return n;
        }

        public static int GetInt(String prompt, int min, int max)
        {
            int num = 0;
            Boolean success = false;
            while (!success)
            {
                try
                {
                    Console.Write(prompt);
                    num = int.Parse(Console.ReadLine());
                    if (num >= min && num <= max)
                    {
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry. Enter a number between {min} and {max}.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Try again.");
                }
            }
            return num;
        }

        public static Double GetDouble(String prompt)
        {
            double n = 0;
            Boolean success = false;
            while (!success)
            {
                try
                {
                    Console.Write(prompt);
                    n = Convert.ToDouble(Console.ReadLine());
                    success = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Not a number. Try again.");
                }
            }
            return n;
        }

        public static Double GetDouble(String prompt, double min, double max)
        {
            double num = 0;
            Boolean success = false;
            while (!success)
            {
                try
                {
                    Console.Write(prompt);
                    num = Convert.ToDouble(Console.ReadLine());
                    if (num >= min && num <= max)
                    {
                        success = true;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry. Enter a number between {min} and {max}.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry. Not a number. Try again.");
                }
            }
            return num;
        }
    }
}
