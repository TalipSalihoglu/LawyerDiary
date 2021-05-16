using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace LawyerDiaryUI
{
    public partial class MainPage : Form
    {
        //fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;


        public MainPage()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            kontrolPaneli.Controls.Add(leftBorderBtn);
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


        private void MüsteriYönetim_Load(object sender, EventArgs e)
        {

        }

        private void müsteri_yonetim_ekrani_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void muhasebe_yonetimi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);

        }

        private void randevu_yonetim_ekrani_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);

        }

        private void dava_yonetimi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);

        }

        private void yapilacaklar_listesi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);

        }

        private void kullanici_hesap_islemleri_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color7);

        }

        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
