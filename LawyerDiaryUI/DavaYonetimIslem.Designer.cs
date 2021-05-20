
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.filtreliAramaBox = new System.Windows.Forms.GroupBox();
            this.mahkemeNo = new System.Windows.Forms.Label();
            this.musteriAd = new System.Windows.Forms.Label();
            this.musteriAdi = new System.Windows.Forms.TextBox();
            this.mahkemeBox = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.anaMenuBtn = new FontAwesome.Sharp.IconButton();
            this.cikisBtn = new FontAwesome.Sharp.IconButton();
            this.davaYonetimIslemleriLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.filtreliAramaBox.SuspendLayout();
            this.mahkemeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuBtn);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Location = new System.Drawing.Point(-1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 497);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.exitBtn);
            this.panel2.Controls.Add(this.davaYonetimIslemleriLabel);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1362, 39);
            this.panel2.TabIndex = 1;
            // 
            // filtreliAramaBox
            // 
            this.filtreliAramaBox.BackColor = System.Drawing.SystemColors.Control;
            this.filtreliAramaBox.Controls.Add(this.dateTimePicker1);
            this.filtreliAramaBox.Controls.Add(this.richTextBox1);
            this.filtreliAramaBox.Controls.Add(this.label2);
            this.filtreliAramaBox.Controls.Add(this.label1);
            this.filtreliAramaBox.Controls.Add(this.mahkemeNo);
            this.filtreliAramaBox.Controls.Add(this.musteriAd);
            this.filtreliAramaBox.Controls.Add(this.textBox1);
            this.filtreliAramaBox.Controls.Add(this.musteriAdi);
            this.filtreliAramaBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreliAramaBox.ForeColor = System.Drawing.Color.Navy;
            this.filtreliAramaBox.Location = new System.Drawing.Point(169, 64);
            this.filtreliAramaBox.Name = "filtreliAramaBox";
            this.filtreliAramaBox.Size = new System.Drawing.Size(700, 391);
            this.filtreliAramaBox.TabIndex = 4;
            this.filtreliAramaBox.TabStop = false;
            this.filtreliAramaBox.Text = "Filtreli Arama";
            this.filtreliAramaBox.Enter += new System.EventHandler(this.grupBox_Enter);
            // 
            // mahkemeNo
            // 
            this.mahkemeNo.AutoSize = true;
            this.mahkemeNo.Location = new System.Drawing.Point(67, 132);
            this.mahkemeNo.Name = "mahkemeNo";
            this.mahkemeNo.Size = new System.Drawing.Size(180, 23);
            this.mahkemeNo.TabIndex = 4;
            this.mahkemeNo.Text = "Dava Açıklaması";
            // 
            // musteriAd
            // 
            this.musteriAd.AutoSize = true;
            this.musteriAd.Location = new System.Drawing.Point(67, 71);
            this.musteriAd.Name = "musteriAd";
            this.musteriAd.Size = new System.Drawing.Size(146, 23);
            this.musteriAd.TabIndex = 4;
            this.musteriAd.Text = "Dava Konusu:";
            // 
            // musteriAdi
            // 
            this.musteriAdi.Location = new System.Drawing.Point(267, 62);
            this.musteriAdi.Name = "musteriAdi";
            this.musteriAdi.Size = new System.Drawing.Size(372, 32);
            this.musteriAdi.TabIndex = 4;
            // 
            // mahkemeBox
            // 
            this.mahkemeBox.Controls.Add(this.comboBox1);
            this.mahkemeBox.Controls.Add(this.label4);
            this.mahkemeBox.Controls.Add(this.label3);
            this.mahkemeBox.Controls.Add(this.textBox2);
            this.mahkemeBox.Location = new System.Drawing.Point(912, 64);
            this.mahkemeBox.Name = "mahkemeBox";
            this.mahkemeBox.Size = new System.Drawing.Size(283, 391);
            this.mahkemeBox.TabIndex = 5;
            this.mahkemeBox.TabStop = false;
            this.mahkemeBox.Text = "Mahkeme Bilgileri";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(267, 132);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(370, 134);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dava Tarihi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dava Açıklaması:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 296);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 32);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 345);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(372, 32);
            this.textBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mahkeme No:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 31);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hakim Adı:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 234);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 32);
            this.textBox2.TabIndex = 4;
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
            this.cikisBtn.Location = new System.Drawing.Point(0, 90);
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
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Navy;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(1180, 0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.TabIndex = 14;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // DavaYonetimIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 531);
            this.Controls.Add(this.mahkemeBox);
            this.Controls.Add(this.filtreliAramaBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DavaYonetimIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DavaYonetimIslem";
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mahkemeNo;
        private System.Windows.Forms.Label musteriAd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox musteriAdi;
        private System.Windows.Forms.GroupBox mahkemeBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private FontAwesome.Sharp.IconButton anaMenuBtn;
        private FontAwesome.Sharp.IconButton cikisBtn;
        private System.Windows.Forms.Label davaYonetimIslemleriLabel;
        private System.Windows.Forms.Button exitBtn;
    }
}