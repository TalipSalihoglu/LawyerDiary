using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICourtService
    {
        Court Get(int id);
        IList<Court> GetList();
        void Add(Court obj);
        void Update(Court obj);
        void Delete(Court obj);
    }
}
