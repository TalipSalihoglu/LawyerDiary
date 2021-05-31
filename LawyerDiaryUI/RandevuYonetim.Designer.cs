
namespace LawyerDiaryUI
{
    partial class RandevuYonetim
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
            this.button3 = new System.Windows.Forms.Button();
            this.musteriyonetimLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekleBtn = new FontAwesome.Sharp.IconButton();
            this.güncelleBtn = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.grupBox = new System.Windows.Forms.GroupBox();
            this.randevular = new System.Windows.Forms.RadioButton();
            this.gelecekRandevular = new System.Windows.Forms.RadioButton();
            this.gecmisRandevular = new System.Windows.Forms.RadioButton();
            this.musteriAd = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuyeDon);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Location = new System.Drawing.Point(-1, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(144, 607);
            this.panel1.TabIndex = 1;
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
            this.anaMenuyeDon.Location = new System.Drawing.Point(2, 40);
            this.anaMenuyeDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anaMenuyeDon.Name = "anaMenuyeDon";
            this.anaMenuyeDon.Size = new System.Drawing.Size(144, 69);
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
            this.cikis.Location = new System.Drawing.Point(0, 124);
            this.cikis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cikis.Name = "cikis";
            this.cikis.Padding = new System.Windows.Forms.Padding(9, 0, 18, 0);
            this.cikis.Size = new System.Drawing.Size(146, 63);
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
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.musteriyonetimLabel);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 51);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDownEvent);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMovementEvent);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUpEvent);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1114, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 29);
            this.button3.TabIndex = 12;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // musteriyonetimLabel
            // 
            this.musteriyonetimLabel.AutoSize = true;
            this.musteriyonetimLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.musteriyonetimLabel.ForeColor = System.Drawing.Color.Silver;
            this.musteriyonetimLabel.Location = new System.Drawing.Point(139, 7);
            this.musteriyonetimLabel.Name = "musteriyonetimLabel";
            this.musteriyonetimLabel.Size = new System.Drawing.Size(178, 23);
            this.musteriyonetimLabel.TabIndex = 14;
            this.musteriyonetimLabel.Text = "Randevu Yönetimi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(701, 288);
            this.dataGridView1.TabIndex = 3;
            // 
            // ekleBtn
            // 
            this.ekleBtn.FlatAppearance.BorderSize = 0;
            this.ekleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ekleBtn.ForeColor = System.Drawing.Color.Navy;
            this.ekleBtn.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ekleBtn.IconColor = System.Drawing.Color.Navy;
            this.ekleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ekleBtn.Location = new System.Drawing.Point(833, 404);
            this.ekleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(174, 44);
            this.ekleBtn.TabIndex = 5;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.SystemColors.Control;
            this.güncelleBtn.FlatAppearance.BorderSize = 0;
            this.güncelleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.güncelleBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.güncelleBtn.ForeColor = System.Drawing.Color.Navy;
            this.güncelleBtn.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.güncelleBtn.IconColor = System.Drawing.Color.Navy;
            this.güncelleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.güncelleBtn.Location = new System.Drawing.Point(833, 477);
            this.güncelleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(174, 44);
            this.güncelleBtn.TabIndex = 5;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // ıconButton3
            // 
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ıconButton3.ForeColor = System.Drawing.Color.Navy;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ıconButton3.IconColor = System.Drawing.Color.Navy;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.Location = new System.Drawing.Point(833, 556);
            this.ıconButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(153, 44);
            this.ıconButton3.TabIndex = 5;
            this.ıconButton3.Text = "Sil";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // grupBox
            // 
            this.grupBox.BackColor = System.Drawing.SystemColors.Control;
            this.grupBox.Controls.Add(this.randevular);
            this.grupBox.Controls.Add(this.gelecekRandevular);
            this.grupBox.Controls.Add(this.gecmisRandevular);
            this.grupBox.Controls.Add(this.musteriAd);
            this.grupBox.Controls.Add(this.subject);
            this.grupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grupBox.ForeColor = System.Drawing.Color.Navy;
            this.grupBox.Location = new System.Drawing.Point(176, 385);
            this.grupBox.Name = "grupBox";
            this.grupBox.Size = new System.Drawing.Size(531, 215);
            this.grupBox.TabIndex = 8;
            this.grupBox.TabStop = false;
            this.grupBox.Text = "Filtreli Arama";
            // 
            // randevular
            // 
            this.randevular.AutoSize = true;
            this.randevular.Location = new System.Drawing.Point(154, 154);
            this.randevular.Name = "randevular";
            this.randevular.Size = new System.Drawing.Size(111, 19);
            this.randevular.TabIndex = 6;
            this.randevular.TabStop = true;
            this.randevular.Text = "Tüm Randevular";
            this.randevular.UseVisualStyleBackColor = true;
            // 
            // gelecekRandevular
            // 
            this.gelecekRandevular.AutoSize = true;
            this.gelecekRandevular.Location = new System.Drawing.Point(276, 117);
            this.gelecekRandevular.Name = "gelecekRandevular";
            this.gelecekRandevular.Size = new System.Drawing.Size(128, 19);
            this.gelecekRandevular.TabIndex = 5;
            this.gelecekRandevular.TabStop = true;
            this.gelecekRandevular.Text = "Gelecek Randevular";
            this.gelecekRandevular.UseVisualStyleBackColor = true;
            // 
            // gecmisRandevular
            // 
            this.gecmisRandevular.AutoSize = true;
            this.gecmisRandevular.Location = new System.Drawing.Point(58, 117);
            this.gecmisRandevular.Name = "gecmisRandevular";
            this.gecmisRandevular.Size = new System.Drawing.Size(126, 19);
            this.gecmisRandevular.TabIndex = 5;
            this.gecmisRandevular.TabStop = true;
            this.gecmisRandevular.Text = "Geçmiş Randevular";
            this.gecmisRandevular.UseVisualStyleBackColor = true;
            // 
            // musteriAd
            // 
            this.musteriAd.AutoSize = true;
            this.musteriAd.Location = new System.Drawing.Point(20, 68);
            this.musteriAd.Name = "musteriAd";
            this.musteriAd.Size = new System.Drawing.Size(0, 15);
            this.musteriAd.TabIndex = 4;
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(58, 49);
            this.subject.Name = "subject";
            this.subject.PlaceholderText = "Randevu Konusu giriniz";
            this.subject.Size = new System.Drawing.Size(420, 23);
            this.subject.TabIndex = 4;
            this.subject.TextChanged += new System.EventHandler(this.musteriAdi_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(306, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(701, 288);
            this.panel3.TabIndex = 9;
            // 
            // RandevuYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 633);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grupBox);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RandevuYonetim";
            this.Text = "RandevuYonetim";
            this.Load += new System.EventHandler(this.RandevuYonetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grupBox.ResumeLayout(false);
            this.grupBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ekleBtn;
        private FontAwesome.Sharp.IconButton güncelleBtn;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton cikis;
        private FontAwesome.Sharp.IconButton anaMenuyeDon;
        private System.Windows.Forms.Label musteriyonetimLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox grupBox;
        private System.Windows.Forms.RadioButton gelecekRandevular;
        private System.Windows.Forms.RadioButton gecmisRandevular;
        private System.Windows.Forms.Label musteriAd;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.RadioButton randevular;
        private System.Windows.Forms.Panel panel3;
    }
}