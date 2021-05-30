using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class MusteriManager : Form
    {
        ClientManager Manager = new ClientManager(new ClientDal());
        Client musteri = null;
        MainPage main = new MainPage();
        MusteriYonetimEkrani mye = new MusteriYonetimEkrani();
        public MusteriManager()
        {
            InitializeComponent();
        }
        public MusteriManager(int id)
        {
            InitializeComponent();
            musteri= Manager.Get(id);
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
            if(müsAdı.Text != "" || müsAdres.Text != "" || müsMail.Text != "")
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

                MessageBox.Show("İşleme başarıyla tamamlandı");
                this.Hide();
                mye.Show();
            }
            else
            {
                MessageBox.Show("İşlem Başarısız!!!\nEksik bilgi olmamalıdır");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            müsAdı.Text = "";
            müsAdres.Text = "";
            müsMail.Text = "";
        }

        private void mouseUpMovement(object sender, MouseEventArgs e)
        {
            
        }

        private void mouseMovementEvent(object sender, MouseEventArgs e)
        {

        }

        private void mouseDownEvent(object sender, MouseEventArgs e)
        {

        }
    }
}
