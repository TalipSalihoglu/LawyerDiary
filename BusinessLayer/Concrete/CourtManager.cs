using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CourtManager : ICourtService
    {
        private ICourtDal _courtDal;

        public CourtManager(ICourtDal courtDal)
        {
            _courtDal = courtDal;
        }

        public void Add(Court obj)
        {
            _courtDal.Add(obj);
        }

        public void Delete(Court obj)
        {
            _courtDal.Delete(obj);
        }

        public Court Get(int id)
        {
            return _courtDal.Get(id);
        }

        public IList<Court> GetList()
        {
            return _courtDal.GetList();
        }

        public void Update(Court obj)
        {
            _courtDal.Update(obj);
        }
    }
}
