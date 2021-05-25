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
    public partial class ToDoList : Form
    {
        ToDoManager _todoManager = new ToDoManager(new ToDoDal());

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );


        public ToDoList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));
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

     

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void ListeleriGüncelle()
        {
            YapılacaklarListesi.Items.Clear();
            YapılanlarListesi.Items.Clear();

            var list = _todoManager.GetList();
            foreach (var item in list)
            {
                if (item.Status)
                    YapılacaklarListesi.Items.Add(item.Task, false);
                else
                    YapılanlarListesi.Items.Add(item.Task);
            }
        }
        private void ToDoList_Load(object sender, EventArgs e)
        {
            ListeleriGüncelle();
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            if(gorevAdi.Text!="" && gorevAcılaması.Text != "")
            {
                ToDo todo = new ToDo()
                {
                    Description = gorevAcılaması.Text,
                    Task = gorevAdi.Text,
                };
                _todoManager.Add(todo);
                YapılacaklarListesi.Items.Add(todo.Task, false);
                gorevAdi.Text = "";
                gorevAcılaması.Text = "";
            }
            else
            {
                MessageBox.Show("Gerekli alanlar boş bırakılamaz.Ekleme tamamlanamadı!");
            }
        }

        private void YapılacaklarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YapılacaklarListesi.SelectedIndex == -1)
                return;
        
                string TodoTask = YapılacaklarListesi.SelectedItem.ToString();
                GetToDoItem(TodoTask);
            
        }

        ToDo GetToDoItem(string task)
        {
            
            ToDo todo = _todoManager.GetWithTask(task);
            gorevAdi.Text = todo.Task;
            gorevAcılaması.Text = todo.Description;
            return todo;
        }

        private void YapılacaklarListesi_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(e.NewValue==CheckState.Checked)
            {
                string TodoTask = YapılacaklarListesi.SelectedItem.ToString();
                ToDo item =GetToDoItem(TodoTask);
                item.Status = false;
                _todoManager.Update(item);
            }
        }

        private void YapılanlarListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (YapılanlarListesi.SelectedIndex == -1)
                return;

            string TodoTask = YapılanlarListesi.SelectedItem.ToString();
            GetToDoItem(TodoTask);
        }

        private void YapılacaklarListesi_MouseUp(object sender, MouseEventArgs e)
        {
            if(YapılacaklarListesi.CheckedItems.Count>0)
                ListeleriGüncelle();
        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            if (gorevAdi.Text == "" && gorevAcılaması.Text == "")
            {
                MessageBox.Show("Güncellemek istediğiniz kayıdı yapılacaklar listesinden seçiniz");
                return;
            }
            if (YapılacaklarListesi.SelectedItem == null)
            {
                MessageBox.Show("Güncellemek istediğiniz kayıdı yapılacaklar listesinden seçiniz");
                return;
            }
            else
            {
                string TodoTask = YapılacaklarListesi.SelectedItem.ToString();
                ToDo todo = _todoManager.GetWithTask(TodoTask);
                todo.Description = gorevAcılaması.Text;
                todo.Task = gorevAdi.Text;
                _todoManager.Update(todo);
                ListeleriGüncelle();
                MessageBox.Show("Güncelleme işlemi başarıyla tamamlandı");
                
            }
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            if (gorevAdi.Text == "" && gorevAcılaması.Text == "")
            {
                MessageBox.Show("Silmek istediğiniz kayıdı listeden seçiniz");
                return;
            }
            ToDo todo = _todoManager.GetWithTask(gorevAdi.Text);
            if(todo==null)
                MessageBox.Show("Silmek istediğiniz kayıdı listeden seçiniz");
            else
            {
                _todoManager.Delete(todo);
                ListeleriGüncelle();
                MessageBox.Show("Silme işlemi başarıyla tamamlandı");
            }
            gorevAdi.Text = "";
            gorevAcılaması.Text = "";
        }

        private void anaMenuyeDon_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }
    }
}
