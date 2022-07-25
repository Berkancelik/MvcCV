using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using MvcCV.EntiyLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class HobbyManager : IHobbyService
    {
        IHobbyDal _hobbyDal;

        public HobbyManager(IHobbyDal hobbyDal)
        {
            _hobbyDal = hobbyDal;
        }

        public List<Hobby> GetList()
        {
            return _hobbyDal.GetListAll();
        }

        public void TAdd(Hobby t)
        {
            _hobbyDal.Insert(t);
        }

        public void TDelete(Hobby t)
        {
            _hobbyDal.Delete(t);
        }

        public Hobby TGetById(int id)
        {
            return _hobbyDal.GetByID(id);
        }

        public void TUpdate(Hobby t)
        {
            _hobbyDal.Update(t);
        }
    }
}
