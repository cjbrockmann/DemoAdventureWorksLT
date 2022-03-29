using DemoAdventureWorks.DAL.Context;
using DemoAdventureWorks.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdventureWorks.DAL.Core
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {

        private AdventureWorksLT2014Context _context;

        public ProductRepository(AdventureWorksLT2014Context context) : base (context)
        {
            _context = context; 
        }

        public IEnumerable<Product> GetAllProductsWithDescriptions(int page, int pageSize)
        {

            return _context.Products.Include(p => p.ProductModel).ThenInclude(x => x.ProductModelProductDescriptions).ToList();

        }

        // public AdventureWorksLT2014Context AdventureWorksLT2014Context { get { return Context as AdventureWorksLT2014Context; } }

    }
}
