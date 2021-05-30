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
using System.Linq;

namespace LawyerDiaryUI
{
    public partial class DavaYonetimAnaEkran : Form
    {
        CaseManager _caseManager = new CaseManager(new CaseDal());
        ClientManager _clientManager = new ClientManager(new ClientDal());

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );


        public DavaYonetimAnaEkran()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

        private void DavaYonetimAnaEkran_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource= _caseManager.GetList();
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            this.Hide();
            mp.Show();
        }

        private void davaGuncelleBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                DavaYonetimIslem yonetimIslem = new DavaYonetimIslem(id);
                yonetimIslem.Show();
                this.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }
           
        }

        private void davaSilBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                _caseManager.Delete(_caseManager.Get(id));
                MessageBox.Show("Silme işlemi başarıyla tamamlandı");
                dataGrid.DataSource = _caseManager.GetList();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }

        }

        private void davaEkleBtn_Click(object sender, EventArgs e)
        {
            DavaYonetimIslem yonetimIslem = new DavaYonetimIslem();
            yonetimIslem.Show();
            this.Hide();
        }

        private void mahkemeIsleriBtn_Click(object sender, EventArgs e)
        {
            MahkemeIslemleri mahkemeIslemleri = new MahkemeIslemleri();
            mahkemeIslemleri.Show();
            this.Hide();
        }

        private void disaAktarBtn_Click(object sender, EventArgs e)
        {

        }

        private void FiltreliArama(object sender, EventArgs e)
        {
            dataGrid.DataSource = _caseManager.FilterWithDate(gecmisDavalar.Checked, gelecekDavalar.Checked);
        }

        private void grupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(musteriAdi.Text!="")
            {
                var id = _clientManager.GetClientIdWithName(musteriAdi.Text);
                if (id != -1)
                    dataGrid.DataSource = _caseManager.GetList().Where(x => x.ClientId == id).ToList();
            }
            else
            {
                MessageBox.Show("Müvekkil adı boş bırakılamaz!");
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

       
    }
}
