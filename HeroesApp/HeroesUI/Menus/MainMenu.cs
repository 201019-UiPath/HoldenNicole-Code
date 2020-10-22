using HeroesLib;
using HeroesBL;
using System.Text.RegularExpressions;
using System.Collections.Generic;
namespace HeroesUI.Menus
{
    /// <summary>
    /// welcome menu for people to see data
    /// </summary>
    public class MainMenu:IMenu
    {
        HeroBL heroBL = new HeroBL();
        public void Start(){
            System.Console.WriteLine("Howdy! What would you like to do today?");
            //options
            System.Console.WriteLine("[0] Create a hero /n [1] Get all heroes /n [2] Exit");
            string userInput = System.Console.ReadLine();
            do{
            
                switch (userInput){
                    case "0":
                        Hero newHero = GetHeroDetails();
                        heroBL.AddHero(newHero);
                        System.Console.WriteLine($"Hero {newHero.Name} was created with a super power of {Hero.superPowers.Pop()}");
                        break;
                    case "1":
                        List<Hero> allHeroes = heroBL.GetAllHeroes();
                        foreach(var hero in allHeroes){
                            System.Console.WriteLine($"Hero {hero.Name}");
                        }
                        break;
                    case "2":
                        System.Console.WriteLine("Goodbye friend");
                        break;
                    default:
                        System.Console.WriteLine("Invalid input! Please select a valid option!");
                        break;
                }
            } while(!userInput.Equals("2"));
        }
        public Hero GetHeroDetails(){
            Hero hero = new Hero();
            System.Console.Write("Enter Hero Name: ");
            hero.Name=System.Console.ReadLine();
            System.Console.WriteLine("Enter to add super power to your hero: ");
            hero.AddSuperPower(System.Console.ReadLine());
            System.Console.WriteLine("Hero Created successfully!"); //use logging software to log this
            //add step to push hero details to BL layer
            return hero;
        }
    }
}