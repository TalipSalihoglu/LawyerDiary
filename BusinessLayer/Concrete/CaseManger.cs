using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CaseManger : ICaseService
    {
        private ICaseDal _caseDal;

        public CaseManger(ICaseDal caseDal)
        {
            _caseDal = caseDal;
        }

        public void Add(Case obj)
        {
            if (obj.Description.Length>5 && obj.Topic.Length>2)
                _caseDal.Add(obj);
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
            return _caseDal.GetList();
        }

        public void Update(Case obj)
        {
            _caseDal.Update(obj);
        }
    }
}
