using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using EntityLayer.Concrete;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;

namespace LawyerDiaryUI
{
    public partial class FaturaIslemEkranı : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

         );

        BillManager _billManager = new BillManager(new BillDal());
        ClientManager _clientManager = new ClientManager(new ClientDal());
        Bill fatura=null;
        public FaturaIslemEkranı()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));

        }
        public FaturaIslemEkranı(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));

            fatura = _billManager.Get(id);


        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FaturaIslemEkranı_Load(object sender, EventArgs e)
        {
            var list = _clientManager.GetList();
            foreach (var i in list)
                CB_FaturaMusteri.Items.Add(i.ClientName);

            if (fatura!=null)
            {
                textBox1.Text= fatura.Price.ToString();
                textBox2.Text= fatura.LastDate.ToString();
                richTextBox1.Text= fatura.Description;
                CB_FaturaMusteri.Text = _clientManager.Get(fatura.ClientId).ClientName;   
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || richTextBox1.Text == "")
            {
                MessageBox.Show("Bu alanlar boş olamaz");
                return;
            }
            if (fatura != null)
            {
                fatura.Price =Convert.ToDecimal(textBox1.Text);
                fatura.Description = richTextBox1.Text;
                fatura.LastDate = DateTime.Parse(textBox2.Text);
                fatura.ClientId = _clientManager.GetClientIdWithName(CB_FaturaMusteri.SelectedItem.ToString());
                _billManager.Update(fatura);
            }
            else
            {
                Bill newBill= new Bill()
                {
                    Price= Convert.ToDecimal(textBox1.Text),
                    Description = richTextBox1.Text,
                    LastDate = DateTime.Parse(textBox2.Text),
                    ClientId = _clientManager.GetClientIdWithName(CB_FaturaMusteri.SelectedItem.ToString())
                };
                _billManager.Add(newBill);
            }
            FaturaAnaEkran fae = new FaturaAnaEkran();
            this.Hide();
            fae.Show();
        }

        private void faturaBackwardBtn_Click(object sender, EventArgs e)
        {
            FaturaAnaEkran fae = new FaturaAnaEkran();
            this.Hide();
            fae.Show();
        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
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
    }
}
