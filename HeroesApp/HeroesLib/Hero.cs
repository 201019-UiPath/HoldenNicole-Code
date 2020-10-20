using System;

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
        public string[] superPowers=new string[19]; //1-D array
        //jagged array
        public int[][] ja = new int[3][];
    }
    #endregion
}
