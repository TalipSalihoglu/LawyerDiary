using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
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

        public void Update(Bill obj)
        {
            _billDal.Update(obj);
        }
    }
}
