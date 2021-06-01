using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // köşeleri raduislamak için kullanılır.

namespace LawyerDiaryUI
{
    
    public partial class MusteriYonetimEkrani : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //.net'te bir dll üzerinden bir metodu getirmek için kullanılan attribute.
        private static extern IntPtr CreateRoundRectRgn( //extern metodun dışarıdan implemente edildiğini gösterir, yönetilemeyen kod için çağırılır.

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        ClientManager Manager = new ClientManager(new ClientDal());
        public MusteriYonetimEkrani()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
            //region köşeleri boyamak için kullanılır./
            dataGridViewSettings();

        }


        private void MusteriYonetimEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= Manager.GetList();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void musteriAdi_TextChanged(object sender, EventArgs e)
        {
            if(musteriAdi.Text!="")
            {
                string aranan = musteriAdi.Text.ToLower();
                var degerler = Manager.Search(aranan);
                dataGridView1.DataSource = degerler;
            }
            else
            {
                dataGridView1.DataSource = Manager.GetList();
            }
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
        public void dataGridViewSettings() 
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void Ekle_Click_1(object sender, EventArgs e)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Show();
            this.Hide();
        }

        private void Sil_Click_1(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Manager.Delete(Manager.Get(id));
                MessageBox.Show("Silme işlemi başarıyla tamamlandı");
                dataGridView1.DataSource = Manager.GetList();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen silinecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Guncelle_Click_1(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                MusteriManager musteriManager = new MusteriManager(id);
                musteriManager.Show();
                this.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
