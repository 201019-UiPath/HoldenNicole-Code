using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesDB.Models
{
    public class SuperPerson
    {
        public int ID { get; set; }
        public string RealName { get; set; }
        public string Alias { get; set; }
        public string HideOut { get; set; }
        public List<SuperPower> SuperPowers { get; set; }
    }
}
