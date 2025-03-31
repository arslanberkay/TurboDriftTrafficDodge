using System.Configuration;

namespace TurboDriftTrafficDodge.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();

        int kazanilanPuan = 0;
        int arabaHareketHizi = 10;
        int yolHizi = 10;
        bool sagHareket = false;
        bool solHareket = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            pbPatlama.Visible = false;
            this.KeyPreview = true;
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            tmrHareket.Start();
        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            //Puan� anl�k olarak g�sterir.
            kazanilanPuan++;
            lblKazanilanPuan.Text = kazanilanPuan.ToString();

            pbYol.Top += yolHizi;
            if (pbYol.Top > pnlYarisAlani.Height)
            {
                pbYol.Top = pbYol.Height * (-1);
            }

            pbAraba1.Top += arabaHareketHizi;
            pbAraba2.Top += arabaHareketHizi;
            pbAraba3.Top += arabaHareketHizi;
            pbAraba4.Top += arabaHareketHizi;


            if (sagHareket && pbArabam.Left > 0)
            {
                pbArabam.Left += arabaHareketHizi;
            }
            if (solHareket && pbArabam.Right < pnlYarisAlani.Width)
            {
                pbArabam.Left -= arabaHareketHizi;
            }

            if (pbAraba1.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba1);
                pbAraba1.Left = rnd.Next(200);
            }
            if (pbAraba2.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba2);
                pbAraba2.Left = rnd.Next(250, 400);
            }
            if (pbAraba3.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba3);
                pbAraba3.Left = rnd.Next(450, 600);
            }
            if (pbAraba4.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba4);
                pbAraba4.Left = rnd.Next(650, 850);
            }
            OyunuBitir();
        }

        /// <summary>
        /// Yol akt�k�a giden arabalar yerine gelecek olan araban�n konum ve tipini belirleyen metod
        /// </summary>
        /// <param name="pbAraba"></param>
        private void ArabaYenile(PictureBox pbAraba)
        {
            int rasgeleAraba = rnd.Next(1, 10);
            pbAraba.Top = rnd.Next(0, 150) * (-1);

            switch (rasgeleAraba)
            {
                case 1:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba2;
                    break;
                case 2:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba3;
                    break;
                case 3:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba4;
                    break;
                case 4:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba5;
                    break;
                case 5:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba6;
                    break;
                case 6:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba7;
                    break;
                case 7:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba8;
                    break;
                case 8:
                    pbAraba.Image = TurboDriftTrafficDodge.UI.Properties.Resources.araba9;
                    break;
            }
        }

        private void OyunuBitir()
        {
            //E�er benim arabam ba�ka bir araba yada engel ile ayn� konuma girerse(�arparsa) oyun sonlan�r.
            if ((pbArabam.Bounds.IntersectsWith(pbAraba1.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba2.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba3.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba4.Bounds)))
            {
                pbPatlama.Visible = true;
                tmrHareket.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                solHareket = true;
            }
            if (e.KeyCode == Keys.D)
            {
                sagHareket = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                solHareket = false;
            }
            if (e.KeyCode == Keys.D)
            {
                sagHareket = false;
            }
        }


    }
}
