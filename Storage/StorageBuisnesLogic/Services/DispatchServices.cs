using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageBuisnesLogic.Services
{
    public interface IDispatchServices
    {
        List<Dispatch> GetList();
    }

    public class DispatchServices : IDispatchServices
    {
        public List<Dispatch> GetList()
        {

            var dispatchList =
               new List<Dispatch>
               {
                         new Dispatch
                         {
                            GoodId = 1,
                            Amount = 7,
                            data = DateTime.Now
                         },
                         new Dispatch
                         {
                            GoodId = 2,
                            Amount = 20,
                            data = DateTime.Now
                         }
               };

            return dispatchList;
        }
    }
}
