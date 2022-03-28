using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    public class CampaignManager : ICampaignServices
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} adlı kampanya sisteme eklendi.");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} adlı kampanya sistemden silindi.");

        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"{campaign.CampaignName} adlı kampanya güncellendi.");

        }
    }
}
