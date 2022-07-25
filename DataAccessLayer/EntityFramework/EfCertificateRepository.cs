using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using MvcCV.EntiyLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfCertificateRepository: GenericRepository<Certificate>, ICertificateDal
    {
    }
}
