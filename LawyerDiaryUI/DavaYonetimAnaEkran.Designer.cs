
namespace LawyerDiaryUI
{
    partial class DavaYonetimAnaEkran
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
            this.anaMenuBtn = new FontAwesome.Sharp.IconButton();
            this.cikisBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.grupBox = new System.Windows.Forms.GroupBox();
            this.gelecekDavalar = new System.Windows.Forms.RadioButton();
            this.gecmisDavalar = new System.Windows.Forms.RadioButton();
            this.mahkemeNo = new System.Windows.Forms.Label();
            this.musteriAd = new System.Windows.Forms.Label();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.mahkemeSalonNo = new System.Windows.Forms.TextBox();
            this.davaGuncelleBtn = new FontAwesome.Sharp.IconButton();
            this.davaSilBtn = new FontAwesome.Sharp.IconButton();
            this.davaEkleBtn = new FontAwesome.Sharp.IconButton();
            this.disaAktarBtn = new FontAwesome.Sharp.IconButton();
            this.mahkemeIsleriBtn = new FontAwesome.Sharp.IconButton();
            this.musteriyonetimLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.grupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuBtn);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 578);
            this.panel1.TabIndex = 0;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.musteriyonetimLabel);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(128, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 39);
            this.panel3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1216, -4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 11;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(847, 72);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 29;
            this.dataGrid.Size = new System.Drawing.Size(500, 474);
            this.dataGrid.TabIndex = 2;
            // 
            // grupBox
            // 
            this.grupBox.BackColor = System.Drawing.SystemColors.Control;
            this.grupBox.Controls.Add(this.gelecekDavalar);
            this.grupBox.Controls.Add(this.gecmisDavalar);
            this.grupBox.Controls.Add(this.mahkemeNo);
            this.grupBox.Controls.Add(this.musteriAd);
            this.grupBox.Controls.Add(this.musteriAdi);
            this.grupBox.Controls.Add(this.mahkemeSalonNo);
            this.grupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupBox.ForeColor = System.Drawing.Color.Navy;
            this.grupBox.Location = new System.Drawing.Point(233, 72);
            this.grupBox.Name = "grupBox";
            this.grupBox.Size = new System.Drawing.Size(588, 258);
            this.grupBox.TabIndex = 3;
            this.grupBox.TabStop = false;
            this.grupBox.Text = "Filtreli Arama";
            // 
            // gelecekDavalar
            // 
            this.gelecekDavalar.AutoSize = true;
            this.gelecekDavalar.Location = new System.Drawing.Point(343, 209);
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
            this.gecmisDavalar.Location = new System.Drawing.Point(114, 209);
            this.gecmisDavalar.Name = "gecmisDavalar";
            this.gecmisDavalar.Size = new System.Drawing.Size(191, 27);
            this.gecmisDavalar.TabIndex = 5;
            this.gecmisDavalar.TabStop = true;
            this.gecmisDavalar.Text = "Geçmiş Davalar";
            this.gecmisDavalar.UseVisualStyleBackColor = true;
            // 
            // mahkemeNo
            // 
            this.mahkemeNo.AutoSize = true;
            this.mahkemeNo.Location = new System.Drawing.Point(20, 147);
            this.mahkemeNo.Name = "mahkemeNo";
            this.mahkemeNo.Size = new System.Drawing.Size(147, 23);
            this.mahkemeNo.TabIndex = 4;
            this.mahkemeNo.Text = "Mahkeme No:";
            // 
            // musteriAd
            // 
            this.musteriAd.AutoSize = true;
            this.musteriAd.Location = new System.Drawing.Point(20, 68);
            this.musteriAd.Name = "musteriAd";
            this.musteriAd.Size = new System.Drawing.Size(138, 23);
            this.musteriAd.TabIndex = 4;
            this.musteriAd.Text = "Müvekkil Adı:";
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(173, 59);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.Size = new System.Drawing.Size(372, 32);
            this.musteriAdi.TabIndex = 4;
            // 
            // mahkemeSalonNo
            // 
            this.mahkemeSalonNo.Location = new System.Drawing.Point(173, 138);
            this.mahkemeSalonNo.Name = "mahkemeSalonNo";
            this.mahkemeSalonNo.Size = new System.Drawing.Size(372, 32);
            this.mahkemeSalonNo.TabIndex = 4;
            // 
            // davaGuncelleBtn
            // 
            this.davaGuncelleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.davaGuncelleBtn.FlatAppearance.BorderSize = 0;
            this.davaGuncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.davaGuncelleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.davaGuncelleBtn.ForeColor = System.Drawing.Color.Navy;
            this.davaGuncelleBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.davaGuncelleBtn.IconColor = System.Drawing.Color.Navy;
            this.davaGuncelleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.davaGuncelleBtn.Location = new System.Drawing.Point(229, 367);
            this.davaGuncelleBtn.Name = "davaGuncelleBtn";
            this.davaGuncelleBtn.Size = new System.Drawing.Size(184, 59);
            this.davaGuncelleBtn.TabIndex = 6;
            this.davaGuncelleBtn.Text = "Güncelle";
            this.davaGuncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.davaGuncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.davaGuncelleBtn.UseVisualStyleBackColor = false;
            // 
            // davaSilBtn
            // 
            this.davaSilBtn.FlatAppearance.BorderSize = 0;
            this.davaSilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.davaSilBtn.ForeColor = System.Drawing.Color.Navy;
            this.davaSilBtn.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.davaSilBtn.IconColor = System.Drawing.Color.Navy;
            this.davaSilBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.davaSilBtn.Location = new System.Drawing.Point(449, 372);
            this.davaSilBtn.Name = "davaSilBtn";
            this.davaSilBtn.Size = new System.Drawing.Size(146, 54);
            this.davaSilBtn.TabIndex = 10;
            this.davaSilBtn.Text = "Sil";
            this.davaSilBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.davaSilBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.davaSilBtn.UseVisualStyleBackColor = true;
            // 
            // davaEkleBtn
            // 
            this.davaEkleBtn.FlatAppearance.BorderSize = 0;
            this.davaEkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.davaEkleBtn.ForeColor = System.Drawing.Color.Navy;
            this.davaEkleBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.davaEkleBtn.IconColor = System.Drawing.Color.Navy;
            this.davaEkleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.davaEkleBtn.Location = new System.Drawing.Point(631, 372);
            this.davaEkleBtn.Name = "davaEkleBtn";
            this.davaEkleBtn.Size = new System.Drawing.Size(146, 54);
            this.davaEkleBtn.TabIndex = 10;
            this.davaEkleBtn.Text = "Ekle";
            this.davaEkleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.davaEkleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.davaEkleBtn.UseVisualStyleBackColor = true;
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
            this.disaAktarBtn.Location = new System.Drawing.Point(309, 454);
            this.disaAktarBtn.Name = "disaAktarBtn";
            this.disaAktarBtn.Size = new System.Drawing.Size(184, 59);
            this.disaAktarBtn.TabIndex = 6;
            this.disaAktarBtn.Text = "Dışa Aktar";
            this.disaAktarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disaAktarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.disaAktarBtn.UseVisualStyleBackColor = false;
            // 
            // mahkemeIsleriBtn
            // 
            this.mahkemeIsleriBtn.BackColor = System.Drawing.SystemColors.Control;
            this.mahkemeIsleriBtn.FlatAppearance.BorderSize = 0;
            this.mahkemeIsleriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mahkemeIsleriBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mahkemeIsleriBtn.ForeColor = System.Drawing.Color.Navy;
            this.mahkemeIsleriBtn.IconChar = FontAwesome.Sharp.IconChar.Gavel;
            this.mahkemeIsleriBtn.IconColor = System.Drawing.Color.Navy;
            this.mahkemeIsleriBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.mahkemeIsleriBtn.Location = new System.Drawing.Point(534, 454);
            this.mahkemeIsleriBtn.Name = "mahkemeIsleriBtn";
            this.mahkemeIsleriBtn.Size = new System.Drawing.Size(184, 59);
            this.mahkemeIsleriBtn.TabIndex = 6;
            this.mahkemeIsleriBtn.Text = "Mahkeme İşleri";
            this.mahkemeIsleriBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mahkemeIsleriBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mahkemeIsleriBtn.UseVisualStyleBackColor = false;
            // 
            // musteriyonetimLabel
            // 
            this.musteriyonetimLabel.AutoSize = true;
            this.musteriyonetimLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.musteriyonetimLabel.ForeColor = System.Drawing.Color.Silver;
            this.musteriyonetimLabel.Location = new System.Drawing.Point(0, 4);
            this.musteriyonetimLabel.Name = "musteriyonetimLabel";
            this.musteriyonetimLabel.Size = new System.Drawing.Size(295, 27);
            this.musteriyonetimLabel.TabIndex = 15;
            this.musteriyonetimLabel.Text = "Dava Yönetim Ana Ekranı";
            // 
            // DavaYonetimAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1377, 578);
            this.Controls.Add(this.davaEkleBtn);
            this.Controls.Add(this.davaSilBtn);
            this.Controls.Add(this.mahkemeIsleriBtn);
            this.Controls.Add(this.disaAktarBtn);
            this.Controls.Add(this.davaGuncelleBtn);
            this.Controls.Add(this.grupBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DavaYonetimAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DavaYonetimAnaEkran";
            this.Load += new System.EventHandler(this.DavaYonetimAnaEkran_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.grupBox.ResumeLayout(false);
            this.grupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox grupBox;
        private System.Windows.Forms.RadioButton gelecekDavalar;
        private System.Windows.Forms.RadioButton gecmisDavalar;
        private System.Windows.Forms.Label mahkemeNo;
        private System.Windows.Forms.Label musteriAd;
        private System.Windows.Forms.TextBox musteriAdi;
        private System.Windows.Forms.TextBox mahkemeSalonNo;
        private FontAwesome.Sharp.IconButton davaGuncelleBtn;
        private FontAwesome.Sharp.IconButton davaSilBtn;
        private FontAwesome.Sharp.IconButton davaEkleBtn;
        private FontAwesome.Sharp.IconButton disaAktarBtn;
        private FontAwesome.Sharp.IconButton mahkemeIsleriBtn;
        private FontAwesome.Sharp.IconButton anaMenuBtn;
        private FontAwesome.Sharp.IconButton cikisBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label musteriyonetimLabel;
    }
}