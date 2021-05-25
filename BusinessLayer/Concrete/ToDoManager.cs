using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ToDoManager : IToDoService
    {
        private IToDoDal _todoDal;

        public ToDoManager(IToDoDal todoDal)
        {
            _todoDal = todoDal;
        }

        public void Add(ToDo obj)
        {
            obj.Status = true;
            obj.LawyerId = 1;
            _todoDal.Add(obj);
        }

        public void Completed(ToDo obj)
        {
            obj.Status = false;
            _todoDal.Update(obj);
        }

        public void Delete(ToDo obj)
        {
            _todoDal.Delete(obj);
        }

        public ToDo Get(int id)
        {
           return _todoDal.Get(id);
        }

        public IList<ToDo> GetList()
        {
            return _todoDal.GetList();
        }

        public ToDo GetWithTask(string task)
        {
            return _todoDal.GetList().Where(x => x.Task == task).FirstOrDefault();
        }

        public void Update(ToDo obj)
        {
            _todoDal.Update(obj);
        }
    }
}
