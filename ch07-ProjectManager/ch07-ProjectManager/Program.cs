using ch07_ProjectManager.business;
using ch07_ProjectManager.ui;
using System;

namespace ch07_ProjectManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager!");

            Product p1 = new Product();
            p1.code = ".net";
            p1.description = "Murach's C# and .Net";
            p1.price = 58.99;

            Product p2 = new Product("java", "Murach's Java Programming", 59.50);

            Console.WriteLine("p1 = " + p1);
            Console.WriteLine($"p2 = {p2}");

            String code = MyConsole.GetString("\nEnter product code: ");
            String desc = MyConsole.GetString("Enter product description: ");
            double price = MyConsole.GetDouble("Enter product price: ");

            Product p3 = new Product(code, desc, price);

            Console.WriteLine("\np3 = " + p3);

            LineItem l1 = new LineItem();
            l1.product = p1;
            l1.quantity = 1;
            l1.total = p1.price;

            Console.WriteLine("\nl1 = " + l1);

            Console.WriteLine("\nBye");
        }
    }
}

/*
String response;

do
{
    int test1 = MyConsole.GetInt("Please enter an integer: ");
    int test2 = MyConsole.GetInt("Please enter an integer between 1 and 100: ", 0, 100);
    double test3 = MyConsole.GetDouble("Please enter a double: ");
    double test4 = MyConsole.GetDouble("Please enter an double between 1 and 100: ", 0, 100);

    Console.WriteLine($"test1 = {test1}, test2 = {test2}, test3 = {test3}, test4 = {test4}");

    Console.Write("Continue? (y/n): ");
    response = Console.ReadLine();
} while (response.Equals("y"));
*/