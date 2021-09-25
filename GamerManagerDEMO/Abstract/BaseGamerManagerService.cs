using GamerManagerDEMO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDEMO.Abstract
{
    public class BaseGamerManagerService : IGamerService
    {
        

        public virtual void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer Information Saved {0}", gamer.UserName );
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Account Deleted {0}", gamer.UserName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Account Updated {0}", gamer.UserName);
        }
        public void About(Gamer gamer)
        {
            Console.WriteLine("Gamer Information {0} {1} {2} {3} {4}",
                gamer.UserName,
                gamer.Email,
                gamer.FirstName,
                gamer.LastName,
                gamer.FavoriteGame);
        }
    }
}
