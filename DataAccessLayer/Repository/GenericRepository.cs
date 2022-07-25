using DataAccessLayer.Abstract;
using MvcCV.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        public void Delete(T t)
        {
            using var c = new DbCvContext();

            c.Remove(t);
            c.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var c = new DbCvContext();
            return c.Set<T>().Find(id);

        }

        public List<T> GetListAll()
        {
            using var c = new DbCvContext();
            return c.Set<T>().ToList();
        }

        public List<T> GetListAll(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            using var c = new DbCvContext();
            return c.Set<T>().Where(filter).ToList();
;        }

        public void Insert(T t)
        {
            using var c = new DbCvContext();
            c.Add(t);
        }

        public void Update(T t)
        {
            using var c = new DbCvContext();
            c.Update(t);
            c.SaveChanges();

        }
    }
}
