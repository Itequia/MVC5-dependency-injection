using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Data.Repositories
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}