using GamerManagerDEMO.Abstract;
using GamerManagerDEMO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDEMO.Concrete
{
    public class GamerServiceManager : BaseGamerManagerService
    {

        private ICheckService _checkService;

        public GamerServiceManager(ICheckService gamerCheckService)
        {
            _checkService = gamerCheckService;
        }

        public override void Save(Gamer gamer)
        {
            if (_checkService.CheckIfRealPerson(gamer))
            {
                base.Save(gamer);
            }
            else
            {
                throw new Exception("not a valid Customer");
            }
        }
    }
}


