using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LawyerDiaryUI
{
    public partial class MusteriYonetimEkrani : Form
    {
        ClientManager Manager = new ClientManager(new ClientDal());
        public MusteriYonetimEkrani()
        {
            InitializeComponent();
        }

    
        private void MusteriYonetimEkrani_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= Manager.GetList();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            this.Hide();
            main.Show();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void musteriAdi_TextChanged(object sender, EventArgs e)
        {
            string aranan = musteriAdi.Text.ToLower();
            var degerler = Manager.Search(aranan);
            dataGridView1.DataSource = degerler;
        }


       
        private void Ekle_Click(object sender, EventArgs e)
        {
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Show();
            this.Hide();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                MusteriManager musteriManager = new MusteriManager(id);
                musteriManager.Show();
                this.Hide();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen güncellenecek sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }
            
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Manager.Delete(Manager.Get(id));
                MessageBox.Show("Silme işlemi başarıyla tamamlandı");
                dataGridView1.DataSource = Manager.GetList();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lütfen silmek istediğiniz sıranın tümünün seçili olduğundan emin olun\n\n\n" + E.Message);
            }
            
        }
    }
}
