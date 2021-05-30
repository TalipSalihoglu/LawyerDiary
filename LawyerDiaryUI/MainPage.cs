using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
namespace LawyerDiaryUI
{
    public partial class MainPage : Form
    {
        //fields
        private IconButton currentBtn;
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

        public MainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //kontrolPaneli.Controls.Add(leftBorderBtn);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
        }


        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn!=null)
            {
                DisableButton(); 
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(192, 192, 192);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(-16, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(244, 159, 28);
            public static Color color2 = Color.FromArgb(244, 130, 28);
            public static Color color3 = Color.FromArgb(204, 159, 58);
            public static Color color4 = Color.FromArgb(24, 159, 28);
            public static Color color5 = Color.FromArgb(244, 19, 28);
            public static Color color6 = Color.FromArgb(244, 59, 28);
            public static Color color7 = Color.FromArgb(44, 159, 28);
        }

        private void DisableButton()
        {
            if(currentBtn!=null)
            {
                currentBtn.BackColor = Color.FromArgb(192, 192, 192);
                currentBtn.ForeColor = Color.Gray;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gray;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }




        private void müsteri_yonetim_ekrani_Click(object sender, EventArgs e)
        {
            MusteriYonetimEkrani musteriYonetimEkrani = new MusteriYonetimEkrani();
            ActivateButton(sender, RGBColors.color1);
            this.Hide();
            musteriYonetimEkrani.Show();
        }

        private void muhasebe_yonetimi_Click(object sender, EventArgs e)
        {
            FaturaAnaEkran faturaAnaEkran = new FaturaAnaEkran();
            ActivateButton(sender, RGBColors.color4);
            this.Hide();
            faturaAnaEkran.Show();

        }

        private void randevu_yonetim_ekrani_Click(object sender, EventArgs e)
        {
            RandevuYonetim randevuYonetim = new RandevuYonetim();
            ActivateButton(sender, RGBColors.color2);
            randevuYonetim.Show();
            this.Hide();
            

        }

        private void dava_yonetimi_Click(object sender, EventArgs e)
        {
            DavaYonetimAnaEkran DavaYonetim = new DavaYonetimAnaEkran();
            ActivateButton(sender, RGBColors.color3);
            DavaYonetim.Show();
            this.Hide();

        }

        private void yapilacaklar_listesi_Click(object sender, EventArgs e)
        {
            ToDoList todo = new ToDoList();
            ActivateButton(sender, RGBColors.color5);
            todo.Show();
            this.Hide();
        }

        private void kullanici_hesap_islemleri_Click(object sender, EventArgs e)
        {
            KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
            ActivateButton(sender, RGBColors.color6);
            kullaniciIslemleri.Show();
            this.Hide();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);
            Application.Exit();

        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        //necessary for dragging by clicking on the upper panel.
        bool mouseDownEvent;
        private Point offset; 
        private void mouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDownEvent = true;
        }

        private void mouseMovementEvent(object sender, MouseEventArgs e)
        {
            if  (mouseDownEvent == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void mouseUpEvent(object sender, MouseEventArgs e)
        {
            mouseDownEvent = false;
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
