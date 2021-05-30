
namespace LawyerDiaryUI
{
    partial class FaturaIslemEkranı
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
            this.faturaBackwardBtn = new FontAwesome.Sharp.IconButton();
            this.anaMenuBtn = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.cikisBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.faturaAnaEkraniLabel = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_FaturaMusteri = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.kaydetBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.faturaBackwardBtn);
            this.panel1.Controls.Add(this.anaMenuBtn);
            this.panel1.Controls.Add(this.ıconButton1);
            this.panel1.Controls.Add(this.cikisBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 800);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // faturaBackwardBtn
            // 
            this.faturaBackwardBtn.FlatAppearance.BorderSize = 0;
            this.faturaBackwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faturaBackwardBtn.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.faturaBackwardBtn.ForeColor = System.Drawing.Color.Silver;
            this.faturaBackwardBtn.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.faturaBackwardBtn.IconColor = System.Drawing.Color.Silver;
            this.faturaBackwardBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faturaBackwardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.faturaBackwardBtn.Location = new System.Drawing.Point(0, 129);
            this.faturaBackwardBtn.Name = "faturaBackwardBtn";
            this.faturaBackwardBtn.Size = new System.Drawing.Size(155, 92);
            this.faturaBackwardBtn.TabIndex = 17;
            this.faturaBackwardBtn.Text = "Fatura Ana Ekranına Dön";
            this.faturaBackwardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.faturaBackwardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.faturaBackwardBtn.UseVisualStyleBackColor = true;
            this.faturaBackwardBtn.Click += new System.EventHandler(this.faturaBackwardBtn_Click);
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
            this.anaMenuBtn.Size = new System.Drawing.Size(155, 85);
            this.anaMenuBtn.TabIndex = 12;
            this.anaMenuBtn.Text = "Ana Menü";
            this.anaMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anaMenuBtn.UseVisualStyleBackColor = true;
            this.anaMenuBtn.Click += new System.EventHandler(this.anaMenuBtn_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.BackColor = System.Drawing.Color.Navy;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ıconButton1.ForeColor = System.Drawing.Color.Silver;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ıconButton1.IconColor = System.Drawing.Color.Silver;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.Location = new System.Drawing.Point(0, 227);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ıconButton1.Size = new System.Drawing.Size(155, 85);
            this.ıconButton1.TabIndex = 13;
            this.ıconButton1.Text = "Çıkış";
            this.ıconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = false;
            this.ıconButton1.Click += new System.EventHandler(this.cikisBtn_Click);
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
            this.cikisBtn.Location = new System.Drawing.Point(0, 202);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.cikisBtn.Size = new System.Drawing.Size(155, 85);
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
            this.panel3.Controls.Add(this.faturaAnaEkraniLabel);
            this.panel3.Controls.Add(this.exitBtn);
            this.panel3.Location = new System.Drawing.Point(154, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1265, 39);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // faturaAnaEkraniLabel
            // 
            this.faturaAnaEkraniLabel.AutoSize = true;
            this.faturaAnaEkraniLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.faturaAnaEkraniLabel.ForeColor = System.Drawing.Color.Silver;
            this.faturaAnaEkraniLabel.Location = new System.Drawing.Point(-6, 6);
            this.faturaAnaEkraniLabel.Name = "faturaAnaEkraniLabel";
            this.faturaAnaEkraniLabel.Size = new System.Drawing.Size(219, 27);
            this.faturaAnaEkraniLabel.TabIndex = 15;
            this.faturaAnaEkraniLabel.Text = "Fatura İşlem Ekranı";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Navy;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(1212, -2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(39, 39);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CB_FaturaMusteri);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(333, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(915, 509);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // CB_FaturaMusteri
            // 
            this.CB_FaturaMusteri.FormattingEnabled = true;
            this.CB_FaturaMusteri.Location = new System.Drawing.Point(160, 409);
            this.CB_FaturaMusteri.Name = "CB_FaturaMusteri";
            this.CB_FaturaMusteri.Size = new System.Drawing.Size(221, 31);
            this.CB_FaturaMusteri.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fatura Açıklaması";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(160, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(539, 206);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 361);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Tarih";
            this.textBox2.Size = new System.Drawing.Size(539, 32);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Ücret";
            this.textBox1.Size = new System.Drawing.Size(539, 32);
            this.textBox1.TabIndex = 0;
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
            this.ıconButton3.Location = new System.Drawing.Point(818, 626);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(218, 88);
            this.ıconButton3.TabIndex = 8;
            this.ıconButton3.Text = "Vazgeç";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            // 
            // kaydetBtn
            // 
            this.kaydetBtn.FlatAppearance.BorderSize = 0;
            this.kaydetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kaydetBtn.ForeColor = System.Drawing.Color.Navy;
            this.kaydetBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.kaydetBtn.IconColor = System.Drawing.Color.Navy;
            this.kaydetBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.kaydetBtn.Location = new System.Drawing.Point(582, 626);
            this.kaydetBtn.Name = "kaydetBtn";
            this.kaydetBtn.Size = new System.Drawing.Size(211, 88);
            this.kaydetBtn.TabIndex = 9;
            this.kaydetBtn.Text = "Kaydet";
            this.kaydetBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kaydetBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kaydetBtn.UseVisualStyleBackColor = true;
            this.kaydetBtn.Click += new System.EventHandler(this.kaydetBtn_Click);
            // 
            // FaturaIslemEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.kaydetBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FaturaIslemEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaIslemEkranı";
            this.Load += new System.EventHandler(this.FaturaIslemEkranı_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton anaMenuBtn;
        private FontAwesome.Sharp.IconButton cikisBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label faturaAnaEkraniLabel;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton kaydetBtn;
        private FontAwesome.Sharp.IconButton faturaBackwardBtn;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private System.Windows.Forms.ComboBox CB_FaturaMusteri;
    }
}