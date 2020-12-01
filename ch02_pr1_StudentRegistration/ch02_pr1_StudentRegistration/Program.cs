using System;

namespace ch02_pr1_StudentRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form\n");
            
            Console.Write("Enter first name: ");
            String firstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            String lastName = Console.ReadLine();
            Console.Write("Enter year of birth: ");
            String yearOfBirth = Console.ReadLine();

            Console.WriteLine("\nWelcome " + firstName + " " + lastName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + firstName + "*" + yearOfBirth);
        }
    }
}
