
namespace LawyerDiaryUI
{
    partial class KullaniciIslemleri
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
            this.anaMenuyeDon = new FontAwesome.Sharp.IconButton();
            this.cikis = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.kullaniciIslemleriLabel = new System.Windows.Forms.Label();
            this.hesapBilgileriBox = new System.Windows.Forms.GroupBox();
            this.güncelleBtn = new FontAwesome.Sharp.IconButton();
            this.addressBox = new System.Windows.Forms.RichTextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.isimBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.adresLabel = new System.Windows.Forms.Label();
            this.isimLabel = new System.Windows.Forms.Label();
            this.sifreDegistirmeBox = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new FontAwesome.Sharp.IconButton();
<<<<<<< HEAD
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
=======
            this.yeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.yeniSifre = new System.Windows.Forms.TextBox();
            this.eskiSifre = new System.Windows.Forms.TextBox();
>>>>>>> e49883e9638724b7f15e367d84849c0780381c1d
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.hesapBilgileriBox.SuspendLayout();
            this.sifreDegistirmeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuyeDon);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 755);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // anaMenuyeDon
            // 
            this.anaMenuyeDon.FlatAppearance.BorderSize = 0;
            this.anaMenuyeDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaMenuyeDon.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anaMenuyeDon.ForeColor = System.Drawing.Color.Silver;
            this.anaMenuyeDon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.anaMenuyeDon.IconColor = System.Drawing.Color.Silver;
            this.anaMenuyeDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.anaMenuyeDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuyeDon.Location = new System.Drawing.Point(0, 0);
            this.anaMenuyeDon.Name = "anaMenuyeDon";
            this.anaMenuyeDon.Size = new System.Drawing.Size(165, 92);
            this.anaMenuyeDon.TabIndex = 12;
            this.anaMenuyeDon.Text = "Ana Menü";
            this.anaMenuyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuyeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anaMenuyeDon.UseVisualStyleBackColor = true;
            this.anaMenuyeDon.Click += new System.EventHandler(this.anaMenuyeDon_Click);
            // 
            // cikis
            // 
            this.cikis.BackColor = System.Drawing.Color.Navy;
            this.cikis.FlatAppearance.BorderSize = 0;
            this.cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikis.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cikis.ForeColor = System.Drawing.Color.Silver;
            this.cikis.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.cikis.IconColor = System.Drawing.Color.Silver;
            this.cikis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.Location = new System.Drawing.Point(-3, 99);
            this.cikis.Name = "cikis";
            this.cikis.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.cikis.Size = new System.Drawing.Size(167, 84);
            this.cikis.TabIndex = 13;
            this.cikis.Text = "Çıkış";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.kullaniciIslemleriLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 45);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Navy;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(1362, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 45);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // kullaniciIslemleriLabel
            // 
            this.kullaniciIslemleriLabel.AutoSize = true;
            this.kullaniciIslemleriLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kullaniciIslemleriLabel.ForeColor = System.Drawing.Color.Silver;
            this.kullaniciIslemleriLabel.Location = new System.Drawing.Point(159, 9);
            this.kullaniciIslemleriLabel.Name = "kullaniciIslemleriLabel";
            this.kullaniciIslemleriLabel.Size = new System.Drawing.Size(170, 23);
            this.kullaniciIslemleriLabel.TabIndex = 14;
            this.kullaniciIslemleriLabel.Text = "Kullanıcı İşlemleri";
            // 
            // hesapBilgileriBox
            // 
            this.hesapBilgileriBox.Controls.Add(this.güncelleBtn);
            this.hesapBilgileriBox.Controls.Add(this.addressBox);
            this.hesapBilgileriBox.Controls.Add(this.emailBox);
            this.hesapBilgileriBox.Controls.Add(this.isimBox);
            this.hesapBilgileriBox.Controls.Add(this.emailLabel);
            this.hesapBilgileriBox.Controls.Add(this.adresLabel);
            this.hesapBilgileriBox.Controls.Add(this.isimLabel);
            this.hesapBilgileriBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hesapBilgileriBox.Location = new System.Drawing.Point(234, 102);
            this.hesapBilgileriBox.Name = "hesapBilgileriBox";
            this.hesapBilgileriBox.Size = new System.Drawing.Size(592, 635);
            this.hesapBilgileriBox.TabIndex = 6;
            this.hesapBilgileriBox.TabStop = false;
            this.hesapBilgileriBox.Text = "Hesap İşlemleri";
            // 
            // güncelleBtn
