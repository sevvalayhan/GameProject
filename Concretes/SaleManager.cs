using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    public class SaleManager : ISaleService
    {
        public void Sale(Gamer gamer, Game game, Campaign campaign)
        {
            double newPrice = game.Price - (game.Price * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + " adlı kişisine " + newPrice + " TL den satıldı.");
            Console.WriteLine(" Oyunun Gerçek Fiyatı = " + game.Price + " TL");
            Console.WriteLine(" Uygulanan indirim = " + game.Price * (campaign.CampaignDiscount / 100) + " TL");

        }
    }
}
