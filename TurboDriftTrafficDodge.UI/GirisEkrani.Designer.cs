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
            chkKolaydanZora = new CheckBox();
            label3 = new Label();
            cbMuzik = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)tbZorluk).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
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
            btnGirisYap.Location = new Point(63, 302);
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
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(63, 120);
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
            tbZorluk.Location = new Point(185, 120);
            tbZorluk.Maximum = 100;
            tbZorluk.Name = "tbZorluk";
            tbZorluk.Size = new Size(225, 56);
            tbZorluk.TabIndex = 3;
            tbZorluk.Scroll += tbZorluk_Scroll;
            // 
            // lblZorlukSeviyesi
            // 
            lblZorlukSeviyesi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblZorlukSeviyesi.ForeColor = SystemColors.ControlLightLight;
            lblZorlukSeviyesi.Location = new Point(185, 194);
            lblZorlukSeviyesi.Margin = new Padding(4, 0, 4, 0);
            lblZorlukSeviyesi.Name = "lblZorlukSeviyesi";
            lblZorlukSeviyesi.Size = new Size(220, 41);
            lblZorlukSeviyesi.TabIndex = 0;
            // 
            // chkKolaydanZora
            // 
            chkKolaydanZora.AutoSize = true;
            chkKolaydanZora.ForeColor = SystemColors.ControlLightLight;
            chkKolaydanZora.Location = new Point(190, 159);
            chkKolaydanZora.Name = "chkKolaydanZora";
            chkKolaydanZora.Size = new Size(161, 32);
            chkKolaydanZora.TabIndex = 4;
            chkKolaydanZora.Text = "Kolaydan Zora";
            chkKolaydanZora.UseVisualStyleBackColor = true;
            chkKolaydanZora.CheckedChanged += chkKolaydanZora_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(63, 245);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 5;
            label3.Text = "Müzik";
            // 
            // cbMuzik
            // 
            cbMuzik.FormattingEnabled = true;
            cbMuzik.Location = new Point(190, 245);
            cbMuzik.Name = "cbMuzik";
            cbMuzik.Size = new Size(220, 36);
            cbMuzik.TabIndex = 6;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(466, 450);
            Controls.Add(cbMuzik);
            Controls.Add(label3);
            Controls.Add(chkKolaydanZora);
            Controls.Add(tbZorluk);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGirisYap);
            Controls.Add(lblZorlukSeviyesi);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "GirisEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Araba Yarış Oyunu ";
            Load += GirisEkrani_Load;
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
        private CheckBox chkKolaydanZora;
        private Label label3;
        public ComboBox cbMuzik;
    }
}