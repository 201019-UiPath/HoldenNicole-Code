using System.Collections.Generic;
using HeroesLib;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using HeroesDB.Models;

namespace HeroesDB
{
    /// <summary>
    /// repository using files
    /// </summary>
    public class FileRepo : ISuperHeroRepo
    {
        string filepath = "HeroesApp/HeroesDB/Heroes/Heroes.txt";
        /// <summary>
        /// Adds hero to file
        /// </summary>
        /// <param name="hero"></param>
        public async void AddHeroAsync(SuperHero hero){
            using(FileStream fs = File.Create(filepath)){
                await JsonSerializer.SerializeAsync(fs, hero);
                System.Console.WriteLine("Hero is being written to file");
            }
        }
        /// <summary>
        /// gets all heroes from file
        /// </summary>
        /// <returns></returns>
        public async Task<List<SuperHero>> GetAllHeroesAsync(){
            List<SuperHero> allHeroes = new List<SuperHero>();
            using(FileStream fs = File.OpenRead(filepath)){
                allHeroes.Add(await JsonSerializer.DeserializeAsync<SuperHero>(fs));
            }
            return allHeroes;
        }
        public SuperHero GetHeroByName(string name)
        {
            throw new System.NotImplementedException();
        }

    }
}