﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface ILawyerService
    {
        Lawyer Get(int id);
        void Add(Lawyer lawyer);
        void Update(Lawyer lawyer);
        int Login(string email,string password);
        bool ChangePassword(int lawyer_id,string password, string newPassword, string checkPassword);
    }
}
