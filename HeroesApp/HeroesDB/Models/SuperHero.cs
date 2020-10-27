using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesDB.Models
{
    /// <summary>
    /// Hero class
    /// </summary>
    public class SuperHero : SuperPerson
    {
        public List<SuperVillain> Nemesis { get; set; }
    }
}
