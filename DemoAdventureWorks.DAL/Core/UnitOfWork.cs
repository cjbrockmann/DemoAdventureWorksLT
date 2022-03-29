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
    public class UnitOfWork : IUnitOfWork
    {

        private readonly AdventureWorksLT2014Context _context;

        public UnitOfWork(AdventureWorksLT2014Context context )
        {
            _context = context;
            Products = new ProductRepository(_context);
            Customers = new Repository<Customer>(_context);
            Adresses = new Repository<Address>(_context);

        }

        public IProductRepository Products { get; private set; }

        public IRepository<Customer> Customers { get; private set; }
        
        public IRepository<Address> Adresses { get; private set; }

        public IRepository<T> RepositoryFor<T>() where T : class
        {
            if (typeof(T).Name == "Product") return (IRepository<T>) Products; 
            return new Repository<T>(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
