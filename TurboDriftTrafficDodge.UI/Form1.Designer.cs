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
            pbAraba3 = new PictureBox();
            pbAraba2 = new PictureBox();
            pbAraba4 = new PictureBox();
            pbPatlama = new PictureBox();
            pbArabam = new PictureBox();
            pbAraba1 = new PictureBox();
            pbAraba5 = new PictureBox();
            pbYol = new PictureBox();
            pnlYarisAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAraba3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPatlama).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArabam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbYol).BeginInit();
            SuspendLayout();
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Location = new Point(618, 831);
            btnOyunuBaslat.Margin = new Padding(4);
            btnOyunuBaslat.Name = "btnOyunuBaslat";
            btnOyunuBaslat.Size = new Size(518, 96);
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
            pnlYarisAlani.Controls.Add(pbAraba3);
            pnlYarisAlani.Controls.Add(pbAraba2);
            pnlYarisAlani.Controls.Add(pbAraba4);
            pnlYarisAlani.Controls.Add(pbPatlama);
            pnlYarisAlani.Controls.Add(pbArabam);
            pnlYarisAlani.Controls.Add(pbAraba1);
            pnlYarisAlani.Controls.Add(pbAraba5);
            pnlYarisAlani.Controls.Add(pbYol);
            pnlYarisAlani.Location = new Point(37, 12);
            pnlYarisAlani.Name = "pnlYarisAlani";
            pnlYarisAlani.Size = new Size(1656, 789);
            pnlYarisAlani.TabIndex = 2;
            // 
            // pbAraba3
            // 
            pbAraba3.Image = Properties.Resources.araba7;
            pbAraba3.Location = new Point(819, 122);
            pbAraba3.Name = "pbAraba3";
            pbAraba3.Size = new Size(65, 136);
            pbAraba3.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba3.TabIndex = 3;
            pbAraba3.TabStop = false;
            // 
            // pbAraba2
            // 
            pbAraba2.Image = Properties.Resources.araba6;
            pbAraba2.Location = new Point(428, 250);
            pbAraba2.Name = "pbAraba2";
            pbAraba2.Size = new Size(84, 186);
            pbAraba2.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba2.TabIndex = 3;
            pbAraba2.TabStop = false;
            // 
            // pbAraba4
            // 
            pbAraba4.Image = Properties.Resources.araba3;
            pbAraba4.Location = new Point(1147, 381);
            pbAraba4.Name = "pbAraba4";
            pbAraba4.Size = new Size(65, 136);
            pbAraba4.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba4.TabIndex = 3;
            pbAraba4.TabStop = false;
            // 
            // pbPatlama
            // 
            pbPatlama.BackColor = Color.Transparent;
            pbPatlama.Image = Properties.Resources.explosion;
            pbPatlama.Location = new Point(819, 592);
            pbPatlama.Name = "pbPatlama";
            pbPatlama.Size = new Size(65, 53);
            pbPatlama.SizeMode = PictureBoxSizeMode.Zoom;
            pbPatlama.TabIndex = 3;
            pbPatlama.TabStop = false;
            // 
            // pbArabam
            // 
            pbArabam.Image = Properties.Resources.araba8;
            pbArabam.Location = new Point(819, 616);
            pbArabam.Name = "pbArabam";
            pbArabam.Size = new Size(65, 136);
            pbArabam.SizeMode = PictureBoxSizeMode.Zoom;
            pbArabam.TabIndex = 3;
            pbArabam.TabStop = false;
            // 
            // pbAraba1
            // 
            pbAraba1.Image = Properties.Resources.araba4;
            pbAraba1.Location = new Point(109, 33);
            pbAraba1.Name = "pbAraba1";
            pbAraba1.Size = new Size(65, 136);
            pbAraba1.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba1.TabIndex = 3;
            pbAraba1.TabStop = false;
            // 
            // pbAraba5
            // 
            pbAraba5.Image = Properties.Resources.araba2;
            pbAraba5.Location = new Point(1427, 64);
            pbAraba5.Name = "pbAraba5";
            pbAraba5.Size = new Size(65, 136);
            pbAraba5.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba5.TabIndex = 3;
            pbAraba5.TabStop = false;
            // 
            // pbYol
            // 
            pbYol.Image = Properties.Resources.yol;
            pbYol.Location = new Point(3, -463);
            pbYol.Name = "pbYol";
            pbYol.Size = new Size(1650, 1600);
            pbYol.SizeMode = PictureBoxSizeMode.StretchImage;
            pbYol.TabIndex = 0;
            pbYol.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 940);
            Controls.Add(pnlYarisAlani);
            Controls.Add(btnOyunuBaslat);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlYarisAlani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAraba3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPatlama).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArabam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbYol).EndInit();
            ResumeLayout(false);
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
        private PictureBox pbAraba5;
        private PictureBox pbPatlama;
    }
}
