using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using MvcCV.EntiyLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetList()
        {
            return _contactDal.GetListAll();
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetByID(id);
        }

        public void TUpdate(Contact t)
        {
            _contactDal.Update(t);
        }
    }
}
