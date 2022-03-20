using DemoAdventureWorks.DAL.Context;
using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdventureWorks.DAL.Core
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {


        public ProductRepository(AdventureWorksLT2014Context context) : base (context)
        {
        }

        public IEnumerable<Product> GetAllProductsWithDescriptions(int page, int pageSize)
        {
            // return Context.Products
            
            throw new NotImplementedException();
        }

        public AdventureWorksLT2014Context AdventureWorksLT2014Context { get { return Context as AdventureWorksLT2014Context; } }

    }
}
