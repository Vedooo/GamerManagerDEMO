using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerManagerDEMO.Entities;

namespace GamerManagerDEMO.Abstract
{
    public interface ICampaignService
    {
        void Name(Campaign campaign,Game game);
        void Delete(Campaign campaign,Game game);
        void Update(Campaign campaign,Game game);
        void Start(Campaign campaign, Game game);
        void Finish(Campaign campaign, Game game);
        void About(Campaign campaign, Game game);
    }
}

