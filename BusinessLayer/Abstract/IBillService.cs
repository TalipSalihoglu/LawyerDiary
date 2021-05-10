using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IBillService
    {
        Bill Get(int id);
        IList<Bill> GetList();
        void Add(Bill obj);
        void Update(Bill obj);
        void Delete(Bill obj);
    }
}
