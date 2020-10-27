using System;
using System.Collections.Generic;
using System.Text;
using HeroesDB.Models;

namespace HeroesDB
{
    public interface IVillainRepo
    {
        void AddVillain(SuperVillain superVillain);
        List<SuperVillain> GetAllVillains();

        SuperVillain GetVillainByName(string name);
    }
}
