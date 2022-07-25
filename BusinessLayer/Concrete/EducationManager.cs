using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using MvcCV.EntiyLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class EducationManager : IEducationService
    {
        IEducationDal _education;

        public EducationManager(IEducationDal education)
        {
            _education = education;
        }

        public List<Education> GetList()
        {
            return _education.GetListAll();
        }

        public void TAdd(Education t)
        {
            _education.Insert(t);
        }

        public void TDelete(Education t)
        {
            _education.Delete(t);
        }

        public Education TGetById(int id)
        {
            return _education.GetByID(id);
        }

        public void TUpdate(Education t)
        {
            _education.Update(t);
        }
    }
}
