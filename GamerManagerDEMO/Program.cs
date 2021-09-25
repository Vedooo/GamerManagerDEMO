using System;
using GamerManagerDEMO.Entities;
using GamerManagerDEMO.Abstract;
using GamerManagerDEMO.Concrete;
using GamerManagerDEMO.Adapters;

namespace GamerManagerDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                UserName = "Xan",
                Email = "xan@gmail.com",
                FirstName = "Falanca",
                LastName = "Filan",
                NationalId = "12312312312",
                FavoriteGame = "CS Go",
                DateOfBirty = new DateTime(1995,5,12)
            };

            Game game1 = new Game
            {
  
                GameCategory = "Strategy",
                GameName = "Age of Empires",
                GamePrice = 27.85,
                UnitInStock = 109,
                GameSize = 10.27
                
            };

            Campaign campaign1 = new Campaign
            {
                Id = 2,
                CampaignName = "Limited Summer Deals",
                DiscountPercentage = 25.10,
                DateOfStart = new DateTime(2021, 9, 9),
                DateOfFinish = new DateTime(2021, 10, 9)
            };


            //Mernis does not working so I used my own CheckService

            CustomerCheckService customerCheckService = new CustomerCheckService();
            customerCheckService.CheckIfRealPerson(gamer1);
            
            
            Console.WriteLine("--------**********--------");
           
            
            BaseGameManagerService gameManagerService = new BaseGameManagerService();
            gameManagerService.Add(game1);
            gameManagerService.Size(game1);
            gameManagerService.About(game1);
            gameManagerService.Delete(game1);
            gameManagerService.Update(game1);
           

            Console.WriteLine("--------**********--------");
            
            
            BaseGamerManagerService baseGamerManagerService = new BaseGamerManagerService();
            baseGamerManagerService.Save(gamer1);
            baseGamerManagerService.About(gamer1);
            baseGamerManagerService.Update(gamer1);
            baseGamerManagerService.Delete(gamer1);

            Console.WriteLine("--------**********--------");


            BaseCampaignManagerService campaignManagerService = new BaseCampaignManagerService();
            campaignManagerService.Name(campaign1,game1);
            campaignManagerService.About(campaign1, game1);
            campaignManagerService.Update(campaign1, game1);
            campaignManagerService.Start(campaign1, game1);
            campaignManagerService.Finish(campaign1, game1);
            campaignManagerService.Delete(campaign1, game1);


            Console.WriteLine("--------**********--------");


            GameSaleServiceManager gameSaleManager = new GameSaleServiceManager();
            gameSaleManager.Sale(game1, gamer1, campaign1);

            Console.ReadLine();
        
        
        
        
        
        
        }
    }
}
