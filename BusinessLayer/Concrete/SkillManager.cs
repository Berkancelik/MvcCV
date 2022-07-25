using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using MvcCV.EntiyLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public List<Skill> GetList()
        {
            return _skillDal.GetListAll();
        }

        public void TAdd(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public Skill TGetById(int id)
        {
            return _skillDal.GetByID(id);
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
