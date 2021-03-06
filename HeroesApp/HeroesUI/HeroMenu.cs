using System;
using HerosDB;
using HerosDB.Models;
using HerosLib;
using System.Collections.Generic;
using HeroesUI;
using HeroesLib;

namespace HeroUI
{
    public class HeroMenu : IMenu
    {
        private string userInput;
        private ISuperHeroRepo repo;
        private IMessagingService service;
        private HeroTasks tasks;
        private HeroService heroService;
        private DBRepo dBRepo;
        private MessagingService messagingService;
        private FileRepo fileRepo;

        public HeroMenu(ISuperHeroRepo repo, IMessagingService service)
        {
            this.repo = repo;
            this.service = service;
            tasks = new HerosLib.HeroTasks();
            this.heroService = new HeroService(repo);
        }

        public HeroMenu(DBRepo dBRepo, MessagingService messagingService)
        {
            this.dBRepo = dBRepo;
            this.messagingService = messagingService;
        }

        public HeroMenu(FileRepo fileRepo, MessagingService messagingService)
        {
            this.fileRepo = fileRepo;
            this.messagingService = messagingService;
        }

        public void Start()
        {
            tasks.workDone += EmailService.SendEmail;
            tasks.workDone += PushNotification.SendPushNotification;
            tasks.workDone += TextMessageService.SendText;
            do
            {
                Console.WriteLine("Welcome Hero! What would you like to do?");
                Console.WriteLine("[0] Create a Hero?");
                Console.WriteLine("[1] Get all Heros?");
                Console.WriteLine("[2] Go to work?");
                Console.WriteLine("[3] Go back to the main menu?");
                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //call create a hero, get hero details
                        SuperHero newSuperHero = GetHeroDetails();
                        //call the business logic and the repo
                        heroService.AddHero(newSuperHero);
                        break;
                    case "1":
                        //call get all heros    
                        foreach (var hero in heroService.GetAllHeroes())
                        {
                            Console.WriteLine($"Hero: \n\tHero Alias: {hero.Alias} \n\tHero Real Name: {hero.RealName} \n\tHero Hideout: {hero.HideOut}");
                            foreach (var power in hero.SuperPowers)
                            {
                                Console.WriteLine($"\tSuper Powers:\n\t\tName: {power.Name}\n\t\tDescription: {power.Description}");
                            }
                        }
                        break;
                    case "2":
                        //call the event delegate for hero work, call get hero by name
                        tasks.DoWork();
                        tasks.ManageLife();
                        Console.WriteLine("Press <enter>");
                        break;
                    case "3":
                        Console.WriteLine("Going back to main");
                        break;
                    default:
                        //invalid input message;
                        service.InvalidInputMessage();
                        break;
                }
            } while (!userInput.Equals("3"));
        }
        public SuperHero GetHeroDetails()
        {
            SuperHero hero = new SuperHero();
            List<SuperPower> superPowers = new List<SuperPower>();
            Console.Write("Enter Hero Name: ");
            hero.Alias = Console.ReadLine();
            Console.Write("Enter Hero's Real Name: ");
            hero.RealName = Console.ReadLine();
            Console.Write("Enter Hero Hideout: ");
            hero.HideOut = Console.ReadLine();
            do
            {
                SuperPower superPower = new SuperPower();
                Console.WriteLine("Enter Hero Superpowers (type end to stop): ");
                Console.Write("Enter Super Power Name:");
                superPower.Name = Console.ReadLine();
                if (superPower.Name.Equals("end")) break;
                Console.Write("Enter Super Power Description:");
                superPower.Description = Console.ReadLine();
                superPowers.Add(superPower);
            } while (true);
            hero.SuperPowers = superPowers;
            //needs code to get all the villains and add them as a villain to the hero
            return hero;
        }
    }
}