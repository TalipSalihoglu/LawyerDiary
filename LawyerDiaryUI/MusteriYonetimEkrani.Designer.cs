
namespace LawyerDiaryUI
{
    partial class MusteriYonetimEkrani
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
            this.solPanel = new System.Windows.Forms.Panel();
            this.cikis = new FontAwesome.Sharp.IconButton();
            this.anaMenuyeDon = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.musteriyonetimLabel = new System.Windows.Forms.Label();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.Guncelle = new FontAwesome.Sharp.IconButton();
            this.Sil = new FontAwesome.Sharp.IconButton();
            this.Ekle = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.solPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // solPanel
            // 
            this.solPanel.BackColor = System.Drawing.Color.Navy;
            this.solPanel.Controls.Add(this.cikis);
            this.solPanel.Controls.Add(this.anaMenuyeDon);
            this.solPanel.Location = new System.Drawing.Point(0, 0);
            this.solPanel.Name = "solPanel";
            this.solPanel.Size = new System.Drawing.Size(136, 581);
            this.solPanel.TabIndex = 0;
            this.solPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.solPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.solPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
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
            this.cikis.Location = new System.Drawing.Point(0, 124);
            this.cikis.Name = "cikis";
            this.cikis.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cikis.Size = new System.Drawing.Size(142, 81);
            this.cikis.TabIndex = 9;
            this.cikis.Text = "Çıkış";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // anaMenuyeDon
            // 
            this.anaMenuyeDon.FlatAppearance.BorderSize = 0;
            this.anaMenuyeDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anaMenuyeDon.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.anaMenuyeDon.ForeColor = System.Drawing.Color.Silver;
            this.anaMenuyeDon.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.anaMenuyeDon.IconColor = System.Drawing.Color.Silver;
            this.anaMenuyeDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.anaMenuyeDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuyeDon.Location = new System.Drawing.Point(0, 39);
            this.anaMenuyeDon.Name = "anaMenuyeDon";
            this.anaMenuyeDon.Size = new System.Drawing.Size(136, 79);
            this.anaMenuyeDon.TabIndex = 8;
            this.anaMenuyeDon.Text = "Ana Menü";
            this.anaMenuyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuyeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anaMenuyeDon.UseVisualStyleBackColor = true;
            this.anaMenuyeDon.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.musteriyonetimLabel);
            this.panel1.Location = new System.Drawing.Point(133, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 39);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1009, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // musteriyonetimLabel
            // 
            this.musteriyonetimLabel.AutoSize = true;
            this.musteriyonetimLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.musteriyonetimLabel.ForeColor = System.Drawing.Color.Silver;
            this.musteriyonetimLabel.Location = new System.Drawing.Point(0, 9);
            this.musteriyonetimLabel.Name = "musteriyonetimLabel";
            this.musteriyonetimLabel.Size = new System.Drawing.Size(197, 27);
            this.musteriyonetimLabel.TabIndex = 8;
            this.musteriyonetimLabel.Text = "Müşteri Yönetimi";
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(440, 118);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.Size = new System.Drawing.Size(212, 28);
            this.musteriAdi.TabIndex = 2;
            this.musteriAdi.TextChanged += new System.EventHandler(this.musteriAdi_TextChanged);
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.Color.Navy;
            this.Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guncelle.ForeColor = System.Drawing.Color.White;
            this.Guncelle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Guncelle.IconColor = System.Drawing.Color.Navy;
            this.Guncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Guncelle.Location = new System.Drawing.Point(217, 268);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(435, 34);
            this.Guncelle.TabIndex = 3;
            this.Guncelle.Text = "Müşteriyi Güncelle";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.Navy;
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.ForeColor = System.Drawing.Color.White;
            this.Sil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Sil.IconColor = System.Drawing.Color.Navy;
            this.Sil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Sil.Location = new System.Drawing.Point(217, 325);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(435, 34);
            this.Sil.TabIndex = 4;
            this.Sil.Text = "Müşteriyi Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.Navy;
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle.ForeColor = System.Drawing.Color.White;
            this.Ekle.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ekle.IconColor = System.Drawing.Color.Navy;
            this.Ekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ekle.Location = new System.Drawing.Point(217, 519);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(435, 34);
            this.Ekle.TabIndex = 5;
            this.Ekle.Text = "Yeni Müşteri Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(217, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aradığınız Müşterinin Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(729, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(417, 486);
            this.dataGridView1.TabIndex = 7;
            // 
            // MusteriYonetimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 578);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.musteriAdi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.solPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriYonetimEkrani";
            this.Text = "MuvekkilYonetimEkranı";
            this.Load += new System.EventHandler(this.MusteriYonetimEkrani_Load);
            this.solPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel solPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox musteriAdi;
        private FontAwesome.Sharp.IconButton Guncelle;
        private FontAwesome.Sharp.IconButton Sil;
        private FontAwesome.Sharp.IconButton Ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton anaMenuyeDon;
        private FontAwesome.Sharp.IconButton cikis;
        private System.Windows.Forms.Label musteriyonetimLabel;
        private System.Windows.Forms.Button button3;
    }
}