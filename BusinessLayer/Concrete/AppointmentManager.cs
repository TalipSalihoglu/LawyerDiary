using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        private IAppointmentDal _appointmentDal;

        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public void Add(Appointment obj)
        {
            obj.Status = true;
            _appointmentDal.Add(obj);
        }

        public void Delete(Appointment obj)
        {
            obj.Status = false;
            _appointmentDal.Update(obj);
        }

        public Appointment Get(int id)
        {
           return _appointmentDal.Get(id);
        }

        public IList<Appointment> GetList()
        {
            return _appointmentDal.GetList().Where(x=>x.Status==true).ToList();
        }

        public IList<Appointment> Search(string name, bool isPast,bool isNext)
        {
            var randevuList = _appointmentDal.GetList().Where(x => x.Status == true && x.Subject.ToLower().Contains(name) == true).ToList();
            if (isPast)
                return randevuList.Where(x=>x.AppointmentDate < DateTime.Today).ToList();
            if (isNext)
                return randevuList.Where(x => x.AppointmentDate >= DateTime.Today).ToList();
            else
                return randevuList;
        }

        public void Update(Appointment obj)
        {
            _appointmentDal.Update(obj);
        }
    }
}
