using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using MvcCV.EntiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CertificateManager : ICertificateService
    {
        ICertificateDal _certificateDal;

        public CertificateManager(ICertificateDal certificateDal)
        {
            _certificateDal = certificateDal;
        }

        public List<Certificate> GetList()
        {
            return _certificateDal.GetListAll();
        }

        public void TAdd(Certificate t)
        {
            _certificateDal.Insert(t);
        }

        public void TDelete(Certificate t)
        {
            _certificateDal.Delete(t);
        }

        public Certificate TGetById(int id)
        {
            return _certificateDal.GetByID(id);
        }

        public void TUpdate(Certificate t)
        {
            _certificateDal.Update(t);
        }
    }
}
