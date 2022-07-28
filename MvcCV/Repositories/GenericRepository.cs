using MvcCV.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MvcCV.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        DbCvContext db = new DbCvContext();

        public List<T> List()
        {
            return db.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TDelete(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public void TUpdate(T p)
        {
            db.Set<T>().Update(p);
        }

        public T TGet(int id)
        {
            return db.Set<T>().Find(id);
        }

        public T Find(Expression<Func<T,bool>> where)
        {
            return db.Set<T>().FirstOrDefault(where);
        }


    }
}
