using System;
using System.Collections.Generic;

namespace HeroesLib
{
    #region old way of creating class members
 /*   public class Hero//default modifier => internal
    {
        //default modifier of members of a class is private
        public string name;
        public int id; // value type => System.Int32
        public Hero(){
            name="Bob";
            id = 1;
        }
        public Hero(int id, string name){
            this.name = name;
            this.id = id;
        }
        public int Id{
            get{
                if(id>0){
                return id;
                }
                else{
                    return -1;
                }
            }
            set{
                id = value;
            }
        }
        public int Id{get; set;}//autonomous property
        string name;//reference type
        //default constructor
        public Hero(){
            id = 19;
            name = Bobasaurus;
        }
        //snippet ctor + double <tab> key?
        public Hero(int id, string name){
            this.id=id;
            Id=id;
            this.name=name;
        }
    } */
    #endregion
    #region Modern way to create class members
     public class Hero{
        public int Id {get; set;}
        public string Name {get; set;}
        //public string[] superPowers=new string[19]; //1-D array
        //jagged array
        //public int[][] ja = new int[3][];
        #region Arrays
        //public string[] superPowers=new string[10];//1-D
        //public int[][] ja=new int[3][];//jagged array
        #endregion
        //public static List<string> superPowers = new List<string>();
        public static Stack<string> superPowers = new Stack<string>(); //LIFO
        public static Dictionary<string, string> hideOuts = new Dictionary<string, string>();

        /*public Hero(){
            superPowers.Push("Strength");
            superPowers.Push("Flying");
            superPowers.Push("Invisibility");
            superPowers.Push("X-Ray vision");

            hideOuts.Add("Thor","Asgard");
            hideOuts.Add("Batman","Bat Cave");
            hideOuts.Add("Superman","Fortress of Solitude");
        } */
        public static IEnumerable<string> GetSuperPowers(){
            
            return superPowers;
        }
        public void RemoveSuperPower(){//string superPower
          //  if(superPowers.Contains(superPower)){
               // superPowers.Remove(superPower);
          //  }
          superPowers.Pop();
        }
        public void AddSuperPower(string superPower){
            if(superPower != null && superPower != ""){
                superPowers.Push(superPower);
            }
        }

    }
    #endregion
}
