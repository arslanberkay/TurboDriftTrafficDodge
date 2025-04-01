namespace TurboDriftTrafficDodge.UI
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnOyunuBaslat = new Button();
            tmrHareket = new System.Windows.Forms.Timer(components);
            pnlYarisAlani = new Panel();
            pbKupa = new PictureBox();
            lblEnYuksekSkorKupa = new Label();
            lblEnYuksekSkorKupaYazisi = new Label();
            pbAraba3 = new PictureBox();
            pbAraba2 = new PictureBox();
            pbAraba4 = new PictureBox();
            pbArabam = new PictureBox();
            pbPatlama = new PictureBox();
            pbAraba1 = new PictureBox();
            pbYol = new PictureBox();
            label1 = new Label();
            lblKazanilanPuan = new Label();
            label2 = new Label();
            lblEnYuksekSkor = new Label();
            pnlYarisAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbKupa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArabam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPatlama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYol).BeginInit();
            SuspendLayout();
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Location = new Point(771, 906);
            btnOyunuBaslat.Margin = new Padding(4);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(300, 81);
            btnOyunuBaslat.TabIndex = 1;
            btnOyunuBaslat.Text = "Oyunu Başlat";
            btnOyunuBaslat.UseVisualStyleBackColor = true;
            btnOyunuBaslat.Click += btnOyunuBaslat_Click;
            // 
            // tmrHareket
            // 
            tmrHareket.Interval = 10;
            tmrHareket.Tick += tmrHareket_Tick;
            // 
            // pnlYarisAlani
            // 
            pnlYarisAlani.BackColor = SystemColors.ActiveCaptionText;
            pnlYarisAlani.Controls.Add(pbKupa);
            pnlYarisAlani.Controls.Add(lblEnYuksekSkorKupa);
            pnlYarisAlani.Controls.Add(lblEnYuksekSkorKupaYazisi);
            pnlYarisAlani.Controls.Add(pbAraba3);
            pnlYarisAlani.Controls.Add(pbAraba2);
            pnlYarisAlani.Controls.Add(pbAraba4);
            pnlYarisAlani.Controls.Add(pbArabam);
            pnlYarisAlani.Controls.Add(pbPatlama);
            pnlYarisAlani.Controls.Add(pbAraba1);
            pnlYarisAlani.Controls.Add(pbYol);
            pnlYarisAlani.Location = new Point(37, 12);
            pnlYarisAlani.Name = "pnlYarisAlani";
            pnlYarisAlani.Size = new Size(1034, 884);
            pnlYarisAlani.TabIndex = 2;
            // 
            // pbKupa
            // 
            pbKupa.Image = Properties.Resources.kupa;
            pbKupa.Location = new Point(389, 38);
            pbKupa.Name = "pbKupa";
            pbKupa.Size = new Size(282, 311);
            pbKupa.SizeMode = PictureBoxSizeMode.Zoom;
            pbKupa.TabIndex = 4;
            pbKupa.TabStop = false;
            // 
            // lblEnYuksekSkorKupa
            // 
            lblEnYuksekSkorKupa.AutoSize = true;
            lblEnYuksekSkorKupa.ForeColor = SystemColors.ButtonHighlight;
            lblEnYuksekSkorKupa.Location = new Point(594, 362);
            lblEnYuksekSkorKupa.Name = "lblEnYuksekSkorKupa";
            lblEnYuksekSkorKupa.Size = new Size(23, 28);
            lblEnYuksekSkorKupa.TabIndex = 3;
            lblEnYuksekSkorKupa.Text = "0";
            // 
            // lblEnYuksekSkorKupaYazisi
            // 
            lblEnYuksekSkorKupaYazisi.AutoSize = true;
            lblEnYuksekSkorKupaYazisi.ForeColor = SystemColors.ButtonHighlight;
            lblEnYuksekSkorKupaYazisi.Location = new Point(436, 362);
            lblEnYuksekSkorKupaYazisi.Name = "lblEnYuksekSkorKupaYazisi";
            lblEnYuksekSkorKupaYazisi.Size = new Size(152, 28);
            lblEnYuksekSkorKupaYazisi.TabIndex = 3;
            lblEnYuksekSkorKupaYazisi.Text = "En Yüksek Skor :";
            // 
            // pbAraba3
            // 
            pbAraba3.Image = Properties.Resources.araba7;
            pbAraba3.Location = new Point(605, 106);
            pbAraba3.Name = "pbAraba3";
            pbAraba3.Size = new Size(92, 191);
            pbAraba3.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba3.TabIndex = 3;
            pbAraba3.TabStop = false;
            // 
            // pbAraba2
            // 
            pbAraba2.Image = Properties.Resources.araba6;
            pbAraba2.Location = new Point(259, 373);
            pbAraba2.Name = "pbAraba2";
            pbAraba2.Size = new Size(84, 186);
            pbAraba2.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba2.TabIndex = 3;
            pbAraba2.TabStop = false;
            // 
            // pbAraba4
            // 
            pbAraba4.Image = Properties.Resources.araba3;
            pbAraba4.Location = new Point(905, 198);
            pbAraba4.Name = "pbAraba4";
            pbAraba4.Size = new Size(81, 151);
            pbAraba4.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba4.TabIndex = 3;
            pbAraba4.TabStop = false;
            // 
            // pbArabam
            // 
            pbArabam.Image = Properties.Resources.araba8;
            pbArabam.Location = new Point(484, 745);
            pbArabam.Name = "pbArabam";
            pbArabam.Size = new Size(79, 127);
            pbArabam.SizeMode = PictureBoxSizeMode.Zoom;
            pbArabam.TabIndex = 3;
            pbArabam.TabStop = false;
            // 
            // pbPatlama
            // 
            pbPatlama.BackColor = Color.Transparent;
            pbPatlama.Image = Properties.Resources.explosion;
            pbPatlama.Location = new Point(467, 649);
            pbPatlama.Name = "pbPatlama";
            pbPatlama.Size = new Size(109, 90);
            pbPatlama.SizeMode = PictureBoxSizeMode.Zoom;
            pbPatlama.TabIndex = 3;
            pbPatlama.TabStop = false;
            // 
            // pbAraba1
            // 
            pbAraba1.Image = Properties.Resources.araba4;
            pbAraba1.Location = new Point(90, 0);
            pbAraba1.Name = "pbAraba1";
            pbAraba1.Size = new Size(65, 136);
            pbAraba1.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba1.TabIndex = 3;
            pbAraba1.TabStop = false;
            // 
            // pbYol
            // 
            pbYol.Image = Properties.Resources.yol;
            pbYol.Location = new Point(5, -791);
            pbYol.Name = "pbYol";
            pbYol.Size = new Size(1029, 1672);
            pbYol.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYol.TabIndex = 0;
            pbYol.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(40, 899);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 3;
            label1.Text = "Kazanılan Puan :";
            // 
            // lblKazanilanPuan
            // 
            lblKazanilanPuan.AutoSize = true;
            lblKazanilanPuan.ForeColor = SystemColors.Control;
            lblKazanilanPuan.Location = new Point(198, 899);
            lblKazanilanPuan.Name = "lblKazanilanPuan";
            lblKazanilanPuan.Size = new Size(23, 28);
            lblKazanilanPuan.TabIndex = 3;
            lblKazanilanPuan.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(40, 945);
            label2.Name = "label2";
            label2.Size = new Size(152, 28);
            label2.TabIndex = 3;
            label2.Text = "En Yüksek Skor :";
            // 
            // lblEnYuksekSkor
            // 
            lblEnYuksekSkor.AutoSize = true;
            lblEnYuksekSkor.ForeColor = SystemColors.Control;
            lblEnYuksekSkor.Location = new Point(198, 945);
            lblEnYuksekSkor.Name = "lblEnYuksekSkor";
            lblEnYuksekSkor.Size = new Size(23, 28);
            lblEnYuksekSkor.TabIndex = 3;
            lblEnYuksekSkor.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1134, 1013);
            Controls.Add(lblEnYuksekSkor);
            Controls.Add(lblKazanilanPuan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlYarisAlani);
            Controls.Add(btnOyunuBaslat);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            pnlYarisAlani.ResumeLayout(false);
            pnlYarisAlani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbKupa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArabam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPatlama).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYol).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnOyunuBaslat;
        private System.Windows.Forms.Timer tmrHareket;
        private Panel pnlYarisAlani;
        private PictureBox pbYol;
        private PictureBox pbAraba3;
        private PictureBox pbAraba2;
        private PictureBox pbAraba4;
        private PictureBox pbArabam;
        private PictureBox pbAraba1;
        private PictureBox pbPatlama;
        private Label label1;
        private Label lblKazanilanPuan;
        private Label label2;
        private Label lblEnYuksekSkor;
        private PictureBox pbKupa;
        private Label lblEnYuksekSkorKupa;
        private Label lblEnYuksekSkorKupaYazisi;
    }
}
