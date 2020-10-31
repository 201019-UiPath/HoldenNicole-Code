using HeroesUI;
using HerosDB;
using HerosDB.Entities;
using System;
using HeroesLib;
namespace HeroUI
{
    public class MainMenu : IMenu
    {
        private string userInput;
        private HeroMenu heroMenu;
        private VillainMenu villainMenu;
        public MainMenu()
        public MainMenu(HeroContext context, IMapper mapper)
        {
            this.heroMenu = new HeroMenu(new FileRepo(), new MessagingService());
            this.villainMenu = new VillainMenu(new FileRepo(), new MessagingService());
            this.heroMenu = new HeroMenu(new DBRepo(context, mapper), new MessagingService());
            this.villainMenu = new VillainMenu(new DBRepo(context, mapper), new MessagingService());
        }
        public void Start()
        {
        }
    }
}