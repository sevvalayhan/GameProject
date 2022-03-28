using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstracts
{
    public interface ISaleService
    {
        public void Sale(Gamer gamer,Game game,Campaign campaign);
    }
}
