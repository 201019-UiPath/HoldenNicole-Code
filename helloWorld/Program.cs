//1.0 predefined namespace
using System;

//1.1 custom defined namespace
namespace helloWorld
{
    class Program
    {
        //execution starts here
            //comandline arguments
        static void Main(string[] args)
        {
            string firstname, lastname;
            Console.WriteLine("Hello, please enter your firstname");
            firstname=Console.ReadLine();
            Console.WriteLine("Hello, please enter your lastname");
            lastname=Console.ReadLine();
            Console.WriteLine($"Welcome to Revature {firstname} {lastname}");
        }
    }
}
