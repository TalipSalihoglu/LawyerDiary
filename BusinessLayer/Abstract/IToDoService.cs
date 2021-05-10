using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IToDoService
    {
        ToDo Get(int id);
        IList<ToDo> GetList();
        void Add(ToDo obj);
        void Update(ToDo obj);
        void Delete(ToDo obj);
        void Completed(ToDo obj);
    }
}
