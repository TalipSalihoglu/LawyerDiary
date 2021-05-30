using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // köşeleri raduislamak için kullanılır.
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;

namespace LawyerDiaryUI
{
    public partial class Giris : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //.net'te bir dll üzerinden bir metodu getirmek için kullanılan attribute.


        private static extern IntPtr CreateRoundRectRgn( //extern metodun dışarıdan implemente edildiğini gösterir, yönetilemeyen kod için çağırılır.

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );


        public Giris()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
            //region köşeleri boyamak için kullanılır./
            //

        }

        
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        internal static Form cs()
        {
            throw new NotImplementedException();
        }

        private void nameLogin_Click(object sender, EventArgs e)
        {
            nameLogin.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel6.BackColor = SystemColors.Control;
            passwordLogin.BackColor = SystemColors.Control;

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


        private void button2_Click(object sender, EventArgs e)
        {
            LawyerManager manager = new LawyerManager(new LawyerDal());
            int result =manager.Login(nameLogin.Text,passwordLogin.Text);
            if (result == -1)
            {
                MessageBox.Show("Kullanıcı adi veya şifre hatalı");
                nameLogin.Text = "";
                passwordLogin.Text = "";
            }
               
            else
            {
                this.Hide();
                MainPage page = new MainPage();
                page.Show();
            }

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
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
 


    }
}

