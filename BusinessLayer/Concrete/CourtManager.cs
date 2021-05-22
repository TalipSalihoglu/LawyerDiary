using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public int GetIdWithCourtNo(int CourtNo)
        {
            var court = _courtDal.GetList().Where(x => x.CourtNumber == CourtNo).FirstOrDefault();
            if(court==null)
            {
                return -1;
            }
            return court.CourtId;
        }

        public string GetJudgeWithCourtNo(int CourtNo)
        {
            var court =_courtDal.GetList().Where(x => x.CourtNumber == CourtNo).FirstOrDefault();
            return court.JudgeName;
        }

        public IList<Court> GetList()
        {
            return _courtDal.GetList();
        }

        public IList<Court> Search(string CourtNo)
        {
            return _courtDal.GetList().Where(x => x.CourtNumber.ToString().Contains(CourtNo) == true).ToList();
        }

        public void Update(Court obj)
        {
            _courtDal.Update(obj);
        }
    }
}
