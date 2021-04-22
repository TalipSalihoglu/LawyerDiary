using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> where T: class
    {
        public void Add(T entity)
        {
            using (var Context = new Context())
            {
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (var Context = new Context())
            {
                Context.Set<T>().Update(entity);
                Context.SaveChanges();
            }
            
        }
        public void Delete(T entity)
        {
            using (var Context = new Context())
            {
                Context.Set<T>().Remove(entity);
                Context.SaveChanges();
            };
           
        }
        public IList<T> GetList()
        {
            using (var Context = new Context()) 
            {
                return Context.Set<T>().ToList();
            };
            
        }
        public T Get(int id)
        {
            using (var Context = new Context()) {
                return Context.Set<T>().Find(id);
            };
            
        }
    }
}
