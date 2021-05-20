using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace LawyerDiaryUI
{
    public partial class DavaYonetimAnaEkran : Form
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


        public DavaYonetimAnaEkran()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

        private void DavaYonetimAnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

         
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
