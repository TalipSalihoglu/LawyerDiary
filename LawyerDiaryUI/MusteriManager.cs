using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class MusteriManager : Form
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

        ClientManager Manager = new ClientManager(new ClientDal());
        Client musteri = null;
        MainPage main = new MainPage();
        MusteriYonetimEkrani mye = new MusteriYonetimEkrani();
        public MusteriManager()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }
        public MusteriManager(int id)
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
            musteri = Manager.Get(id);
        }

        private void MusteriManager_Load(object sender, EventArgs e)
        {
            if (musteri != null)
            {
                müsAdı.Text = musteri.ClientName.ToString();
                müsMail.Text = musteri.Email.ToString();
                müsAdres.Text = musteri.Address.ToString();
            }
                
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            mye.Show();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(müsAdı.Text != "" && müsAdres.Text != "" && müsMail.Text != "")
            {
                if (musteri == null)
                {
                    var client = new Client()
                    {
                        ClientName = müsAdı.Text,
                        Address = müsAdres.Text,
                        Email = müsMail.Text
                    };
                    Manager.Add(client);
                }
                else
                {
                    musteri.ClientName = müsAdı.Text;
                    musteri.Address = müsAdres.Text;
                    musteri.Email = müsMail.Text;
                    Manager.Update(musteri);
                }

                MessageBox.Show("İşleme başarıyla tamamlandı","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                mye.Show();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!!!\nEksik bilgi olmamalıdır","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            müsAdı.Text = "";
            müsAdres.Text = "";
            müsMail.Text = "";
        }
        bool mouseDown;
        private Point offset;
        private void mouseUpMovement(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void mouseMovementEvent(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseDownEvent(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
    }
}
