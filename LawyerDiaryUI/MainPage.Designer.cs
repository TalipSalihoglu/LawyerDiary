
namespace LawyerDiaryUI
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.kontrolPaneli = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kullanici_hesap_islemleri = new FontAwesome.Sharp.IconButton();
            this.cikis = new FontAwesome.Sharp.IconButton();
            this.muhasebe_yonetimi = new FontAwesome.Sharp.IconButton();
            this.yapilacaklar_listesi = new FontAwesome.Sharp.IconButton();
            this.dava_yonetimi = new FontAwesome.Sharp.IconButton();
            this.randevu_yonetim_ekrani = new FontAwesome.Sharp.IconButton();
            this.müsteri_yonetim_ekrani = new FontAwesome.Sharp.IconButton();
            this.ıconButton5 = new FontAwesome.Sharp.IconButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.kontrolPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.kontrolPaneli);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 580);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 41);
            this.panel2.TabIndex = 2;
            // 
            // kontrolPaneli
            // 
            this.kontrolPaneli.BackColor = System.Drawing.Color.Navy;
            this.kontrolPaneli.Controls.Add(this.pictureBox1);
            this.kontrolPaneli.Controls.Add(this.kullanici_hesap_islemleri);
            this.kontrolPaneli.Controls.Add(this.cikis);
            this.kontrolPaneli.Controls.Add(this.muhasebe_yonetimi);
            this.kontrolPaneli.Controls.Add(this.yapilacaklar_listesi);
            this.kontrolPaneli.Controls.Add(this.dava_yonetimi);
            this.kontrolPaneli.Controls.Add(this.randevu_yonetim_ekrani);
            this.kontrolPaneli.Controls.Add(this.müsteri_yonetim_ekrani);
            this.kontrolPaneli.Location = new System.Drawing.Point(0, 8);
            this.kontrolPaneli.Name = "kontrolPaneli";
            this.kontrolPaneli.Size = new System.Drawing.Size(228, 580);
            this.kontrolPaneli.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LawyerDiaryUI.Properties.Resources.output_onlinepngtools__1_;
            this.pictureBox1.Location = new System.Drawing.Point(20, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kullanici_hesap_islemleri
            // 
            this.kullanici_hesap_islemleri.BackColor = System.Drawing.Color.Navy;
            this.kullanici_hesap_islemleri.FlatAppearance.BorderSize = 0;
            this.kullanici_hesap_islemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kullanici_hesap_islemleri.ForeColor = System.Drawing.Color.Silver;
            this.kullanici_hesap_islemleri.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.kullanici_hesap_islemleri.IconColor = System.Drawing.Color.Silver;
            this.kullanici_hesap_islemleri.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kullanici_hesap_islemleri.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanici_hesap_islemleri.Location = new System.Drawing.Point(-12, 443);
            this.kullanici_hesap_islemleri.Name = "kullanici_hesap_islemleri";
            this.kullanici_hesap_islemleri.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.kullanici_hesap_islemleri.Size = new System.Drawing.Size(228, 60);
            this.kullanici_hesap_islemleri.TabIndex = 7;
            this.kullanici_hesap_islemleri.Text = "Kullanıcı Hesap İşlemleri";
            this.kullanici_hesap_islemleri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kullanici_hesap_islemleri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kullanici_hesap_islemleri.UseVisualStyleBackColor = false;
            this.kullanici_hesap_islemleri.Click += new System.EventHandler(this.kullanici_hesap_islemleri_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Navy;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.ForeColor = System.Drawing.Color.Silver;
            this.cikis.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.cikis.IconColor = System.Drawing.Color.Silver;
            this.cikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.Location = new System.Drawing.Point(-12, 509);
            this.cikis.Name = "cikis";
            this.cikis.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cikis.Size = new System.Drawing.Size(228, 60);
            this.cikis.TabIndex = 6;
            this.cikis.Text = "Çıkış";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // muhasebe_yonetimi
            // 
            this.muhasebe_yonetimi.BackColor = System.Drawing.Color.Navy;
            this.muhasebe_yonetimi.FlatAppearance.BorderSize = 0;
            this.muhasebe_yonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muhasebe_yonetimi.ForeColor = System.Drawing.Color.Silver;
            this.muhasebe_yonetimi.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.muhasebe_yonetimi.IconColor = System.Drawing.Color.Silver;
            this.muhasebe_yonetimi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.muhasebe_yonetimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.muhasebe_yonetimi.Location = new System.Drawing.Point(-12, 311);
            this.muhasebe_yonetimi.Name = "muhasebe_yonetimi";
            this.muhasebe_yonetimi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.muhasebe_yonetimi.Size = new System.Drawing.Size(228, 60);
            this.muhasebe_yonetimi.TabIndex = 5;
            this.muhasebe_yonetimi.Text = "Muhasebe Yönetimi";
            this.muhasebe_yonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.muhasebe_yonetimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.muhasebe_yonetimi.UseVisualStyleBackColor = false;
            this.muhasebe_yonetimi.Click += new System.EventHandler(this.muhasebe_yonetimi_Click);
            // 
            // yapilacaklar_listesi
            // 
            this.yapilacaklar_listesi.BackColor = System.Drawing.Color.Navy;
            this.yapilacaklar_listesi.FlatAppearance.BorderSize = 0;
            this.yapilacaklar_listesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yapilacaklar_listesi.ForeColor = System.Drawing.Color.Silver;
            this.yapilacaklar_listesi.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.yapilacaklar_listesi.IconColor = System.Drawing.Color.Silver;
            this.yapilacaklar_listesi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.yapilacaklar_listesi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yapilacaklar_listesi.Location = new System.Drawing.Point(-12, 377);
            this.yapilacaklar_listesi.Name = "yapilacaklar_listesi";
            this.yapilacaklar_listesi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.yapilacaklar_listesi.Size = new System.Drawing.Size(228, 60);
            this.yapilacaklar_listesi.TabIndex = 4;
            this.yapilacaklar_listesi.Text = "Yapılacaklar Listesi";
            this.yapilacaklar_listesi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yapilacaklar_listesi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.yapilacaklar_listesi.UseVisualStyleBackColor = false;
            this.yapilacaklar_listesi.Click += new System.EventHandler(this.yapilacaklar_listesi_Click);
            // 
            // dava_yonetimi
            // 
            this.dava_yonetimi.BackColor = System.Drawing.Color.Navy;
            this.dava_yonetimi.FlatAppearance.BorderSize = 0;
            this.dava_yonetimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dava_yonetimi.ForeColor = System.Drawing.Color.Silver;
            this.dava_yonetimi.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            this.dava_yonetimi.IconColor = System.Drawing.Color.Silver;
            this.dava_yonetimi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dava_yonetimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dava_yonetimi.Location = new System.Drawing.Point(-12, 245);
            this.dava_yonetimi.Name = "dava_yonetimi";
            this.dava_yonetimi.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.dava_yonetimi.Size = new System.Drawing.Size(228, 60);
            this.dava_yonetimi.TabIndex = 3;
            this.dava_yonetimi.Text = "Dava Yönetimi";
            this.dava_yonetimi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dava_yonetimi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dava_yonetimi.UseVisualStyleBackColor = false;
            this.dava_yonetimi.Click += new System.EventHandler(this.dava_yonetimi_Click);
            // 
            // randevu_yonetim_ekrani
            // 
            this.randevu_yonetim_ekrani.BackColor = System.Drawing.Color.Navy;
            this.randevu_yonetim_ekrani.FlatAppearance.BorderSize = 0;
            this.randevu_yonetim_ekrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randevu_yonetim_ekrani.ForeColor = System.Drawing.Color.Silver;
            this.randevu_yonetim_ekrani.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.randevu_yonetim_ekrani.IconColor = System.Drawing.Color.Silver;
            this.randevu_yonetim_ekrani.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.randevu_yonetim_ekrani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevu_yonetim_ekrani.Location = new System.Drawing.Point(-12, 188);
            this.randevu_yonetim_ekrani.Name = "randevu_yonetim_ekrani";
            this.randevu_yonetim_ekrani.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.randevu_yonetim_ekrani.Size = new System.Drawing.Size(228, 60);
            this.randevu_yonetim_ekrani.TabIndex = 2;
            this.randevu_yonetim_ekrani.Text = "Randevu Yönetimi";
            this.randevu_yonetim_ekrani.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.randevu_yonetim_ekrani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.randevu_yonetim_ekrani.UseVisualStyleBackColor = false;
            this.randevu_yonetim_ekrani.Click += new System.EventHandler(this.randevu_yonetim_ekrani_Click);
            // 
            // müsteri_yonetim_ekrani
            // 
            this.müsteri_yonetim_ekrani.BackColor = System.Drawing.Color.Navy;
            this.müsteri_yonetim_ekrani.FlatAppearance.BorderSize = 0;
            this.müsteri_yonetim_ekrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.müsteri_yonetim_ekrani.ForeColor = System.Drawing.Color.Silver;
            this.müsteri_yonetim_ekrani.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.müsteri_yonetim_ekrani.IconColor = System.Drawing.Color.Silver;
            this.müsteri_yonetim_ekrani.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.müsteri_yonetim_ekrani.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.müsteri_yonetim_ekrani.Location = new System.Drawing.Point(-12, 122);
            this.müsteri_yonetim_ekrani.Name = "müsteri_yonetim_ekrani";
            this.müsteri_yonetim_ekrani.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.müsteri_yonetim_ekrani.Size = new System.Drawing.Size(228, 60);
            this.müsteri_yonetim_ekrani.TabIndex = 1;
            this.müsteri_yonetim_ekrani.Text = "Müşteri Yönetimi";
            this.müsteri_yonetim_ekrani.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.müsteri_yonetim_ekrani.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.müsteri_yonetim_ekrani.UseVisualStyleBackColor = false;
            this.müsteri_yonetim_ekrani.Click += new System.EventHandler(this.müsteri_yonetim_ekrani_Click);
            // 
            // ıconButton5
            // 
            this.ıconButton5.FlatAppearance.BorderSize = 0;
            this.ıconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton5.ForeColor = System.Drawing.Color.Coral;
            this.ıconButton5.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ıconButton5.IconColor = System.Drawing.Color.Orange;
            this.ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton5.Location = new System.Drawing.Point(16, 276);
            this.ıconButton5.Name = "ıconButton5";
            this.ıconButton5.Size = new System.Drawing.Size(220, 60);
            this.ıconButton5.TabIndex = 4;
            this.ıconButton5.Text = "Müşteri Yönetim Ekranı";
            this.ıconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton5.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.Color.Navy;
            this.exitBtn.Location = new System.Drawing.Point(1071, 1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(40, 40);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1114, 582);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "MüsteriYönetim";
            this.Load += new System.EventHandler(this.MüsteriYönetim_Load);
            this.panel1.ResumeLayout(false);
            this.kontrolPaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel kontrolPaneli;
        private FontAwesome.Sharp.IconButton kullanici_hesap_islemleri;
        private FontAwesome.Sharp.IconButton cikis;
        private FontAwesome.Sharp.IconButton muhasebe_yonetimi;
        private FontAwesome.Sharp.IconButton yapilacaklar_listesi;
        private FontAwesome.Sharp.IconButton dava_yonetimi;
        private FontAwesome.Sharp.IconButton randevu_yonetim_ekrani;
        private FontAwesome.Sharp.IconButton müsteri_yonetim_ekrani;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel2;
    }
}