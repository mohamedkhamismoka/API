using System.Collections.Generic;
using System.Linq;
using WebApplication20.BL.interfaces;
using WebApplication20.DAL.Database;

namespace WebApplication20.BL.Reposatories
{
    public class BaseReposatory<T> : IBaseRepository<T> where T : class
    {
        private readonly database db;

        public BaseReposatory(database db)
        {
            this.db = db;
        }
        public void delete(int id)
        {
            db.Set<T>().Remove(db.Set<T>().Find(id));
            db.SaveChanges();
     
        }

        public T Filter(System.Func<T, bool> filter = null)
        {
           return db.Set<T>().Where(filter).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return db.Set<T>().Select(a => a);
        }

        public T getbyid(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void update(T entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
      public  void create(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
        }
    }
}
