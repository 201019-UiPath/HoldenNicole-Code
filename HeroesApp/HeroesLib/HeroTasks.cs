using System;
namespace HeroesLib
{
    public delegate void HeroDel();
    public class HeroTasks : IHeroOperations, IHeroSuperPowers{
        string path="../SuperPowers.txt";
        public void DoWork(){
            Console.WriteLine("Saving humanity is my work");
        }
        public void ManageLife(){
            Console.WriteLine("I have a cranky aunt to manage");
        }
        public void GetSuperPowers(){
            string superPower = System.IO.File.ReadAllText(path);
            System.Console.WriteLine(superPower);
        }
    }
}