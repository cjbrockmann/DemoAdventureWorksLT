using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdventureWorks.DAL.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }

        IRepository<Customer> Customers { get; }

        IRepository<Address> Adresses { get; }

        IRepository<T> RepositoryFor<T>() where T : class; 

        int Complete(); 
    }
}
