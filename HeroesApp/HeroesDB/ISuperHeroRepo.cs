using HeroesDB.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HeroesDB
{
    public interface ISuperHeroRepo
    {
        Task<List<SuperHero>> GetAllHeroesAsync();
        void AddHeroAsync(SuperHero hero);
        SuperHero GetHeroByName(string name);
    }
}
