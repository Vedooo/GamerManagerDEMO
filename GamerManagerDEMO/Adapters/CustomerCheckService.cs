using GamerManagerDEMO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerManagerDEMO.Abstract;

namespace GamerManagerDEMO.Adapters
{
    public class CustomerCheckService: ICheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return true;
        }
    }
}
