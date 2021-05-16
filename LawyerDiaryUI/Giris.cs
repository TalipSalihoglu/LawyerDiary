using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
 
namespace LawyerDiaryUI
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal static Form cs()
        {
            throw new NotImplementedException();
        }

        private void nameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLogin_Click(object sender, EventArgs e)
        {
            nameLogin.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel6.BackColor = SystemColors.Control;
            passwordLogin.BackColor = SystemColors.Control;

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Click(object sender, EventArgs e)
        {

        }

        private void passwordLogin_Click(object sender, EventArgs e)
        {
            passwordLogin.BackColor = Color.White;
            panel6.BackColor = Color.White;
            nameLogin.BackColor = SystemColors.Control;
            panel7.BackColor = SystemColors.Control;
        }

        private void passwordLogo_MouseDown(object sender, MouseEventArgs e)
        {
            passwordLogin.UseSystemPasswordChar = false;
        }

        private void passwordLogo_MouseUp(object sender, MouseEventArgs e)
        {
            passwordLogin.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

