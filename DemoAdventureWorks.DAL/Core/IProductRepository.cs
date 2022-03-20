using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdventureWorks.DAL.Core
{
    public interface IProductRepository : IRepository<Product>
    {
       IEnumerable<Product>  GetAllProductsWithDescriptions(int page, int pageSize);

    }
}