<<<<<<< HEAD
            // 
            this.güncelleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.güncelleBtn.FlatAppearance.BorderSize = 0;
            this.güncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.güncelleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.güncelleBtn.ForeColor = System.Drawing.Color.Navy;
            this.güncelleBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.güncelleBtn.IconColor = System.Drawing.Color.Navy;
            this.güncelleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.güncelleBtn.Location = new System.Drawing.Point(229, 535);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(199, 59);
            this.güncelleBtn.TabIndex = 10;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.güncelleBtn.UseVisualStyleBackColor = false;
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(152, 186);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(378, 204);
            this.addressBox.TabIndex = 2;
            this.addressBox.Text = "";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(152, 450);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(378, 32);
            this.emailBox.TabIndex = 1;
            // 
            // isimBox
            // 
            this.isimBox.Location = new System.Drawing.Point(152, 94);
            this.isimBox.Name = "isimBox";
            this.isimBox.Size = new System.Drawing.Size(378, 32);
            this.isimBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(49, 453);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(74, 23);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-mail:";
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Location = new System.Drawing.Point(49, 186);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(71, 23);
            this.adresLabel.TabIndex = 0;
            this.adresLabel.Text = "Adres:";
            // 
            // isimLabel
            // 
            this.isimLabel.AutoSize = true;
            this.isimLabel.Location = new System.Drawing.Point(49, 98);
            this.isimLabel.Name = "isimLabel";
            this.isimLabel.Size = new System.Drawing.Size(50, 23);
=======
            // 
            this.güncelleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.güncelleBtn.FlatAppearance.BorderSize = 0;
            this.güncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.güncelleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.güncelleBtn.ForeColor = System.Drawing.Color.Navy;
            this.güncelleBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.güncelleBtn.IconColor = System.Drawing.Color.Navy;
            this.güncelleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.güncelleBtn.Location = new System.Drawing.Point(229, 535);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(199, 59);
            this.güncelleBtn.TabIndex = 10;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(152, 186);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(378, 204);
            this.addressBox.TabIndex = 2;
            this.addressBox.Text = "";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(152, 450);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(378, 27);
            this.emailBox.TabIndex = 1;
            // 
            // isimBox
            // 
            this.isimBox.Location = new System.Drawing.Point(152, 94);
            this.isimBox.Name = "isimBox";
            this.isimBox.Size = new System.Drawing.Size(378, 27);
            this.isimBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(49, 453);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(60, 21);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "E-mail:";
            // 
            // adresLabel
            // 
            this.adresLabel.AutoSize = true;
            this.adresLabel.Location = new System.Drawing.Point(49, 186);
            this.adresLabel.Name = "adresLabel";
            this.adresLabel.Size = new System.Drawing.Size(59, 21);
            this.adresLabel.TabIndex = 0;
            this.adresLabel.Text = "Adres:";
            // 
            // isimLabel
            // 
            this.isimLabel.AutoSize = true;
            this.isimLabel.Location = new System.Drawing.Point(49, 98);
            this.isimLabel.Name = "isimLabel";
            this.isimLabel.Size = new System.Drawing.Size(43, 21);
>>>>>>> e49883e9638724b7f15e367d84849c0780381c1d
            this.isimLabel.TabIndex = 0;
            this.isimLabel.Text = "İsim:";
            // 
            // sifreDegistirmeBox
            // 
            this.sifreDegistirmeBox.Controls.Add(this.btnKaydet);
<<<<<<< HEAD
            this.sifreDegistirmeBox.Controls.Add(this.textBox3);
            this.sifreDegistirmeBox.Controls.Add(this.textBox2);
            this.sifreDegistirmeBox.Controls.Add(this.textBox1);
