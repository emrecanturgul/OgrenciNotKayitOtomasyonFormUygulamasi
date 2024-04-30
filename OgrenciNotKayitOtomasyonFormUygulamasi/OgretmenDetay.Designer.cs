namespace OgrenciNotKayitOtomasyonFormUygulamasi
{
    partial class OgretmenDetay
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
            label1 = new Label();
            msknumara = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            mskad = new MaskedTextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox3 = new GroupBox();
            lblkalan = new Label();
            lblgecen = new Label();
            lblortalama = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            msksoyad = new MaskedTextBox();
            msksinav1 = new TextBox();
            msksinav2 = new TextBox();
            msksinav3 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(32, 110);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 0;
            label1.Text = "Numara:";
            // 
            // msknumara
            // 
            msknumara.Location = new Point(172, 110);
            msknumara.Mask = "0000";
            msknumara.Name = "msknumara";
            msknumara.Size = new Size(150, 31);
            msknumara.TabIndex = 1;
            msknumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(82, 177);
            label2.Name = "label2";
            label2.Size = new Size(52, 32);
            label2.TabIndex = 2;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(49, 251);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 3;
            label3.Text = "Soyad:";
            // 
            // mskad
            // 
            mskad.Location = new Point(172, 178);
            mskad.Name = "mskad";
            mskad.Size = new Size(150, 31);
            mskad.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(82, 330);
            button1.Name = "button1";
            button1.Size = new Size(199, 45);
            button1.TabIndex = 6;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(msksoyad);
            groupBox1.Controls.Add(mskad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(msknumara);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 410);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(msksinav3);
            groupBox2.Controls.Add(msksinav2);
            groupBox2.Controls.Add(msksinav1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(385, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(356, 410);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Not Girme";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(82, 330);
            button2.Name = "button2";
            button2.Size = new Size(199, 45);
            button2.TabIndex = 6;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(32, 253);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 3;
            label4.Text = "Sınav 3 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(32, 178);
            label5.Name = "label5";
            label5.Size = new Size(118, 32);
            label5.TabIndex = 2;
            label5.Text = "Sınav 2 : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(32, 110);
            label6.Name = "label6";
            label6.Size = new Size(111, 32);
            label6.TabIndex = 0;
            label6.Text = "Sınav 1 :";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Info;
            groupBox3.Controls.Add(lblkalan);
            groupBox3.Controls.Add(lblgecen);
            groupBox3.Controls.Add(lblortalama);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.Location = new Point(757, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(356, 410);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Not Girme";
            // 
            // lblkalan
            // 
            lblkalan.AutoSize = true;
            lblkalan.Location = new Point(210, 257);
            lblkalan.Name = "lblkalan";
            lblkalan.Size = new Size(32, 25);
            lblkalan.TabIndex = 10;
            lblkalan.Text = "00";
            // 
            // lblgecen
            // 
            lblgecen.AutoSize = true;
            lblgecen.Location = new Point(210, 177);
            lblgecen.Name = "lblgecen";
            lblgecen.Size = new Size(32, 25);
            lblgecen.TabIndex = 9;
            lblgecen.Text = "00";
            // 
            // lblortalama
            // 
            lblortalama.AutoSize = true;
            lblortalama.Location = new Point(210, 111);
            lblortalama.Name = "lblortalama";
            lblortalama.Size = new Size(32, 25);
            lblortalama.TabIndex = 8;
            lblortalama.Text = "00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(49, 250);
            label7.Name = "label7";
            label7.Size = new Size(94, 32);
            label7.TabIndex = 3;
            label7.Text = "Kalan :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(49, 175);
            label8.Name = "label8";
            label8.Size = new Size(101, 32);
            label8.TabIndex = 2;
            label8.Text = "Geçen : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(6, 107);
            label9.Name = "label9";
            label9.Size = new Size(144, 32);
            label9.TabIndex = 0;
            label9.Text = "Ortalama : ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 443);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1097, 266);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1091, 236);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // msksoyad
            // 
            msksoyad.Location = new Point(172, 254);
            msksoyad.Name = "msksoyad";
            msksoyad.Size = new Size(150, 31);
            msksoyad.TabIndex = 5;
            // 
            // msksinav1
            // 
            msksinav1.Location = new Point(172, 105);
            msksinav1.Name = "msksinav1";
            msksinav1.Size = new Size(150, 31);
            msksinav1.TabIndex = 7;
            // 
            // msksinav2
            // 
            msksinav2.Location = new Point(172, 181);
            msksinav2.Name = "msksinav2";
            msksinav2.Size = new Size(150, 31);
            msksinav2.TabIndex = 8;
            // 
            // msksinav3
            // 
            msksinav3.Location = new Point(172, 250);
            msksinav3.Name = "msksinav3";
            msksinav3.Size = new Size(150, 31);
            msksinav3.TabIndex = 9;
            // 
            // OgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1121, 721);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OgretmenDetay";
            Text = "OgretmenDetay";
            Load += OgretmenDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private MaskedTextBox msknumara;
        private Label label2;
        private Label label3;
        private MaskedTextBox mskad;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblkalan;
        private Label lblgecen;
        private Label lblortalama;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private MaskedTextBox msksoyad;
        private TextBox msksinav3;
        private TextBox msksinav2;
        private TextBox msksinav1;
    }
}