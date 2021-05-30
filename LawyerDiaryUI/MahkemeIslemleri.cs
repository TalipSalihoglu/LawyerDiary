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

 
    public partial class MahkemeIslemleri : Form
    {
        CourtManager _courtManager = new CourtManager(new CourtDal());

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] 
        private static extern IntPtr CreateRoundRectRgn(

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );


        public MahkemeIslemleri()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

        //public MahkemeIslemleri() => InitializeComponent();

        private void button3_Click(object sender, EventArgs e)
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
            mp.Show();
            this.Hide();
        }

        private void MahkemeIslemleri_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _courtManager.GetList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                var list= _courtManager.Search(textBox1.Text);
                dataGridView1.DataSource = list;
            }else
            {
                dataGridView1.DataSource = _courtManager.GetList();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if(mahkemeNo.Text!="" && hakimAdı.Text!="")
            {
                var result = _courtManager.GetIdWithCourtNo(int.Parse(mahkemeNo.Text));
                if(result!=-1)
                {
                    MessageBox.Show("Bu mahkeme no ile bir kayıt zaten var!\n Lütfen farklı bir No giriniz!!");
                }
                else
                {
                    Court c = new Court()
                    {
                        CourtNumber = int.Parse(mahkemeNo.Text),
                        JudgeName = hakimAdı.Text,
                    };
                    _courtManager.Add(c);
                    MessageBox.Show("İşlem başarıyla tamamlandı!");
                    dataGridView1.DataSource = _courtManager.GetList();
                }
            }
            else 
            {
                MessageBox.Show("Mahkeme No ve Hakim Adı boş bırakılamaz!!");
            }
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            mahkemeNo.Text = "";
            hakimAdı.Text = "";
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                GüncelleMahkemeNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                GüncelleHakimAdi.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            catch (Exception E)
            {

                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }
            
        }

        private void mahkemeGuncelleBtn_Click(object sender, EventArgs e)
        {
            if (GüncelleHakimAdi.Text == "" && GüncelleMahkemeNo.Text == "")
            {
                MessageBox.Show("Mahkeme No ve Hakim Adı boş bırakılamaz!!");
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    var court=_courtManager.Get(id);
                    court.CourtNumber = int.Parse(GüncelleMahkemeNo.Text);
                    court.JudgeName = GüncelleHakimAdi.Text;
                    _courtManager.Update(court);
                    MessageBox.Show("Güncellem işlemi başarıyla tamamlandı");
                    dataGridView1.DataSource = _courtManager.GetList();
                }
                catch (Exception E)
                {

                    MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
                }
            }
        }

        private void mahkemeSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                _courtManager.Delete(_courtManager.Get(id));
                MessageBox.Show("Silme işlemi başarıyla tamamlandı");
                dataGridView1.DataSource = _courtManager.GetList();
            }
            catch (Exception E)
            {

                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
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
