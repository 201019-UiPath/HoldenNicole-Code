using HeroesLib;
using HeroesDB;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HeroesBL
{
    public class HeroBL
    {
        IRepository repo = new FileRepo();
        public void AddHero(Hero newHero){
            //add business logic
            //check if name is unique
            //throw an exception or 2
            repo.AddHeroAsync(newHero);
        }
        public List<Hero> GetAllHeroes(){
            Task<List<Hero>> getHeroes = repo.GetAllHeroesAsync();
            return getHeroes.Result;
        }
    }
}