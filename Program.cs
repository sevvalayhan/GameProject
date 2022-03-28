using GameProject.Adapters;
using GameProject.Concretes;
using GameProject.Entities;
using System;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gamerManager = new GamerManager(new MernisServiceAdapter());
            //gamerManager.Add(new Gamer { GamerId = 1, FirstName = "AYŞE", LastName = "yılamz", NationalityId = "46546546", DateOfBirth = new DateTime(2002, 5, 1) });
            //Mernis sistemi entegre edildiği için gerçek bir insanın adı, soyadı, doğum tarihi ve tc kimlik numarası girildiğinde çalışır.

            


            var gamer = new Gamer { GamerId = 1, FirstName = "Ali", LastName = "Ay", DateOfBirth = new DateTime(2002, 6, 8), NationalityId = "12345679" };
            var game = new Game { GameId = 1, GameName = "Sudoku", Price = 60 };
            var campaign = new Campaign { CampaignId = 1 ,CampaignName="Ramazan Özel İndirimi",CampaignDiscount=0.8};





            var saleManager = new SaleManager();
            saleManager.Sale(gamer,game,campaign);
            Console.ReadKey();  
        
        }
    }
}
