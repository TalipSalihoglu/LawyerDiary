using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class RandevuYonetim : Form
    {
        AppointmentManager _manager = new AppointmentManager(new AppointmentDal());
        public RandevuYonetim()
        {
            InitializeComponent();
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
                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                _manager.Delete(_manager.Get(id));
                MessageBox.Show("Silme işlemi başarıyla tamamlandı");
                dataGridView1.DataSource = _manager.GetList();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
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
    }
}
