
namespace LawyerDiaryUI
{
    partial class DavaYonetimIslem
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
            this.DavaBackwardBtn = new FontAwesome.Sharp.IconButton();
            this.anaMenuBtn = new FontAwesome.Sharp.IconButton();
            this.cikisBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.davaYonetimIslemleriLabel = new System.Windows.Forms.Label();
            this.filtreliAramaBox = new System.Windows.Forms.GroupBox();
            this.dava_musteriAdi = new System.Windows.Forms.ComboBox();
            this.davaTarih = new System.Windows.Forms.DateTimePicker();
            this.davaAcıklama = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mahkemeNo = new System.Windows.Forms.Label();
            this.musteriAd = new System.Windows.Forms.Label();
            this.davaKonu = new System.Windows.Forms.TextBox();
            this.mahkemeBox = new System.Windows.Forms.GroupBox();
            this.mahkeme_No = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hakim_Adı = new System.Windows.Forms.TextBox();
            this.btnKaydet = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.filtreliAramaBox.SuspendLayout();
            this.mahkemeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.DavaBackwardBtn);
            this.panel1.Controls.Add(this.anaMenuBtn);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 761);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // DavaBackwardBtn
            // 
            this.DavaBackwardBtn.FlatAppearance.BorderSize = 0;
            this.DavaBackwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DavaBackwardBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DavaBackwardBtn.ForeColor = System.Drawing.Color.Silver;
            this.DavaBackwardBtn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.DavaBackwardBtn.IconColor = System.Drawing.Color.Silver;
            this.DavaBackwardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DavaBackwardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DavaBackwardBtn.Location = new System.Drawing.Point(-6, 76);
            this.DavaBackwardBtn.Name = "DavaBackwardBtn";
            this.DavaBackwardBtn.Size = new System.Drawing.Size(155, 92);
            this.DavaBackwardBtn.TabIndex = 18;
            this.DavaBackwardBtn.Text = "Dava Ana Ekranına Dön";
            this.DavaBackwardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DavaBackwardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DavaBackwardBtn.UseVisualStyleBackColor = true;
            this.DavaBackwardBtn.Click += new System.EventHandler(this.DavaBackwardBtn_Click);
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
            this.anaMenuBtn.Location = new System.Drawing.Point(0, -1);
            this.anaMenuBtn.Name = "anaMenuBtn";
            this.anaMenuBtn.Size = new System.Drawing.Size(149, 85);
            this.anaMenuBtn.TabIndex = 14;
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
            this.cikisBtn.Location = new System.Drawing.Point(0, 174);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cikisBtn.Size = new System.Drawing.Size(149, 85);
            this.cikisBtn.TabIndex = 15;
            this.cikisBtn.Text = "Çıkış";
            this.cikisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikisBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.davaYonetimIslemleriLabel);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 39);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Navy;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(1365, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // davaYonetimIslemleriLabel
            // 
            this.davaYonetimIslemleriLabel.AutoSize = true;
            this.davaYonetimIslemleriLabel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.davaYonetimIslemleriLabel.ForeColor = System.Drawing.Color.Silver;
            this.davaYonetimIslemleriLabel.Location = new System.Drawing.Point(141, 10);
            this.davaYonetimIslemleriLabel.Name = "davaYonetimIslemleriLabel";
            this.davaYonetimIslemleriLabel.Size = new System.Drawing.Size(211, 22);
            this.davaYonetimIslemleriLabel.TabIndex = 13;
            this.davaYonetimIslemleriLabel.Text = "Dava Yönetim İşlemleri";
            this.davaYonetimIslemleriLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // filtreliAramaBox
            // 
            this.filtreliAramaBox.BackColor = System.Drawing.SystemColors.Control;
            this.filtreliAramaBox.Controls.Add(this.dava_musteriAdi);
            this.filtreliAramaBox.Controls.Add(this.davaTarih);
            this.filtreliAramaBox.Controls.Add(this.davaAcıklama);
            this.filtreliAramaBox.Controls.Add(this.label2);
            this.filtreliAramaBox.Controls.Add(this.label1);
            this.filtreliAramaBox.Controls.Add(this.mahkemeNo);
            this.filtreliAramaBox.Controls.Add(this.musteriAd);
            this.filtreliAramaBox.Controls.Add(this.davaKonu);
            this.filtreliAramaBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreliAramaBox.ForeColor = System.Drawing.Color.Navy;
            this.filtreliAramaBox.Location = new System.Drawing.Point(169, 64);
            this.filtreliAramaBox.Name = "filtreliAramaBox";
            this.filtreliAramaBox.Size = new System.Drawing.Size(700, 617);
            this.filtreliAramaBox.TabIndex = 4;
            this.filtreliAramaBox.TabStop = false;
            this.filtreliAramaBox.Text = "Filtreli Arama";
            this.filtreliAramaBox.Enter += new System.EventHandler(this.filtreliAramaBox_Enter);
            // 
            // dava_musteriAdi
            // 
            this.dava_musteriAdi.FormattingEnabled = true;
            this.dava_musteriAdi.Location = new System.Drawing.Point(260, 431);
            this.dava_musteriAdi.Name = "dava_musteriAdi";
            this.dava_musteriAdi.Size = new System.Drawing.Size(250, 31);
            this.dava_musteriAdi.TabIndex = 7;
            // 
            // davaTarih
            // 
            this.davaTarih.Location = new System.Drawing.Point(260, 381);
            this.davaTarih.Name = "davaTarih";
            this.davaTarih.Size = new System.Drawing.Size(250, 32);
            this.davaTarih.TabIndex = 6;
            // 
            // davaAcıklama
            // 
            this.davaAcıklama.Location = new System.Drawing.Point(260, 217);
            this.davaAcıklama.Name = "davaAcıklama";
            this.davaAcıklama.Size = new System.Drawing.Size(370, 134);
            this.davaAcıklama.TabIndex = 5;
            this.davaAcıklama.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dava Tarihi:";
            // 
            // mahkemeNo
            // 
            this.mahkemeNo.AutoSize = true;
            this.mahkemeNo.Location = new System.Drawing.Point(60, 217);
            this.mahkemeNo.Name = "mahkemeNo";
            this.mahkemeNo.Size = new System.Drawing.Size(180, 23);
            this.mahkemeNo.TabIndex = 4;
            this.mahkemeNo.Text = "Dava Açıklaması";
            // 
            // musteriAd
            // 
            this.musteriAd.AutoSize = true;
            this.musteriAd.Location = new System.Drawing.Point(60, 156);
            this.musteriAd.Name = "musteriAd";
            this.musteriAd.Size = new System.Drawing.Size(146, 23);
            this.musteriAd.TabIndex = 4;
            this.musteriAd.Text = "Dava Konusu:";
            // 
            // davaKonu
            // 
            this.davaKonu.Location = new System.Drawing.Point(260, 147);
            this.davaKonu.Name = "davaKonu";
            this.davaKonu.Size = new System.Drawing.Size(372, 32);
            this.davaKonu.TabIndex = 4;
            // 
            // mahkemeBox
            // 
            this.mahkemeBox.Controls.Add(this.mahkeme_No);
            this.mahkemeBox.Controls.Add(this.label4);
            this.mahkemeBox.Controls.Add(this.label3);
            this.mahkemeBox.Controls.Add(this.Hakim_Adı);
            this.mahkemeBox.Location = new System.Drawing.Point(932, 64);
            this.mahkemeBox.Name = "mahkemeBox";
            this.mahkemeBox.Size = new System.Drawing.Size(410, 502);
            this.mahkemeBox.TabIndex = 5;
            this.mahkemeBox.TabStop = false;
            this.mahkemeBox.Text = "Mahkeme Bilgileri";
            // 
            // mahkeme_No
            // 
            this.mahkeme_No.FormattingEnabled = true;
            this.mahkeme_No.Location = new System.Drawing.Point(19, 172);
            this.mahkeme_No.Name = "mahkeme_No";
            this.mahkeme_No.Size = new System.Drawing.Size(343, 31);
            this.mahkeme_No.TabIndex = 5;
            this.mahkeme_No.SelectedIndexChanged += new System.EventHandler(this.mahkeme_No_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hakim Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mahkeme No:";
            // 
            // Hakim_Adı
            // 
            this.Hakim_Adı.Location = new System.Drawing.Point(19, 274);
            this.Hakim_Adı.Name = "Hakim_Adı";
            this.Hakim_Adı.Size = new System.Drawing.Size(343, 32);
            this.Hakim_Adı.TabIndex = 4;
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.Navy;
            this.btnKaydet.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnKaydet.IconColor = System.Drawing.Color.Navy;
            this.btnKaydet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKaydet.Location = new System.Drawing.Point(1060, 627);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(149, 54);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DavaYonetimIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.mahkemeBox);
            this.Controls.Add(this.filtreliAramaBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DavaYonetimIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DavaYonetimIslem";
            this.Load += new System.EventHandler(this.DavaYonetimIslem_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.filtreliAramaBox.ResumeLayout(false);
            this.filtreliAramaBox.PerformLayout();
            this.mahkemeBox.ResumeLayout(false);
            this.mahkemeBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox filtreliAramaBox;
        private System.Windows.Forms.DateTimePicker davaTarih;
        private System.Windows.Forms.RichTextBox davaAcıklama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mahkemeNo;
        private System.Windows.Forms.Label musteriAd;
        private System.Windows.Forms.TextBox davaKonu;
        private System.Windows.Forms.GroupBox mahkemeBox;
        private System.Windows.Forms.ComboBox mahkeme_No;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Hakim_Adı;
        private FontAwesome.Sharp.IconButton anaMenuBtn;
        private FontAwesome.Sharp.IconButton cikisBtn;
        private System.Windows.Forms.Label davaYonetimIslemleriLabel;
        private System.Windows.Forms.Button exitBtn;
        private FontAwesome.Sharp.IconButton DavaBackwardBtn;
        private System.Windows.Forms.ComboBox dava_musteriAdi;
        private FontAwesome.Sharp.IconButton btnKaydet;
    }
}