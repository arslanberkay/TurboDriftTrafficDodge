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
            pnlYarisAlani = new Panel();
            pbArabam = new PictureBox();
            pbAraba5 = new PictureBox();
            pbAraba4 = new PictureBox();
            pbAraba3 = new PictureBox();
            pbAraba2 = new PictureBox();
            pbAraba1 = new PictureBox();
            btnOyunuBaslat = new Button();
            tmrHareket = new System.Windows.Forms.Timer(components);
            pnlYarisAlani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbArabam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba1).BeginInit();
            SuspendLayout();
            // 
            // pnlYarisAlani
            // 
            pnlYarisAlani.BackgroundImage = Properties.Resources.yol;
            pnlYarisAlani.Controls.Add(pbArabam);
            pnlYarisAlani.Controls.Add(pbAraba5);
            pnlYarisAlani.Controls.Add(pbAraba4);
            pnlYarisAlani.Controls.Add(pbAraba3);
            pnlYarisAlani.Controls.Add(pbAraba2);
            pnlYarisAlani.Controls.Add(pbAraba1);
            pnlYarisAlani.Location = new Point(38, 0);
            pnlYarisAlani.Margin = new Padding(4);
            pnlYarisAlani.Name = "pnlYarisAlani";
            pnlYarisAlani.Size = new Size(1656, 777);
            pnlYarisAlani.TabIndex = 0;
            // 
            // pbArabam
            // 
            pbArabam.BackColor = Color.Transparent;
            pbArabam.Image = Properties.Resources.araba9;
            pbArabam.Location = new Point(741, 569);
            pbArabam.Margin = new Padding(4);
            pbArabam.Name = "pbArabam";
            pbArabam.Size = new Size(95, 165);
            pbArabam.SizeMode = PictureBoxSizeMode.Zoom;
            pbArabam.TabIndex = 1;
            pbArabam.TabStop = false;
            // 
            // pbAraba5
            // 
            pbAraba5.BackColor = Color.Transparent;
            pbAraba5.Image = Properties.Resources.araba7;
            pbAraba5.Location = new Point(1456, 114);
            pbAraba5.Margin = new Padding(4);
            pbAraba5.Name = "pbAraba5";
            pbAraba5.Size = new Size(95, 165);
            pbAraba5.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba5.TabIndex = 1;
            pbAraba5.TabStop = false;
            // 
            // pbAraba4
            // 
            pbAraba4.BackColor = Color.Transparent;
            pbAraba4.Image = Properties.Resources.araba3;
            pbAraba4.Location = new Point(1145, 65);
            pbAraba4.Margin = new Padding(4);
            pbAraba4.Name = "pbAraba4";
            pbAraba4.Size = new Size(95, 165);
            pbAraba4.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba4.TabIndex = 1;
            pbAraba4.TabStop = false;
            // 
            // pbAraba3
            // 
            pbAraba3.BackColor = Color.Transparent;
            pbAraba3.Image = Properties.Resources.araba8;
            pbAraba3.Location = new Point(877, 52);
            pbAraba3.Margin = new Padding(4);
            pbAraba3.Name = "pbAraba3";
            pbAraba3.Size = new Size(95, 165);
            pbAraba3.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba3.TabIndex = 1;
            pbAraba3.TabStop = false;
            // 
            // pbAraba2
            // 
            pbAraba2.BackColor = Color.Transparent;
            pbAraba2.Image = Properties.Resources.araba4;
            pbAraba2.Location = new Point(337, 165);
            pbAraba2.Margin = new Padding(4);
            pbAraba2.Name = "pbAraba2";
            pbAraba2.Size = new Size(95, 165);
            pbAraba2.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba2.TabIndex = 1;
            pbAraba2.TabStop = false;
            // 
            // pbAraba1
            // 
            pbAraba1.BackColor = Color.Transparent;
            pbAraba1.Image = Properties.Resources.araba5;
            pbAraba1.Location = new Point(147, 36);
            pbAraba1.Margin = new Padding(4);
            pbAraba1.Name = "pbAraba1";
            pbAraba1.Size = new Size(95, 165);
            pbAraba1.SizeMode = PictureBoxSizeMode.Zoom;
            pbAraba1.TabIndex = 1;
            pbAraba1.TabStop = false;
            // 
            // btnOyunuBaslat
            // 
            btnOyunuBaslat.Location = new Point(617, 785);
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
            tmrHareket.Tick += tmrHareket_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1741, 911);
            Controls.Add(btnOyunuBaslat);
            Controls.Add(pnlYarisAlani);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlYarisAlani.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbArabam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAraba1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlYarisAlani;
        private PictureBox pbArabam;
        private PictureBox pbAraba5;
        private PictureBox pbAraba4;
        private PictureBox pbAraba3;
        private PictureBox pbAraba2;
        private PictureBox pbAraba1;
        private Button btnOyunuBaslat;
        private System.Windows.Forms.Timer tmrHareket;
    }
}
