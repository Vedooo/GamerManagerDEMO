using GamerManagerDEMO.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDEMO.Entities
{
    public class Game: IEntity
    {
        
        public string GameName { get; set; }
        public string GameCategory { get; set; }
        public double GamePrice { get; set; }
        public int UnitInStock { get; set; }
        public double GameSize { get; set; }

    }
}
