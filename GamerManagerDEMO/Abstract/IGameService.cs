using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerManagerDEMO.Entities;

namespace GamerManagerDEMO.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        void About(Game game);
        void Size(Game game);

    }
}
