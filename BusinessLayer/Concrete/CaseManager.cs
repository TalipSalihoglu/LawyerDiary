using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CaseManager : ICaseService
    {
        private ICaseDal _caseDal;

        public CaseManager(ICaseDal caseDal)
        {
            _caseDal = caseDal;
        }

        public void Add(Case obj)
        {
            if (obj.Description.Length>5 && obj.Topic.Length>2)
            {
                obj.LawyerId = 1;
                obj.Status = true;
                _caseDal.Add(obj);
            }
               
        }

        public void Delete(Case obj)
        {
            obj.Status = false;
            _caseDal.Update(obj);
        }

        public Case Get(int id)
        {
            return _caseDal.Get(id);
        }

        public IList<Case> GetList()
        {
            return _caseDal.GetList().Where(x => x.Status == true).ToList();
        }

        public IList<Case> FilterWithDate(bool isPast, bool isNext)
        {
            var CaseList = _caseDal.GetList().Where(x=>x.Status==true).ToList();
            if (isPast)
                return CaseList.Where(x => x.CaseDate < DateTime.Today).ToList();
            if (isNext)
                return CaseList.Where(x => x.CaseDate >= DateTime.Today).ToList();
            else
                return CaseList;
        }


        public void Update(Case obj)
        {
            _caseDal.Update(obj);
        }
    }
}
