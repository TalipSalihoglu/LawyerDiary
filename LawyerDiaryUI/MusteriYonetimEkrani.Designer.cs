
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.solPanel = new System.Windows.Forms.Panel();
            this.cikis = new FontAwesome.Sharp.IconButton();
            this.anaMenuyeDon = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.musteriyonetimLabel = new System.Windows.Forms.Label();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Ekle = new FontAwesome.Sharp.IconButton();
            this.Sil = new FontAwesome.Sharp.IconButton();
            this.Guncelle = new FontAwesome.Sharp.IconButton();
            this.solPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.button3.Location = new System.Drawing.Point(986, -1);
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
            this.musteriyonetimLabel.Size = new System.Drawing.Size(161, 23);
            this.musteriyonetimLabel.TabIndex = 8;
            this.musteriyonetimLabel.Text = "Müşteri Yönetimi";
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(656, 423);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.Size = new System.Drawing.Size(212, 24);
            this.musteriAdi.TabIndex = 2;
            this.musteriAdi.TextChanged += new System.EventHandler(this.musteriAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(433, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Aradığınız Müşterinin Adı:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(887, 284);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(239, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 284);
            this.panel2.TabIndex = 8;
            // 
            // Ekle
            // 
            this.Ekle.FlatAppearance.BorderSize = 0;
            this.Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ekle.ForeColor = System.Drawing.Color.Navy;
            this.Ekle.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.Ekle.IconColor = System.Drawing.Color.Navy;
            this.Ekle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ekle.Location = new System.Drawing.Point(326, 480);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(146, 54);
            this.Ekle.TabIndex = 11;
            this.Ekle.Text = "Ekle";
            this.Ekle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Ekle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Ekle.UseVisualStyleBackColor = true;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click_1);
            // 
            // Sil
            // 
            this.Sil.FlatAppearance.BorderSize = 0;
            this.Sil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sil.ForeColor = System.Drawing.Color.Navy;
            this.Sil.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.Sil.IconColor = System.Drawing.Color.Navy;
            this.Sil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Sil.Location = new System.Drawing.Point(852, 480);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(146, 54);
            this.Sil.TabIndex = 13;
            this.Sil.Text = "Sil";
            this.Sil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click_1);
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.SystemColors.Control;
            this.Guncelle.FlatAppearance.BorderSize = 0;
            this.Guncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guncelle.ForeColor = System.Drawing.Color.Navy;
            this.Guncelle.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Guncelle.IconColor = System.Drawing.Color.Navy;
            this.Guncelle.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Guncelle.Location = new System.Drawing.Point(572, 480);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(184, 59);
            this.Guncelle.TabIndex = 12;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guncelle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click_1);
            // 
            // MusteriYonetimEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1170, 578);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel solPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox musteriAdi;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton anaMenuyeDon;
        private FontAwesome.Sharp.IconButton cikis;
        private System.Windows.Forms.Label musteriyonetimLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton Ekle;
        private FontAwesome.Sharp.IconButton davaSilBtn;
        private FontAwesome.Sharp.IconButton Guncelle;
        private FontAwesome.Sharp.IconButton Sil;
    }
}