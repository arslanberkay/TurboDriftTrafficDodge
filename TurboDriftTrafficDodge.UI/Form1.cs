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
        int arabaHareketHizi = 5;
        int yolHizi = 5;

        private void Form1_Load(object sender, EventArgs e)
        {
            pbPatlama.Visible = false;
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
            pbYol.Top += yolHizi;
            if (pbYol.Top > pnlYarisAlani.Height)
            {
                pbYol.Top = pbYol.Height * (-1);
            }

            pbAraba1.Top += arabaHareketHizi;
            pbAraba2.Top += arabaHareketHizi;
            pbAraba3.Top += arabaHareketHizi;
            pbAraba4.Top += arabaHareketHizi;
            pbAraba5.Top += arabaHareketHizi;

            if (pbAraba1.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba1);
            }
            if (pbAraba2.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba2);
            }
            if (pbAraba3.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba3);
            }
            if (pbAraba4.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba4);
            }
            if (pbAraba5.Top > pnlYarisAlani.Height)
            {
                ArabaYenile(pbAraba5);
            }

            OyunuBitir();
        }

        /// <summary>
        /// Yol aktýkça giden arabalar yerine gelecek olan arabanýn konum ve tipini belirleyen metod
        /// </summary>
        /// <param name="pbAraba"></param>
        private void ArabaYenile(PictureBox pbAraba)
        {
            int rasgeleAraba = rnd.Next(1, 10);
            int rasgeleKonum = rnd.Next(1, 3);

            pbAraba.Top = rnd.Next(0, 150) * (-1);

            if (rasgeleKonum == 1)
            {
                pbAraba.Left += rnd.Next(0, 50);
            }
            else
            {
                pbAraba.Left -= rnd.Next(0, 50);
            }

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
            //Eðer benim arabam baþka bir araba yada engel ile ayný konuma girerse(çarparsa) oyun sonlanýr.
            if ((pbArabam.Bounds.IntersectsWith(pbAraba1.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba2.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba3.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba4.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba5.Bounds)))
            {
                pbPatlama.Visible = true;
                tmrHareket.Stop();
            }
        }


    }
}
