using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
namespace LawyerDiaryUI
{
    public partial class MainPage : Form
    {
        private Panel leftBorderBtn;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse

          );

        public MainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }
       
        private void müsteri_yonetim_ekrani_Click(object sender, EventArgs e)
        {
            MusteriYonetimEkrani musteriYonetimEkrani = new MusteriYonetimEkrani();
            this.Hide();
            musteriYonetimEkrani.Show();
        }

        private void muhasebe_yonetimi_Click(object sender, EventArgs e)
        {
            FaturaAnaEkran faturaAnaEkran = new FaturaAnaEkran();
            this.Hide();
            faturaAnaEkran.Show();

        }

        private void randevu_yonetim_ekrani_Click(object sender, EventArgs e)
        {
            RandevuYonetim randevuYonetim = new RandevuYonetim();
            randevuYonetim.Show();
            this.Hide();
            

        }

        private void dava_yonetimi_Click(object sender, EventArgs e)
        {
            DavaYonetimAnaEkran DavaYonetim = new DavaYonetimAnaEkran();
            DavaYonetim.Show();
            this.Hide();

        }

        private void yapilacaklar_listesi_Click(object sender, EventArgs e)
        {
            ToDoList todo = new ToDoList();
            todo.Show();
            this.Hide();
        }

        private void kullanici_hesap_islemleri_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            kullaniciIslemleri.Show();
            this.Hide();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //necessary for dragging by clicking on the upper panel.
        bool mouseDownEvent;
        private Point offset; 
        private void mouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDownEvent = true;
        }

        private void mouseMovementEvent(object sender, MouseEventArgs e)
        {
            if  (mouseDownEvent == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUpEvent(object sender, MouseEventArgs e)
        {
            mouseDownEvent = false;
        }

    }
}
