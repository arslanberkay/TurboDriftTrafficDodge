namespace TurboDriftTrafficDodge.UI
{
    partial class Form2
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
            textBox1 = new TextBox();
            trackBar1 = new TrackBar();
            lblZorlukSeviyesi = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(130, 98);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // btnGirisYap
            // 
            btnGirisYap.ForeColor = SystemColors.ActiveCaptionText;
            btnGirisYap.Location = new Point(130, 265);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(347, 60);
            btnGirisYap.TabIndex = 1;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(130, 151);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 0;
            label2.Text = "Zorluk ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 92);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 34);
            textBox1.TabIndex = 2;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(252, 151);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(225, 56);
            trackBar1.TabIndex = 3;
            // 
            // lblZorlukSeviyesi
            // 
            lblZorlukSeviyesi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblZorlukSeviyesi.ForeColor = SystemColors.Control;
            lblZorlukSeviyesi.Location = new Point(192, 210);
            lblZorlukSeviyesi.Margin = new Padding(4, 0, 4, 0);
            lblZorlukSeviyesi.Name = "lblZorlukSeviyesi";
            lblZorlukSeviyesi.Size = new Size(224, 41);
            lblZorlukSeviyesi.TabIndex = 0;
            lblZorlukSeviyesi.Text = "label1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(731, 568);
            Controls.Add(trackBar1);
            Controls.Add(textBox1);
            Controls.Add(btnGirisYap);
            Controls.Add(lblZorlukSeviyesi);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Araba Yarış Oyunu ";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGirisYap;
        private Label label2;
        private TextBox textBox1;
        private TrackBar trackBar1;
        private Label lblZorlukSeviyesi;
    }
}