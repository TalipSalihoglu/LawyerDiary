using BusinessLayer.Concrete;
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
    public partial class RandevuIslemleri : Form
    {
        AppointmentManager _manager = new AppointmentManager(new AppointmentDal());
        ClientManager _clientManager = new ClientManager(new ClientDal());
        Appointment appointment = null;
        public RandevuIslemleri()
        {
            InitializeComponent();
        }

        public RandevuIslemleri(int id)
        {
            InitializeComponent();
            appointment= _manager.Get(id);
        }

        private void RandevuIslemleri_Load_1(object sender, EventArgs e)
        {

            if (appointment != null)
            {
                RandevuKonu.Text = appointment.Subject;
                textBoxAcıklama.Text = appointment.Description;
                textBoxSanık.Text = _clientManager.Get(appointment.ClientId).ClientName;
                textBoxTarih.Text = appointment.AppointmentDate.ToString();
                textBoxSanık.Enabled = false;
            }
 

        }
        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            if (RandevuKonu.Text == "" || textBoxAcıklama.Text == ""|| textBoxTarih.Text=="")
            { 
                MessageBox.Show("Bu alan boş olamaz");
                return;
            }
            if (appointment!=null)
            {
                appointment.Subject= RandevuKonu.Text;
                appointment.Description=textBoxAcıklama.Text ;
                appointment.AppointmentDate = DateTime.Parse(textBoxTarih.Text);
                _manager.Update(appointment); 
            }
            else
            {
                Appointment newAppointment = new Appointment()
                {
                    Subject = RandevuKonu.Text,
                    Description = textBoxAcıklama.Text,
                    AppointmentDate = DateTime.Parse(textBoxTarih.Text),
                    ClientId = int.Parse(textBoxSanık.Text),
                 };
                _manager.Add(newAppointment);
            }
            RandevuYonetim ry = new RandevuYonetim();
            this.Hide();
            ry.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void anaMenuyeDon_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void backwardBtn_Click(object sender, EventArgs e)
        {
            RandevuYonetim ry = new RandevuYonetim();
            this.Hide();
            ry.Show();
        }

      

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem iptal edildi!");
            RandevuYonetim ry = new RandevuYonetim();
            this.Hide();
            ry.Show();
        }

       
    }
}
