
namespace LawyerDiaryUI
{
    partial class MahkemeIslemleri
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.musteriyonetimLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anaMenuBtn = new FontAwesome.Sharp.IconButton();
            this.cikisBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.saveBtn = new FontAwesome.Sharp.IconButton();
            this.hakimAdı = new System.Windows.Forms.TextBox();
            this.mahkemeNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mahkemeSilBtn = new FontAwesome.Sharp.IconButton();
            this.mahkemeGuncelleBtn = new FontAwesome.Sharp.IconButton();
            this.GüncelleHakimAdi = new System.Windows.Forms.TextBox();
            this.GüncelleMahkemeNo = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.musteriyonetimLabel);
            this.panel3.Controls.Add(this.exitBtn);
            this.panel3.Location = new System.Drawing.Point(128, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1274, 39);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // musteriyonetimLabel
            // 
            this.musteriyonetimLabel.AutoSize = true;
            this.musteriyonetimLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.musteriyonetimLabel.ForeColor = System.Drawing.Color.Silver;
            this.musteriyonetimLabel.Location = new System.Drawing.Point(1, 9);
            this.musteriyonetimLabel.Name = "musteriyonetimLabel";
            this.musteriyonetimLabel.Size = new System.Drawing.Size(226, 27);
            this.musteriyonetimLabel.TabIndex = 15;
            this.musteriyonetimLabel.Text = "Mahkeme İşlemleri";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Navy;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(1235, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuBtn);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 800);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // anaMenuBtn
            // 
            this.anaMenuBtn.FlatAppearance.BorderSize = 0;
            this.anaMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaMenuBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anaMenuBtn.ForeColor = System.Drawing.Color.Silver;
            this.anaMenuBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.anaMenuBtn.IconColor = System.Drawing.Color.Silver;
            this.anaMenuBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.anaMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuBtn.Location = new System.Drawing.Point(0, 45);
            this.anaMenuBtn.Name = "anaMenuBtn";
            this.anaMenuBtn.Size = new System.Drawing.Size(136, 85);
            this.anaMenuBtn.TabIndex = 12;
            this.anaMenuBtn.Text = "Ana Menü";
            this.anaMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anaMenuBtn.UseVisualStyleBackColor = true;
            this.anaMenuBtn.Click += new System.EventHandler(this.anaMenuBtn_Click);
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.Navy;
            this.cikisBtn.FlatAppearance.BorderSize = 0;
            this.cikisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cikisBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cikisBtn.ForeColor = System.Drawing.Color.Silver;
            this.cikisBtn.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.cikisBtn.IconColor = System.Drawing.Color.Silver;
            this.cikisBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cikisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikisBtn.Location = new System.Drawing.Point(0, 136);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cikisBtn.Size = new System.Drawing.Size(136, 85);
            this.cikisBtn.TabIndex = 13;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikisBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Location = new System.Drawing.Point(157, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 47);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(451, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(633, 244);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(508, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Aramak istediğiniz mahkemenin numarasını girin";
            this.textBox1.Size = new System.Drawing.Size(491, 32);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ıconButton3);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.hakimAdı);
            this.groupBox1.Controls.Add(this.mahkemeNo);
            this.groupBox1.Location = new System.Drawing.Point(229, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 249);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Mahkeme Ekle";
            // 
            // ıconButton3
            // 
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ıconButton3.ForeColor = System.Drawing.Color.Navy;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.ıconButton3.IconColor = System.Drawing.Color.Navy;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.Location = new System.Drawing.Point(258, 173);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(146, 42);
            this.ıconButton3.TabIndex = 10;
            this.ıconButton3.Text = "Vazgeç";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.Navy;
            this.saveBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.saveBtn.IconColor = System.Drawing.Color.Navy;
            this.saveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveBtn.Location = new System.Drawing.Point(79, 173);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(149, 42);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // hakimAdı
            // 
            this.hakimAdı.Location = new System.Drawing.Point(79, 105);
            this.hakimAdı.Name = "hakimAdı";
            this.hakimAdı.PlaceholderText = "Hakim İsmi";
            this.hakimAdı.Size = new System.Drawing.Size(325, 32);
            this.hakimAdı.TabIndex = 0;
            // 
            // mahkemeNo
            // 
            this.mahkemeNo.Location = new System.Drawing.Point(79, 40);
            this.mahkemeNo.Name = "mahkemeNo";
            this.mahkemeNo.PlaceholderText = "Mahkeme No";
            this.mahkemeNo.Size = new System.Drawing.Size(325, 32);
            this.mahkemeNo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mahkemeSilBtn);
            this.groupBox2.Controls.Add(this.mahkemeGuncelleBtn);
            this.groupBox2.Controls.Add(this.GüncelleHakimAdi);
            this.groupBox2.Controls.Add(this.GüncelleMahkemeNo);
            this.groupBox2.Location = new System.Drawing.Point(823, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 249);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mahkeme Güncelle";
            // 
            // mahkemeSilBtn
            // 
            this.mahkemeSilBtn.FlatAppearance.BorderSize = 0;
            this.mahkemeSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mahkemeSilBtn.ForeColor = System.Drawing.Color.Navy;
            this.mahkemeSilBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.mahkemeSilBtn.IconColor = System.Drawing.Color.Navy;
            this.mahkemeSilBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mahkemeSilBtn.Location = new System.Drawing.Point(264, 168);
            this.mahkemeSilBtn.Name = "mahkemeSilBtn";
            this.mahkemeSilBtn.Size = new System.Drawing.Size(146, 42);
            this.mahkemeSilBtn.TabIndex = 11;
            this.mahkemeSilBtn.Text = "Sil";
            this.mahkemeSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mahkemeSilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mahkemeSilBtn.UseVisualStyleBackColor = true;
            this.mahkemeSilBtn.Click += new System.EventHandler(this.mahkemeSilBtn_Click);
            // 
            // mahkemeGuncelleBtn
            // 
            this.mahkemeGuncelleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.mahkemeGuncelleBtn.FlatAppearance.BorderSize = 0;
            this.mahkemeGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mahkemeGuncelleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mahkemeGuncelleBtn.ForeColor = System.Drawing.Color.Navy;
            this.mahkemeGuncelleBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.mahkemeGuncelleBtn.IconColor = System.Drawing.Color.Navy;
            this.mahkemeGuncelleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mahkemeGuncelleBtn.Location = new System.Drawing.Point(74, 168);
            this.mahkemeGuncelleBtn.Name = "mahkemeGuncelleBtn";
            this.mahkemeGuncelleBtn.Size = new System.Drawing.Size(184, 52);
            this.mahkemeGuncelleBtn.TabIndex = 7;
            this.mahkemeGuncelleBtn.Text = "Güncelle";
            this.mahkemeGuncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mahkemeGuncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mahkemeGuncelleBtn.UseVisualStyleBackColor = false;
            this.mahkemeGuncelleBtn.Click += new System.EventHandler(this.mahkemeGuncelleBtn_Click);
            // 
            // GüncelleHakimAdi
            // 
            this.GüncelleHakimAdi.Location = new System.Drawing.Point(74, 105);
            this.GüncelleHakimAdi.Name = "GüncelleHakimAdi";
            this.GüncelleHakimAdi.PlaceholderText = "Hakim İsmi";
            this.GüncelleHakimAdi.Size = new System.Drawing.Size(325, 32);
            this.GüncelleHakimAdi.TabIndex = 0;
            // 
            // GüncelleMahkemeNo
            // 
            this.GüncelleMahkemeNo.Location = new System.Drawing.Point(74, 40);
            this.GüncelleMahkemeNo.Name = "GüncelleMahkemeNo";
            this.GüncelleMahkemeNo.PlaceholderText = "Mahkeme No";
            this.GüncelleMahkemeNo.Size = new System.Drawing.Size(325, 32);
            this.GüncelleMahkemeNo.TabIndex = 0;
            // 
            // MahkemeIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MahkemeIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MahkemeIslemleri";
            this.Load += new System.EventHandler(this.MahkemeIslemleri_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton anaMenuBtn;
        private FontAwesome.Sharp.IconButton cikisBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label musteriyonetimLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hakimAdı;
        private System.Windows.Forms.TextBox mahkemeNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox GüncelleHakimAdi;
        private System.Windows.Forms.TextBox GüncelleMahkemeNo;
        private FontAwesome.Sharp.IconButton saveBtn;
        private FontAwesome.Sharp.IconButton mahkemeGuncelleBtn;
        private FontAwesome.Sharp.IconButton mahkemeSilBtn;
        private FontAwesome.Sharp.IconButton ıconButton3;
    }
}