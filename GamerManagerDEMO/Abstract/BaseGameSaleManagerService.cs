using GamerManagerDEMO.Abstract;
using GamerManagerDEMO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDEMO
{
    public abstract class BaseGameSaleManagerService : IGameSaleService
    {
        public virtual void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("{0} campaign applied.", campaign.Name);
            Console.WriteLine("{0} game has been sold to {1}", game.GameName, gamer.UserName);
        }
    }
}
