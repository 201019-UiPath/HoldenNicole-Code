using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstname, lastname;
            Console.WriteLine("Howdy! Please enter your first name");
            firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name now");
            lastname = Console.ReadLine();
            Console.WriteLine($"Welcome to Revature {firstname} {lastname}");

        }
    }
}
