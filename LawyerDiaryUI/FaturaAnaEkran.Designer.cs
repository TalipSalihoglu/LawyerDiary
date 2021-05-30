
namespace LawyerDiaryUI
{
    partial class FaturaAnaEkran
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
            this.button1 = new System.Windows.Forms.Button();
            this.faturaAnaEkraniLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anaMenuBtn = new FontAwesome.Sharp.IconButton();
            this.cikisBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grupBox = new System.Windows.Forms.GroupBox();
            this.gelecekDavalar = new System.Windows.Forms.RadioButton();
            this.gecmisDavalar = new System.Windows.Forms.RadioButton();
            this.musteriAd = new System.Windows.Forms.Label();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.FaturaEkleBtn = new FontAwesome.Sharp.IconButton();
            this.FaturaSilBtn = new FontAwesome.Sharp.IconButton();
            this.disaAktarBtn = new FontAwesome.Sharp.IconButton();
            this.FaturaGuncelleBtn = new FontAwesome.Sharp.IconButton();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.faturaAnaEkraniLabel);
            this.panel3.Controls.Add(this.exitBtn);
            this.panel3.Location = new System.Drawing.Point(146, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1198, 39);
            this.panel3.TabIndex = 5;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1125, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // faturaAnaEkraniLabel
            // 
            this.faturaAnaEkraniLabel.AutoSize = true;
            this.faturaAnaEkraniLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.faturaAnaEkraniLabel.ForeColor = System.Drawing.Color.Silver;
            this.faturaAnaEkraniLabel.Location = new System.Drawing.Point(1, 9);
            this.faturaAnaEkraniLabel.Name = "faturaAnaEkraniLabel";
            this.faturaAnaEkraniLabel.Size = new System.Drawing.Size(206, 27);
            this.faturaAnaEkraniLabel.TabIndex = 15;
            this.faturaAnaEkraniLabel.Text = "Fatura Ana Ekranı";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Navy;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(1159, -3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuBtn);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 536);
            this.panel1.TabIndex = 4;
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
            this.dataGridView1.Location = new System.Drawing.Point(392, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(689, 221);
            this.dataGridView1.TabIndex = 6;
            // 
            // grupBox
            // 
            this.grupBox.BackColor = System.Drawing.SystemColors.Control;
            this.grupBox.Controls.Add(this.gelecekDavalar);
            this.grupBox.Controls.Add(this.gecmisDavalar);
            this.grupBox.Controls.Add(this.musteriAd);
            this.grupBox.Controls.Add(this.musteriAdi);
            this.grupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupBox.ForeColor = System.Drawing.Color.Navy;
            this.grupBox.Location = new System.Drawing.Point(180, 306);
            this.grupBox.Name = "grupBox";
            this.grupBox.Size = new System.Drawing.Size(498, 192);
            this.grupBox.TabIndex = 7;
            this.grupBox.TabStop = false;
            this.grupBox.Text = "Filtreli Arama";
            // 
            // gelecekDavalar
            // 
            this.gelecekDavalar.AutoSize = true;
            this.gelecekDavalar.Location = new System.Drawing.Point(259, 133);
            this.gelecekDavalar.Name = "gelecekDavalar";
            this.gelecekDavalar.Size = new System.Drawing.Size(202, 27);
            this.gelecekDavalar.TabIndex = 5;
            this.gelecekDavalar.TabStop = true;
            this.gelecekDavalar.Text = "Gelecek Davalar";
            this.gelecekDavalar.UseVisualStyleBackColor = true;
            // 
            // gecmisDavalar
            // 
            this.gecmisDavalar.AutoSize = true;
            this.gecmisDavalar.Location = new System.Drawing.Point(41, 133);
            this.gecmisDavalar.Name = "gecmisDavalar";
            this.gecmisDavalar.Size = new System.Drawing.Size(191, 27);
            this.gecmisDavalar.TabIndex = 5;
            this.gecmisDavalar.TabStop = true;
            this.gecmisDavalar.Text = "Geçmiş Davalar";
            this.gecmisDavalar.UseVisualStyleBackColor = true;
            // 
            // musteriAd
            // 
            this.musteriAd.AutoSize = true;
            this.musteriAd.Location = new System.Drawing.Point(20, 68);
            this.musteriAd.Name = "musteriAd";
            this.musteriAd.Size = new System.Drawing.Size(0, 23);
            this.musteriAd.TabIndex = 4;
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(41, 65);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.PlaceholderText = "Müvekkil Adı";
            this.musteriAdi.Size = new System.Drawing.Size(420, 32);
            this.musteriAdi.TabIndex = 4;
            this.musteriAdi.TextChanged += new System.EventHandler(this.musteriAdi_TextChanged);
            // 
            // FaturaEkleBtn
            // 
            this.FaturaEkleBtn.FlatAppearance.BorderSize = 0;
            this.FaturaEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaturaEkleBtn.ForeColor = System.Drawing.Color.Navy;
            this.FaturaEkleBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.FaturaEkleBtn.IconColor = System.Drawing.Color.Navy;
            this.FaturaEkleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FaturaEkleBtn.Location = new System.Drawing.Point(1017, 423);
            this.FaturaEkleBtn.Name = "FaturaEkleBtn";
            this.FaturaEkleBtn.Size = new System.Drawing.Size(146, 54);
            this.FaturaEkleBtn.TabIndex = 13;
            this.FaturaEkleBtn.Text = "Ekle";
            this.FaturaEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FaturaEkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FaturaEkleBtn.UseVisualStyleBackColor = true;
            this.FaturaEkleBtn.Click += new System.EventHandler(this.FaturaEkleBtn_Click);
            // 
            // FaturaSilBtn
            // 
            this.FaturaSilBtn.FlatAppearance.BorderSize = 0;
            this.FaturaSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaturaSilBtn.ForeColor = System.Drawing.Color.Navy;
            this.FaturaSilBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.FaturaSilBtn.IconColor = System.Drawing.Color.Navy;
            this.FaturaSilBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FaturaSilBtn.Location = new System.Drawing.Point(1007, 338);
            this.FaturaSilBtn.Name = "FaturaSilBtn";
            this.FaturaSilBtn.Size = new System.Drawing.Size(156, 59);
            this.FaturaSilBtn.TabIndex = 14;
            this.FaturaSilBtn.Text = "Sil";
            this.FaturaSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FaturaSilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FaturaSilBtn.UseVisualStyleBackColor = true;
            this.FaturaSilBtn.Click += new System.EventHandler(this.FaturaSilBtn_Click);
            // 
            // disaAktarBtn
            // 
            this.disaAktarBtn.BackColor = System.Drawing.SystemColors.Control;
            this.disaAktarBtn.FlatAppearance.BorderSize = 0;
            this.disaAktarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disaAktarBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disaAktarBtn.ForeColor = System.Drawing.Color.Navy;
            this.disaAktarBtn.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.disaAktarBtn.IconColor = System.Drawing.Color.Navy;
            this.disaAktarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.disaAktarBtn.Location = new System.Drawing.Point(793, 423);
            this.disaAktarBtn.Name = "disaAktarBtn";
            this.disaAktarBtn.Size = new System.Drawing.Size(184, 59);
            this.disaAktarBtn.TabIndex = 11;
            this.disaAktarBtn.Text = "Dışa Aktar";
            this.disaAktarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disaAktarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.disaAktarBtn.UseVisualStyleBackColor = false;
            // 
            // FaturaGuncelleBtn
            // 
            this.FaturaGuncelleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.FaturaGuncelleBtn.FlatAppearance.BorderSize = 0;
            this.FaturaGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaturaGuncelleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FaturaGuncelleBtn.ForeColor = System.Drawing.Color.Navy;
            this.FaturaGuncelleBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.FaturaGuncelleBtn.IconColor = System.Drawing.Color.Navy;
            this.FaturaGuncelleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FaturaGuncelleBtn.Location = new System.Drawing.Point(793, 338);
            this.FaturaGuncelleBtn.Name = "FaturaGuncelleBtn";
            this.FaturaGuncelleBtn.Size = new System.Drawing.Size(184, 59);
            this.FaturaGuncelleBtn.TabIndex = 12;
            this.FaturaGuncelleBtn.Text = "Güncelle";
            this.FaturaGuncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FaturaGuncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FaturaGuncelleBtn.UseVisualStyleBackColor = false;
            this.FaturaGuncelleBtn.Click += new System.EventHandler(this.FaturaGuncelleBtn_Click);
            // 
            // FaturaAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 531);
            this.Controls.Add(this.FaturaEkleBtn);
            this.Controls.Add(this.FaturaSilBtn);
            this.Controls.Add(this.disaAktarBtn);
            this.Controls.Add(this.FaturaGuncelleBtn);
            this.Controls.Add(this.grupBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FaturaAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaAnaEkran";
            this.Load += new System.EventHandler(this.FaturaAnaEkran_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grupBox.ResumeLayout(false);
            this.grupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label faturaAnaEkraniLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton anaMenuBtn;
        private FontAwesome.Sharp.IconButton cikisBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grupBox;
        private System.Windows.Forms.RadioButton gelecekDavalar;
        private System.Windows.Forms.RadioButton gecmisDavalar;
        private System.Windows.Forms.Label musteriAd;
        private System.Windows.Forms.TextBox musteriAdi;
        private FontAwesome.Sharp.IconButton FaturaEkleBtn;
        private FontAwesome.Sharp.IconButton FaturaSilBtn;
        private FontAwesome.Sharp.IconButton disaAktarBtn;
        private FontAwesome.Sharp.IconButton FaturaGuncelleBtn;
    }
}