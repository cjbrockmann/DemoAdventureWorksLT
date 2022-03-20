using DemoAdventureWorks.DAL.Context;
using DemoAdventureWorks.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdventureWorks.DAL.Core
{
    public class UnitOfWorkGenericFactory<T> where T : class
    {


        private readonly AdventureWorksLT2014Context _context;

        public UnitOfWorkGenericFactory(AdventureWorksLT2014Context context)
        {
            _context = context;
        }

        public IRepository<T>? GetRepository()
        {
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
