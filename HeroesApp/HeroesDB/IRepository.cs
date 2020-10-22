using HeroesLib;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace HeroesDB
{
    public interface IRepository
    {
        /// <summary>
        /// adds hero to file
        /// </summary>
         void AddHeroAsync(Hero hero);
         Task<List<Hero>> GetAllHeroesAsync();
    }
}