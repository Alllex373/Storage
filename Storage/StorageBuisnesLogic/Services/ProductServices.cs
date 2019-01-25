using Storage.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageBuisnesLogic.Services
{
    public interface IProductServices
    {
        List<Product> GetList();
    }
    public class ProductServices: IProductServices
    {
        
            public List<Product> GetList()
            {
                var productList =
                   new List<Product>
                   {
                         new Product
                         {
                            Id = 1,
                            Name = "Banana"                            
                         },
                         new Product
                         {
                            Id = 2,
                            Name = "Kiwi"
                         }
                   };

                return productList;
            }
        
    }
}
