using System;
using HeroesLib;
using HeroesUI.Menus;

namespace HeroesUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero obj = new Hero();
            
            #region default constructor
            /*Hero obj1=new Hero();
            Console.WriteLine($"{obj1.id} {obj1.name}");*/
            #endregion

            #region Parameterized constructor
            /*Hero obj2 = new Hero(2,"Bobasauras");
            Console.WriteLine($"{obj2.id} {obj2.name}"); //can only access variables if public*/
            #endregion

            #region Access via Properties
            /*Console.WriteLine(obj1.Id);//read property value
            obj1.Id=3;
            Console.WriteLine($"New Id = {obj1.Id}");*/
            #endregion

            #region Accessing Arrays
            /*Console.Write("Please enter your Superhero name: ");
            obj.Id=Int32.Parse(Console.ReadLine());
            Console.Write("Please enter your Superhero name: ");
            obj.Name=Console.ReadLine();
            Console.Write("Enter the first Power your hero has: ")
            obj.superPowers[0];
            Console.ReadLine();
            Console.Write($"{obj.Id} {obj.Name} {obj.superPowers[0]});
            //Jagged Arrays rows and initializations
            obj.ja[0]=new int[2];//first column
            obj.ja[1]=new int[3];//second column
            obj.ja[2]=new int[1];//third column
            obj.ja[0][0] = 19;
            obj.ja[1][2] = 15;
            int[,,] td=new int[2,4,3];//3-D arrays
            Console.WriteLine($"Dimension of the Array - {td.Rank}");
            Console.WriteLine($"Number of elements in the Array - {td.Length}");
            Console.WriteLine(obj.ja.Rank);//rank is dimension of array
            Console.WriteLine(obj.ja.Length);//elements of the arrays
            //loop through jagged array 
            foreach (var rows in obj.ja){//looping through all rows
                //looping through all columns of every row
                for(int i=0; i<rows.Length; i++){
                    Console.Write($"{rows[i]}");
                }
                Console.WriteLine();
            }*/
            #endregion

            #region List<T>,Stack<T>
            /*Console.Write("Please enter the super power to be removed: ");
            string sp=Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Your superhero still has these super powers: ");
            Hero.superPowers.Pop(sp);
            
            foreach(var superPowers in Hero.GetSuperPowers()){
                Console.WriteLine(superPowers);
            }*/
            #endregion

            #region Dictionary<key, value>
              /*  Console.WriteLine("Super Hero   Hide out");
                foreach(var superhero in Hero.hideOuts){
                    Console.WriteLine($"{superhero.Key}     {Hero.hideOuts[superhero.Key]}");
                }*/
            #endregion

            #region Calling hero menu
            //IMenu startMenu = new MainMenu();
            //startMenu.Start();
            #endregion

            #region Delegates, Anonymous methods, Lambda
            HeroTasks heroTasks = new HeroTasks();
            
            //HeroDel del = new HeroDel(heroTasks.GetSuperPowers);
            Action del = new Action(heroTasks.GetSuperPowers);

            del += heroTasks.DoWork;
            del();
            del += heroTasks.ManageLife;
            del();
            #endregion

            //Anonymous methods
            Action<string> am = delegate(string name){
                System.Console.WriteLine("Howdy, anonymous");
            };
            am("Bob");
            
            //lambda expression - shorthand notations to anonymous methods
            Action result = () => System.Console.WriteLine("Howdy Lambda");
            result();
        }
    }
}