using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdventureWorks.DAL.Core
{
    public interface IRepository<T> where T : class
    {
        T? Get(object id);
        IEnumerable<T> GetAll();

        IEnumerable<T> GetPage(int page = 1, int pageSize = 10); 

        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        int GetCount();

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);  
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);



    }
}
