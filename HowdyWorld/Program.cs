using System;

namespace HowdyWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName;
            int year;
            Console.WriteLine("Howdy! Please enter your first name here: ");
            firstName = Console.ReadLine();
            Console.WriteLine($"Awesome {firstName}, now we need your last name: ");
            lastName=Console.ReadLine();
            Console.WriteLine($"Nice to meet you {firstName} {lastName} always good to meet another trainee!");
        }
    }
}
