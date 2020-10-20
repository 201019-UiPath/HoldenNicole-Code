using System;
using HeroesLib;

namespace HeroesUI
{
    #region old ways of creating objects
    class Program:Hero
    {
        static void Main(string[] args)
        {
            #region default constructor
            Program obj1=new Program();
            Console.WriteLine($"{obj1.id} {obj1.name}");
            #endregion

            #region Parameterized constructor
            Hero obj2 = new Hero(2,"Bobasauras");
            Console.WriteLine($"{obj2.id} {obj2.name}");
            #endregion

            #region Access via Properties
            Console.WriteLine(obj1.Id);
            obj1.Id=3;
            Console.WriteLine($"New Id = {obj1.Id}");
            #endregion
        }
    }
    #endregion
    #region new way
    class Program2{
        static void Main(string[] args){
            #region default constructor

            #endregion
            #region Parameterized constructor

            #endregion
            #region Access via Properties
            Hero obj = new Hero();
            Console.WriteLine("Please enter your hero id: ");
            obj.Id=Console.ReadLine();
            Console.WriteLine("Please enter your hero name: ");
            obj.Name=Console.ReadLine();
            Console.WriteLine("Enter the best power you have: ");
            obj.superPowers[0] = Console.ReadLine();
            Console.Write($"{obj.Id} {obj.name} {obj.superPowers[0]}");
            #endregion
        }
    }
    #endregion
}
