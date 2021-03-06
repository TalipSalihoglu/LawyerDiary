using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ICaseService
    {
        Case Get(int id);
        IList<Case> GetList();
        IList<Case> FilterWithDate(bool isPast,bool isNext);
        void Add(Case obj);
        void Update(Case obj);
        void Delete(Case obj);
    }
}
