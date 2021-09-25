using GamerManagerDEMO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagerDEMO.Abstract
{
    public class BaseCampaignManagerService : ICampaignService
    {


        public void Name(Campaign campaign,Game game)
        {


            Console.WriteLine("{0} ", campaign.CampaignName);
            Console.WriteLine("{0} has new Offer {1}", game.GameName,campaign.DiscountPercentage);

        }
        public void Delete(Campaign campaign,Game game)
        {
            Console.WriteLine("{0} Offer is cancelling for{0}",campaign.CampaignName,game.GameName);
        }


        public void Start(Campaign campaign, Game game)
        {
            Console.WriteLine("{0} Offer was start at {1}",campaign.CampaignName,campaign.DateOfStart);
        }

        public void Finish(Campaign campaign, Game game)
        {
            Console.WriteLine("Offer is ending at {0}",campaign.DateOfFinish);
        }


        public void Update(Campaign campaign, Game game)
        {
            Console.WriteLine("{0} Cheapper than before",game.GameName);
        }

        public void About(Campaign campaign, Game game)
        {
            Console.WriteLine("About Offer: " +
                campaign.CampaignName + " " + "Campaign for:" + " " +
                game.GameName +
                campaign.DiscountPercentage + " " + 
                campaign.DateOfStart + " " + 
                campaign.DateOfFinish);
        }

        

        
    }
}



