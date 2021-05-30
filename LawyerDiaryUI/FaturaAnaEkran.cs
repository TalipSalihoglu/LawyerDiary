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

namespace LawyerDiaryUI
{
    public partial class FaturaAnaEkran : Form
    {
        BillManager _billManager = new BillManager(new BillDal());

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse

       );

        public FaturaAnaEkran()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void FaturaAnaEkran_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _billManager.GetList();
        }

        private void FaturaGuncelleBtn_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                FaturaIslemEkranı faturaIslem = new FaturaIslemEkranı(id);
                faturaIslem.Show();
                this.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }
        }

        private void FaturaEkleBtn_Click(object sender, EventArgs e)
        {

            FaturaIslemEkranı faturaIslem = new FaturaIslemEkranı();
            this.Hide();
            faturaIslem.Show();
        }

        private void FaturaSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                _billManager.Delete(_billManager.Get(id));
                MessageBox.Show("Silme işlemi başarıyla tamamlandı");
                dataGridView1.DataSource = _billManager.GetList();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }
        }

        private void musteriAdi_TextChanged(object sender, EventArgs e)
        {
            if(musteriAdi.Text != " ")
                dataGridView1.DataSource=_billManager.Search(musteriAdi.Text,gecmisDavalar.Checked,gelecekDavalar.Checked);
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
