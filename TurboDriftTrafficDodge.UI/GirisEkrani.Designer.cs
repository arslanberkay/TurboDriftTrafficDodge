namespace TurboDriftTrafficDodge.UI
{
    partial class GirisEkrani
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
            btnGirisYap = new Button();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            tbZorluk = new TrackBar();
            lblZorlukSeviyesi = new Label();
            ((System.ComponentModel.ISupportInitialize)tbZorluk).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(63, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // btnGirisYap
            // 
            btnGirisYap.ForeColor = SystemColors.ActiveCaptionText;
            btnGirisYap.Location = new Point(63, 237);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(347, 60);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(63, 125);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 0;
            label2.Text = "Zorluk ";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(190, 66);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(220, 34);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // tbZorluk
            // 
            tbZorluk.Location = new Point(185, 125);
            tbZorluk.Maximum = 100;
            tbZorluk.Name = "tbZorluk";
            tbZorluk.Size = new Size(225, 56);
            tbZorluk.TabIndex = 3;
            tbZorluk.Scroll += tbZorluk_Scroll;
            // 
            // lblZorlukSeviyesi
            // 
            lblZorlukSeviyesi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblZorlukSeviyesi.ForeColor = SystemColors.Control;
            lblZorlukSeviyesi.Location = new Point(190, 184);
            lblZorlukSeviyesi.Margin = new Padding(4, 0, 4, 0);
            lblZorlukSeviyesi.Name = "lblZorlukSeviyesi";
            lblZorlukSeviyesi.Size = new Size(220, 41);
            lblZorlukSeviyesi.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(475, 350);
            Controls.Add(tbZorluk);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGirisYap);
            Controls.Add(lblZorlukSeviyesi);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araba Yarış Oyunu ";
            ((System.ComponentModel.ISupportInitialize)tbZorluk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGirisYap;
        private Label label2;
        private TrackBar tbZorluk;
        public TextBox txtKullaniciAdi;
        public Label lblZorlukSeviyesi;
    }
}