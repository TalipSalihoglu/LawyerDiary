using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices; // köşeleri raduislamak için kullanılır.

namespace LawyerDiaryUI
{
    public partial class RandevuIslemleri : Form
    {
        AppointmentManager _manager = new AppointmentManager(new AppointmentDal());
        ClientManager _clientManager = new ClientManager(new ClientDal());
        Appointment appointment = null;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //.net'te bir dll üzerinden bir metodu getirmek için kullanılan attribute.

        private static extern IntPtr CreateRoundRectRgn( //extern metodun dışarıdan implemente edildiğini gösterir, yönetilemeyen kod için çağırılır.

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );

        public RandevuIslemleri()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
            //region köşeleri boyamak için kullanılır./
            //
        }

        public RandevuIslemleri(int id)
        {
            InitializeComponent();
            appointment= _manager.Get(id);
        }

        private void RandevuIslemleri_Load_1(object sender, EventArgs e)
        {
            var list = _clientManager.GetList();
            foreach (var i in list)
                CB_musteriIdleri.Items.Add(i.ClientName);

            if (appointment != null)
            {
                RandevuKonu.Text = appointment.Subject;
                textBoxAcıklama.Text = appointment.Description;  
                textBoxTarih.Text = appointment.AppointmentDate.ToString();
                CB_musteriIdleri.SelectedItem = (_clientManager.Get(appointment.ClientId).ClientName);
            }

        }
        private void kaydetBtn_Click(object sender, EventArgs e)
        {
            if (RandevuKonu.Text == "" || textBoxAcıklama.Text == ""|| textBoxTarih.Text=="")
            { 
                MessageBox.Show("Bu alan boş olamaz");
                return;
            }
            if (appointment!=null)
            {
                appointment.Subject= RandevuKonu.Text;
                appointment.Description=textBoxAcıklama.Text ;
                appointment.AppointmentDate = DateTime.Parse(textBoxTarih.Text);
                appointment.ClientId= _clientManager.GetClientIdWithName(CB_musteriIdleri.SelectedItem.ToString());
                _manager.Update(appointment); 
            }
            else
            {
                Appointment newAppointment = new Appointment()
                {
                    Subject = RandevuKonu.Text,
                    Description = textBoxAcıklama.Text,
                    AppointmentDate = DateTime.Parse(textBoxTarih.Text),
                    ClientId = _clientManager.GetClientIdWithName(CB_musteriIdleri.SelectedItem.ToString())
            };
                _manager.Add(newAppointment);
            }
            RandevuYonetim ry = new RandevuYonetim();
            this.Hide();
            ry.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void anaMenuyeDon_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void backwardBtn_Click(object sender, EventArgs e)
        {
            RandevuYonetim ry = new RandevuYonetim();
            this.Hide();
            ry.Show();
        }

      

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem iptal edildi!");
            RandevuYonetim ry = new RandevuYonetim();
            this.Hide();
            ry.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
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
