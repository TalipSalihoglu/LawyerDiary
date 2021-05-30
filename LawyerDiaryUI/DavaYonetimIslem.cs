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
    public partial class DavaYonetimIslem : Form
    {
        CaseManager _caseManager = new CaseManager(new CaseDal());
        ClientManager _clientManager= new ClientManager(new ClientDal());
        CourtManager _courtManager= new CourtManager(new CourtDal());
        Case dava = null;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

               );


        public DavaYonetimIslem()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        public DavaYonetimIslem(int id)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            dava = _caseManager.Get(id);

        }


        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DavaYonetimIslem_Load(object sender, EventArgs e)
        {
            var client_list = _clientManager.GetList();
            foreach (var item in client_list)
            {
                dava_musteriAdi.Items.Add(item.ClientName);
            }
            var court_list = _courtManager.GetList();
            foreach (var item in court_list)
            {
                mahkeme_No.Items.Add(item.CourtNumber);
            }
            Hakim_Adı.Enabled = false;
            if (dava!=null)
            {
                davaKonu.Text = dava.Topic;
                davaAcıklama.Text = dava.Description;
                davaTarih.Value = dava.CaseDate;
                dava_musteriAdi.SelectedItem = _clientManager.Get(dava.ClientId).ClientName.ToString();
                Court c = _courtManager.Get(dava.CourtId);
                mahkeme_No.SelectedItem = c.CourtNumber;
                Hakim_Adı.Text = c.JudgeName;
            }
        }

        private void anaMenuBtn_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void DavaBackwardBtn_Click(object sender, EventArgs e)
        {
            DavaYonetimAnaEkran davaAnaEkran = new DavaYonetimAnaEkran();
            davaAnaEkran.Show();
            this.Hide();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(dava!=null)
            {
                dava.Topic = davaKonu.Text;
                dava.Description = davaAcıklama.Text;
                dava.CaseDate=davaTarih.Value;
                dava.ClientId = _clientManager.GetClientIdWithName(dava_musteriAdi.SelectedItem.ToString());
                int c_No = int.Parse(mahkeme_No.SelectedItem.ToString());
                dava.CourtId = _courtManager.GetIdWithCourtNo(c_No);
                _caseManager.Update(dava);
            }
            else
            {
                Case newCase = new Case()
                {

                    Topic = davaKonu.Text,
                    Description = davaAcıklama.Text,
                    CaseDate = davaTarih.Value,
                    ClientId = _clientManager.GetClientIdWithName(dava_musteriAdi.SelectedItem.ToString()),
                    CourtId= _courtManager.GetIdWithCourtNo(int.Parse(mahkeme_No.SelectedItem.ToString()))
                };
                _caseManager.Add(newCase);
            }
            MessageBox.Show("İşlem başarıyla tamamlandı!!");
            DavaYonetimAnaEkran davaAnaEkran = new DavaYonetimAnaEkran();
            davaAnaEkran.Show();
            this.Hide();
        }

        private void mahkeme_No_SelectedIndexChanged(object sender, EventArgs e)
        {

            int courtNo =int.Parse(mahkeme_No.SelectedItem.ToString());
            Hakim_Adı.Text = _courtManager.GetJudgeWithCourtNo(courtNo);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void filtreliAramaBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
