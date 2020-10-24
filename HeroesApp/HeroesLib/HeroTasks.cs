using System;
using System.Threading.Tasks;
namespace HeroesLib
{
    public delegate void HeroDel();
    public class HeroTasks : IHeroOperations, IHeroSuperPowers{
        string path="../SuperPowers.txt";
        public event HeroDel workDone;
        public async void DoWork(){
            System.Console.WriteLine("Work started");
            await Task.Run(new Action(GetSuperPowers));
            Console.WriteLine("Saving humanity is my work");
            System.Console.WriteLine("work finished");

        }
        public void OnWorkDone(){//raising event
            //workDone?.Invoke(); should give same result
            if (workDone != null){
                workDone();
            }
        }

        public void ManageLife(){
            Console.WriteLine("I have a cranky aunt to manage");
        }
        public void GetSuperPowers(){
            System.Console.WriteLine("Getting Super Powers");
            System.Threading.Thread.Sleep(2000);
            string superPower = System.IO.File.ReadAllText(path);
            System.Console.WriteLine(superPower);
        }
    }
}