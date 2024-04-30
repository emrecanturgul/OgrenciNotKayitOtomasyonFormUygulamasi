namespace OgrenciNotKayitOtomasyonFormUygulamasi
{
    partial class FrmGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 117);
            label1.Name = "label1";
            label1.Size = new Size(278, 29);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ NUMARASI : ";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = SystemColors.ScrollBar;
            maskedTextBox1.Location = new Point(402, 111);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(150, 35);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.TextChanged += maskedTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(402, 174);
            button1.Name = "button1";
            button1.Size = new Size(150, 51);
            button1.TabIndex = 2;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(14F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(695, 324);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGiris";
            Text = "Öğrenci Not Kayıt Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
    }
}