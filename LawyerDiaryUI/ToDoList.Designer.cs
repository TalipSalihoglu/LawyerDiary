
namespace LawyerDiaryUI
{
    partial class ToDoList
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.musteriyonetimLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anaMenuyeDon = new FontAwesome.Sharp.IconButton();
            this.cikis = new FontAwesome.Sharp.IconButton();
            this.gorevDetaylari = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.güncelleBtn = new FontAwesome.Sharp.IconButton();
            this.ekleBtn = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gorevDetaylari.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.musteriyonetimLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 45);
            this.panel2.TabIndex = 4;
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
            this.button3.Location = new System.Drawing.Point(1341, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 39);
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
            this.musteriyonetimLabel.Location = new System.Drawing.Point(159, 9);
            this.musteriyonetimLabel.Name = "musteriyonetimLabel";
            this.musteriyonetimLabel.Size = new System.Drawing.Size(224, 27);
            this.musteriyonetimLabel.TabIndex = 14;
            this.musteriyonetimLabel.Text = "Yapılacaklar Listesi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.anaMenuyeDon);
            this.panel1.Controls.Add(this.cikis);
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 755);
            this.panel1.TabIndex = 3;
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
            this.anaMenuyeDon.Location = new System.Drawing.Point(0, 0);
            this.anaMenuyeDon.Name = "anaMenuyeDon";
            this.anaMenuyeDon.Size = new System.Drawing.Size(165, 92);
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
            this.cikis.Location = new System.Drawing.Point(-3, 99);
            this.cikis.Name = "cikis";
            this.cikis.Padding = new System.Windows.Forms.Padding(10, 0, 21, 0);
            this.cikis.Size = new System.Drawing.Size(167, 84);
            this.cikis.TabIndex = 13;
            this.cikis.Text = "Çıkış";
            this.cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cikis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cikis.UseVisualStyleBackColor = false;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // gorevDetaylari
            // 
            this.gorevDetaylari.Controls.Add(this.label1);
            this.gorevDetaylari.Controls.Add(this.richTextBox1);
            this.gorevDetaylari.Controls.Add(this.textBox1);
            this.gorevDetaylari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gorevDetaylari.ForeColor = System.Drawing.Color.Navy;
            this.gorevDetaylari.Location = new System.Drawing.Point(202, 77);
            this.gorevDetaylari.Name = "gorevDetaylari";
            this.gorevDetaylari.Size = new System.Drawing.Size(400, 284);
            this.gorevDetaylari.TabIndex = 5;
            this.gorevDetaylari.TabStop = false;
            this.gorevDetaylari.Text = "Görev Detayları";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Görev Açıklaması";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(28, 119);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 148);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Görev Konusu";
            this.textBox1.Size = new System.Drawing.Size(342, 32);
            this.textBox1.TabIndex = 11;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(770, 84);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(568, 274);
            this.checkedListBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(770, 417);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(568, 303);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.ıconButton3.Location = new System.Drawing.Point(344, 661);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(199, 59);
            this.ıconButton3.TabIndex = 8;
            this.ıconButton3.Text = "Sil";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
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
            this.güncelleBtn.Location = new System.Drawing.Point(363, 539);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(199, 59);
            this.güncelleBtn.TabIndex = 9;
            this.güncelleBtn.Text = "Güncelle";
            this.güncelleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.güncelleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.güncelleBtn.UseVisualStyleBackColor = false;
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
            this.ekleBtn.Location = new System.Drawing.Point(349, 417);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(199, 59);
            this.ekleBtn.TabIndex = 10;
            this.ekleBtn.Text = "Ekle";
            this.ekleBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ekleBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ekleBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Yapılacaklar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tamamlanan Görevler";
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ıconButton3);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.gorevDetaylari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gorevDetaylari.ResumeLayout(false);
            this.gorevDetaylari.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label musteriyonetimLabel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton anaMenuyeDon;
        private FontAwesome.Sharp.IconButton cikis;
        private System.Windows.Forms.GroupBox gorevDetaylari;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton güncelleBtn;
        private FontAwesome.Sharp.IconButton ekleBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}