using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Threading.Tasks;

namespace DemoAdventureWorks.DAL.Core
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context; 
        }


        public T? Get(object id)
        {
            if (Context == null) return null;
            return Context.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public int GetCount()
        {
            return Context.Set<T>().Count();
        }

        public IEnumerable<T> GetPage(int page = 1, int pageSize = 10)
        {
            return Context.Set<T>().Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }


        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            Context.Set<T>().AddRange(entities);
        }



        public void Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            Context.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            Context.Set<T>().Attach(entity);
            Context.Entry<T>(entity).State = EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                Context.Set<T>().Attach(entity);
                Context.Entry<T>(entity).State = EntityState.Modified;
            }
        }

        public virtual IEnumerable<T> GetWithSubset<S>(int page = 1, int pageSize = 10)
        {
            // return Context.Set<T>().Skip((page - 1) * pageSize).Take(pageSize).Include<S>( x=> x.)
            throw new NotImplementedException();

        }


    }
}
