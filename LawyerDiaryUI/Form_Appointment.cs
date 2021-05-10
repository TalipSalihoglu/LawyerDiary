using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class Form_Appointment : Form
    {
        public Form_Appointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            AppointmentManager manager = new AppointmentManager(new AppointmentDal());
            Appointment app = new Appointment()
            {
                Subject = "konu",
                AppointmentDate = new DateTime(2020, 12, 21),
                ClientId=3,
                Status=true,
                Description="açıklama yapıldı",

            };
            manager.Add(app);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            AppointmentManager manager = new AppointmentManager(new AppointmentDal());
            var p=manager.Get(2);
            manager.Delete(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AppointmentManager manager = new AppointmentManager(new AppointmentDal());
            var list = manager.GetList();
            foreach (var item in list)
            {
                string cl = item.AppointmentId + "       " + item.ClientId + "         " + item.AppointmentDate + "         " + item.Status;
                listBox1.Items.Add(cl);
            }
        }
    }
}
