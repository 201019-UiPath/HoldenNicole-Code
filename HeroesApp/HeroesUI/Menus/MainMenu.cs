using HeroesLib;
namespace HeroesUI.Menus
{
    /// <summary>
    /// welcome menu for people to see data
    /// </summary>
    public class MainMenu:IMenu
    {
        public void Start(){
            do{
                System.Console.WriteLine("Howdy! What would you like to do today?");
                //options
                System.Console.WriteLine("[0] Create a hero");
            } while(!System.Console.ReadLine().Equals("0"));
            Hero newHero = GetHeroDetails();   
            System.Console.WriteLine($"Hero {newHero.Name} was created with a super power of {Hero.superPowers.Pop()}");
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