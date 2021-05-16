
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
            this.musteriyonetimLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ekleBtn = new FontAwesome.Sharp.IconButton();
            this.güncelleBtn = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuyeDon);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Location = new System.Drawing.Point(-1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 544);
            this.panel1.TabIndex = 1;
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
            this.anaMenuyeDon.Size = new System.Drawing.Size(164, 92);
            this.anaMenuyeDon.TabIndex = 12;
            this.anaMenuyeDon.Text = "Ana Menü";
            this.anaMenuyeDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.anaMenuyeDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.anaMenuyeDon.UseVisualStyleBackColor = true;
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
            this.cikis.Location = new System.Drawing.Point(-3, 98);
            this.cikis.Name = "cikis";
            this.cikis.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
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
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.musteriyonetimLabel);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1179, 39);
            this.panel2.TabIndex = 2;
            // 
            // musteriyonetimLabel
            // 
            this.musteriyonetimLabel.AutoSize = true;
            this.musteriyonetimLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.musteriyonetimLabel.ForeColor = System.Drawing.Color.Silver;
            this.musteriyonetimLabel.Location = new System.Drawing.Point(159, 9);
            this.musteriyonetimLabel.Name = "musteriyonetimLabel";
            this.musteriyonetimLabel.Size = new System.Drawing.Size(216, 27);
            this.musteriyonetimLabel.TabIndex = 14;
            this.musteriyonetimLabel.Text = "Randevu Yönetimi";
            this.musteriyonetimLabel.Click += new System.EventHandler(this.musteriyonetimLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Silver;
            this.dataGridView1.Location = new System.Drawing.Point(201, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(937, 163);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(438, 318);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(439, 27);
            this.textBox1.TabIndex = 4;
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
            this.ekleBtn.Location = new System.Drawing.Point(409, 426);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(199, 59);
            this.ekleBtn.TabIndex = 5;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekleBtn.UseVisualStyleBackColor = true;
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
            this.güncelleBtn.Location = new System.Drawing.Point(593, 426);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(199, 59);
            this.güncelleBtn.TabIndex = 5;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.güncelleBtn.UseVisualStyleBackColor = false;
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
            this.ıconButton3.Location = new System.Drawing.Point(798, 426);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(199, 59);
            this.ıconButton3.TabIndex = 5;
            this.ıconButton3.Text = "Sil";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Navy;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(1146, -3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
            this.button3.TabIndex = 12;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RandevuYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 578);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandevuYonetim";
            this.Text = "RandevuYonetim";
            this.Load += new System.EventHandler(this.RandevuYonetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconButton ekleBtn;
        private FontAwesome.Sharp.IconButton güncelleBtn;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton cikis;
        private FontAwesome.Sharp.IconButton anaMenuyeDon;
        private System.Windows.Forms.Label musteriyonetimLabel;
        private System.Windows.Forms.Button button3;
    }
}