=======
            this.sifreDegistirmeBox.Controls.Add(this.yeniSifreTekrar);
            this.sifreDegistirmeBox.Controls.Add(this.yeniSifre);
            this.sifreDegistirmeBox.Controls.Add(this.eskiSifre);
>>>>>>> e49883e9638724b7f15e367d84849c0780381c1d
            this.sifreDegistirmeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sifreDegistirmeBox.Location = new System.Drawing.Point(895, 102);
            this.sifreDegistirmeBox.Name = "sifreDegistirmeBox";
            this.sifreDegistirmeBox.Size = new System.Drawing.Size(445, 482);
            this.sifreDegistirmeBox.TabIndex = 6;
            this.sifreDegistirmeBox.TabStop = false;
            this.sifreDegistirmeBox.Text = "Şifre Değiştirme";
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.Navy;
            this.btnKaydet.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnKaydet.IconColor = System.Drawing.Color.Navy;
            this.btnKaydet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKaydet.Location = new System.Drawing.Point(149, 377);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(149, 54);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // yeniSifreTekrar
            // 
            this.yeniSifreTekrar.Location = new System.Drawing.Point(24, 278);
            this.yeniSifreTekrar.Name = "yeniSifreTekrar";
            this.yeniSifreTekrar.PlaceholderText = "Yeni Şifre Tekrar";
            this.yeniSifreTekrar.Size = new System.Drawing.Size(378, 27);
            this.yeniSifreTekrar.TabIndex = 1;
            this.yeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // yeniSifre
            // 
            this.yeniSifre.Location = new System.Drawing.Point(24, 186);
            this.yeniSifre.Name = "yeniSifre";
            this.yeniSifre.PlaceholderText = "Yeni Şifre";
            this.yeniSifre.Size = new System.Drawing.Size(378, 27);
            this.yeniSifre.TabIndex = 1;
            this.yeniSifre.UseSystemPasswordChar = true;
            // 
            // eskiSifre
            // 
            this.eskiSifre.Location = new System.Drawing.Point(24, 94);
            this.eskiSifre.Name = "eskiSifre";
            this.eskiSifre.PlaceholderText = "Eski Şifre";
            this.eskiSifre.Size = new System.Drawing.Size(378, 27);
            this.eskiSifre.TabIndex = 1;
            this.eskiSifre.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(24, 278);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Yeni Şifre Tekrar";
            this.textBox3.Size = new System.Drawing.Size(378, 32);
            this.textBox3.TabIndex = 1;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Yeni Şifre";
            this.textBox2.Size = new System.Drawing.Size(378, 32);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Eski Şifre";
            this.textBox1.Size = new System.Drawing.Size(378, 32);
            this.textBox1.TabIndex = 1;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // KullaniciIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.sifreDegistirmeBox);
            this.Controls.Add(this.hesapBilgileriBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KullaniciIslemleri";
            this.Text = "KullaniciIslemleri";
            this.Load += new System.EventHandler(this.KullaniciIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.hesapBilgileriBox.ResumeLayout(false);
            this.hesapBilgileriBox.PerformLayout();
            this.sifreDegistirmeBox.ResumeLayout(false);
            this.sifreDegistirmeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton anaMenuyeDon;
        private FontAwesome.Sharp.IconButton cikis;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label kullaniciIslemleriLabel;
        private System.Windows.Forms.GroupBox hesapBilgileriBox;
        private System.Windows.Forms.RichTextBox addressBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox isimBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label adresLabel;
        private System.Windows.Forms.Label isimLabel;
        private System.Windows.Forms.GroupBox sifreDegistirmeBox;
        private FontAwesome.Sharp.IconButton güncelleBtn;
        private System.Windows.Forms.TextBox yeniSifreTekrar;
        private System.Windows.Forms.TextBox yeniSifre;
        private System.Windows.Forms.TextBox eskiSifre;
        private FontAwesome.Sharp.IconButton btnKaydet;
    }
}