using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete
{
    public class LawyerDal: GenericRepository<Lawyer>, ILawyerDal
    {
    }
}
