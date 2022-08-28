using System;
using System.Collections.Generic;

namespace WebApplication20.BL.interfaces
{
    public interface IBaseRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T getbyid(int id);

        void update(T entity);
        void delete(int id);

        T Filter(Func<T, bool> filter = null);
        void create(T entity);

    }
}
