using System.Collections.Generic;
using HeroesLib;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
namespace HeroesDB
{
    /// <summary>
    /// repository using files
    /// </summary>
    public class FileRepo : IRepository
    {
        string filepath = "HeroesApp/HeroesDB/HeroDataLocation/Heroes.txt";
        /// <summary>
        /// Adds hero to file
        /// </summary>
        /// <param name="hero"></param>
        public async void AddHeroAsync(Hero hero){
            using(FileStream fs = File.Create(filepath)){
                await JsonSerializer.SerializeAsync(fs, hero);
            }
        }
        /// <summary>
        /// gets all heroes from file
        /// </summary>
        /// <returns></returns>
        public async Task<List<Hero>> GetAllHeroesAsync(){
            List<Hero> allHeroes = new List<Hero>();
            using(FileStream fs = File.OpenRead(filepath)){
                allHeroes.Add(await JsonSerializer.DeserializeAsync<Hero>(fs));
            }
            return allHeroes;
        }

    }
}