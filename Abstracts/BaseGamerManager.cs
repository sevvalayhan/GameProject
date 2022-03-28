using GameProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public abstract  class BaseGamerManager : IGamerService
    {
       

        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine("save to db "+gamer.FirstName );
        }

        public void Remove(Gamer gamer)
        {
            Console.WriteLine("remove to db "+gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("update in db " + gamer.FirstName);

        }
    }
}
