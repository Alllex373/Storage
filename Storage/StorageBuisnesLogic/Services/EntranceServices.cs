using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageBuisnesLogic.Services
{
    public interface IEnranceServices
    {
        List<Entrance> GetList();
    }

        public class EntranceServices : IEnranceServices
        {
        public List<Entrance> GetList()
        {
            
            var entranceList =
               new List<Entrance>
               {
                         new Entrance
                         {
                            GoodId = 1,
                            Amount = 15, 
                            data = DateTime.Now
                         },
                         new Entrance
                         {
                            GoodId = 2,
                            Amount = 35,
                            data = DateTime.Now
                         }
               };

            return entranceList;
        }

    }
}   
