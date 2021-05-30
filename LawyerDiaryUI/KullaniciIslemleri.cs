using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace LawyerDiaryUI
{
    public partial class KullaniciIslemleri : Form
    {
        LawyerManager _lawyerManager = new LawyerManager(new LawyerDal());
        Lawyer lawyer; 

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

              );

        public KullaniciIslemleri()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
            lawyer = _lawyerManager.Get(1);
        }

        bool mouseDown;
        private Point offset;
        private void mouseDownEvent(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void mouseMovementEvent(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUpEvent(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

<<<<<<< HEAD
        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {

=======
        private void anaMenuyeDon_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void KullaniciIslemleri_Load(object sender, EventArgs e)
        {
            isimBox.Text = lawyer.Name;
            addressBox.Text =lawyer.Address;
            emailBox.Text = lawyer.Email;
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            if (isimBox.Text != "" && addressBox.Text != "" && emailBox.Text != "")
            {
                lawyer.Name = isimBox.Text;
                lawyer.Address = addressBox.Text;
                lawyer.Email = emailBox.Text;
                _lawyerManager.Update(lawyer);
                MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı");
            }
            else
                MessageBox.Show("Gerekli alanlar boş bırakılamaz!");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           bool result = _lawyerManager.ChangePassword(lawyer.LawyerId,eskiSifre.Text,yeniSifre.Text,yeniSifreTekrar.Text);
            if (result)
                MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı");
            else
                MessageBox.Show("Bilgileri kontrol ediniz.\nGüncelleme yapılamadı!!");
>>>>>>> e49883e9638724b7f15e367d84849c0780381c1d
        }
    }
}
