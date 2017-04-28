using DI.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Data.Repositories
{
    public class BaseRepository<T>: IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        public BaseRepository()
        {
            _db = new ApplicationDbContext();
        }

        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();
        }
        
        public IQueryable<T> GetAll()
        {
            return _db.Set<T>();
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }
    }
}