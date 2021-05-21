using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class BillManager : IBillService
    {
        private IBillDal _billDal;

        public BillManager(IBillDal billDal)
        {
            _billDal = billDal;
        }

        public void Add(Bill obj)
        {
            _billDal.Add(obj);
        }

        public void Delete(Bill obj)
        {
            _billDal.Delete(obj);
        }

        public Bill Get(int id)
        {
           return _billDal.Get(id);
        }

        public IList<Bill> GetList()
        {
            return _billDal.GetList();
        }

        public IList<Bill> Search(string description, bool isPast, bool isNext)
        {
            var faturaList = _billDal.GetList().Where(x=>x.Description.ToLower().Contains(description) == true).ToList();
            if (isPast)
                return faturaList.Where(x => x.LastDate < DateTime.Today).ToList();
            if (isNext)
                return faturaList.Where(x => x.LastDate >= DateTime.Today).ToList();
            else
                return faturaList;
        }

        public void Update(Bill obj)
        {
            _billDal.Update(obj);
        }
    }
}
