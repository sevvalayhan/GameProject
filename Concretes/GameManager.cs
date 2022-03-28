using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine($"{game.GameName} adlı oyun sisteme eklendi." +
                $"fiyat : {game.Price}");
        
        }

        public void Remove(Game game)
        {
            Console.WriteLine($"{game.GameName} adlı oyun sistemden silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine($"{game.GameName} adlı oyun güncellendi." +
                $"fiyat : {game.Price}");
        }
    }
}
