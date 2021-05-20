using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAppointmentService
    {
        Appointment Get(int id);
        IList<Appointment> GetList();
        IList<Appointment> Search(string name,bool isPast,bool isNext);
        void Add(Appointment obj);
        void Update(Appointment obj);
        void Delete(Appointment obj);

    }
}
