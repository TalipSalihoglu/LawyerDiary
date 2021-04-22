using System;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Form1 form1 ;
        private void button1_Click(object sender, EventArgs e)
        {
            LawyerManager lawyerManager = new LawyerManager(new LawyerDal());
            int result = lawyerManager.Login(textBox1.Text, textBox2.Text);
            if (result == -1)
                MessageBox.Show("Hatali giris");
            else
            {
                form1 = new Form1(result);
                this.Hide();
                form1.Show();
            }
                
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
