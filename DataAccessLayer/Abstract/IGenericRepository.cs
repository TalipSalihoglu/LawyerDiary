using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericRepository<T> where T : class,new()
    {
            T Get(int id);
            IList<T> GetList();
            void Add(T entity);
            void Update(T entity);
            void Delete(T entity);
    }
}
