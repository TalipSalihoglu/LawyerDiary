
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class LawyerManager : ILawyerService
    {
        private ILawyerDal _lawyerDal;

        public LawyerManager(ILawyerDal lawyerDal)
        {
            _lawyerDal = lawyerDal;
        }

        public void Add(Lawyer lawyer)
        {
            if(lawyer.Name.Length>2 && lawyer.Email.Length>5 && lawyer.Password.Length>5)
            {
                _lawyerDal.Add(lawyer);
            }
        }

        public Lawyer Get(int id)
        {
            return _lawyerDal.Get(id);
        }

        public int Login(string email, string password)
        {
            Lawyer lawyer=_lawyerDal.GetList().Where(x => x.Email == email).FirstOrDefault();
            if (lawyer == null || lawyer.Password != password)
                return -1;
            else
                return lawyer.LawyerId;
        }

        public void Update(Lawyer lawyer)
        {
            _lawyerDal.Update(lawyer);
        }
    }
}
