
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class Form1 : Form
    {
        public int Userid;
        public Form1(int id)
        {
            InitializeComponent();
             Userid= id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager(new ClientDal());
            Client cl = new Client() { Address = "dd", Email = "dd@dd.com", ClientName = "d", LawyerId=1,Status=true};
            clientManager.Add(cl);
            MessageBox.Show("ekleme tamamlandı");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager(new ClientDal());
            Client cl = clientManager.Get(6);
            clientManager.Delete(cl);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientManager clientManager = new ClientManager(new ClientDal());
            var clientList= clientManager.GetList();
            foreach (var item in clientList)
            {
                string cl = item.ClientId + "       " + item.ClientName + "         " + item.Email;
                listBox1.Items.Add(cl);
            }
            label1.Text = Userid.ToString();
       }

        private void button4_Click(object sender, EventArgs e)
        {
            LawyerManager lm = new LawyerManager(new LawyerDal());
            //Lawyer p = new Lawyer()
            //{
            //    Name = "Burak",
            //    Address = "Görükle/Bursa",
            //    Email = "burak@hotmail.com",
            //    Password = "121212",
            //};
            //lm.Add(p);
            var l=lm.Get(2);
            l.Email = "burakkk@hotmail.com";
            lm.Update(l);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var date1 = new DateTime(2008, 3, 1, 7, 0, 0);
            // Displays 01/03/2008 07:00:00
            CaseManger cm = new CaseManger(new CaseDal());
            Case c = new Case()
            {
                ClientId = 4,
                Topic = "boşanma",
                Description = "boşanma davası",
                Status = true,
                CaseDate = new DateTime(2021, 4, 5, 15, 30, 0),
                CourtId = 1,
                LawyerId=2,
            };
            cm.Add(c);
           
        }
    }
}
