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
        IList<Bill> Search(string name,bool isPast,bool isNext);

        void Add(Bill obj);
        void Update(Bill obj);
        void Delete(Bill obj);
    }
}
