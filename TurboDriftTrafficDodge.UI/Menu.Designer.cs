namespace TurboDriftTrafficDodge.UI
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btnYeniOyun = new Button();
            btnAnaSayfa = new Button();
            btnCikis = new Button();
            btnSesKapa = new Button();
            imglSes = new ImageList(components);
            SuspendLayout();
            // 
            // btnYeniOyun
            // 
            btnYeniOyun.BackColor = Color.Gray;
            btnYeniOyun.Font = new Font("Microsoft Sans Serif", 12F);
            btnYeniOyun.ForeColor = SystemColors.ControlLightLight;
            btnYeniOyun.Location = new Point(107, 73);
            btnYeniOyun.Margin = new Padding(4);
            btnYeniOyun.Name = "btnYeniOyun";
            btnYeniOyun.Size = new Size(219, 66);
            btnYeniOyun.TabIndex = 0;
            btnYeniOyun.Text = "Yeni Oyun";
            btnYeniOyun.UseVisualStyleBackColor = false;
            btnYeniOyun.Click += btnYeniOyun_Click;
            // 
            // btnAnaSayfa
            // 
            btnAnaSayfa.BackColor = Color.Gray;
            btnAnaSayfa.Font = new Font("Microsoft Sans Serif", 12F);
            btnAnaSayfa.ForeColor = SystemColors.ControlLightLight;
            btnAnaSayfa.Location = new Point(107, 147);
            btnAnaSayfa.Margin = new Padding(4);
            btnAnaSayfa.Name = "btnAnaSayfa";
            btnAnaSayfa.Size = new Size(219, 66);
            btnAnaSayfa.TabIndex = 0;
            btnAnaSayfa.Text = "Ana Sayfa";
            btnAnaSayfa.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Gray;
            btnCikis.Font = new Font("Microsoft Sans Serif", 12F);
            btnCikis.ForeColor = SystemColors.ControlLightLight;
            btnCikis.Location = new Point(107, 221);
            btnCikis.Margin = new Padding(4);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(219, 66);
            btnCikis.TabIndex = 0;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            // 
            // btnSesKapa
            // 
            btnSesKapa.BackColor = Color.Gray;
            btnSesKapa.ImageIndex = 0;
            btnSesKapa.ImageList = imglSes;
            btnSesKapa.Location = new Point(364, 12);
            btnSesKapa.Name = "btnSesKapa";
            btnSesKapa.Size = new Size(58, 54);
            btnSesKapa.TabIndex = 1;
            btnSesKapa.UseVisualStyleBackColor = false;
            btnSesKapa.Click += btnSesKapa_Click;
            // 
            // imglSes
            // 
            imglSes.ColorDepth = ColorDepth.Depth32Bit;
            imglSes.ImageStream = (ImageListStreamer)resources.GetObject("imglSes.ImageStream");
            imglSes.TransparentColor = Color.Transparent;
            imglSes.Images.SetKeyName(0, "2203528_lound_sound_speaker_volume_icon.png");
            imglSes.Images.SetKeyName(1, "2203527_mute_sound_speaker_volume_icon.png");
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(433, 372);
            Controls.Add(btnSesKapa);
            Controls.Add(btnCikis);
            Controls.Add(btnAnaSayfa);
            Controls.Add(btnYeniOyun);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYeniOyun;
        private Button btnAnaSayfa;
        private Button btnCikis;
        private Button btnSesKapa;
        private ImageList imglSes;
    }
}