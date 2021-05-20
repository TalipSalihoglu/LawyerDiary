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

 
    public partial class MahkemeIslemleri : Form
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
    }
}
