using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class RandevuYonetim : Form
    {
        AppointmentManager _manager = new AppointmentManager(new AppointmentDal());
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //.net'te bir dll üzerinden bir metodu getirmek için kullanılan attribute.

        private static extern IntPtr CreateRoundRectRgn( //extern metodun dışarıdan implemente edildiğini gösterir, yönetilemeyen kod için çağırılır.

           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse

           );
        public RandevuYonetim()
        {
            InitializeComponent();
            dataGridViewSettings();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }


        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    

        private void RandevuYonetim_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = _manager.GetList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anaMenuyeDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage main = new MainPage();
            main.Show();
        }

        private void musteriAdi_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = _manager.Search(subject.Text, gecmisRandevular.Checked,gelecekRandevular.Checked);
         

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            RandevuIslemleri randevuIslemleri = new RandevuIslemleri();
            randevuIslemleri.Show();
            this.Hide();
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                RandevuIslemleri randevu = new RandevuIslemleri(id);
                randevu.Show();
                this.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                _manager.Delete(_manager.Get(id));
                MessageBox.Show("Silme işlemi başarıyla tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = _manager.GetList();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
