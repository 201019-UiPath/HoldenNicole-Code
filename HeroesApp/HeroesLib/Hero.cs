using System;

namespace HeroesLib
{
    public class Hero
    {
        public string name;
        public int id;
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
                return id;
            }
            set{
                id = value;
            }
        }
    }
}
