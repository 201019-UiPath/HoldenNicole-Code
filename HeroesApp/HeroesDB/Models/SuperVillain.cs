using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesDB.Models
{
    public class SuperVillain : SuperPerson
    {
        public List<SuperHero> Nemesis { get; set; }
    }
}
