using GamerManagerDEMO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDEMO.Abstract
{
    class BaseGameManagerService : IGameService
    {
       
        public virtual void Add(Game game)
        {
            Console.WriteLine("New Game is Now Online !! {0} {1} {2} !!", game.GameName, game.GameCategory,game.GamePrice);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} is Deleted on List",game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("{0} has a new version. For a short only {1}",game.GameName,game.GamePrice);
        }
        public void Size(Game game)
        {
            Console.WriteLine("You need "+ " " + game.GameSize + " " +" GB area in your PC");
        }
        public void About(Game game)
        {
            Console.WriteLine("Game İnformations: {0} {1} {2}$ {3}GB ",game.GameName, game.GameCategory, game.GamePrice,game.GameSize);
        }

        
    }
}
