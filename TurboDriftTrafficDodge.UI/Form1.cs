using System.Configuration;
using System.Media;

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
        int arabalarinHareketHizi;
        int arabaminHareketHizi = 10;
        int yolHizi;
        bool sagHareket = false;
        bool solHareket = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            pbPatlama.Visible = false;
            this.KeyPreview = true;
            KupaGoster(false);
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            SesCal("oyunsesi.wav");
            KupaGoster(false);
            tmrHareket.Start();
        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            //Puan� anl�k olarak g�sterir.
            kazanilanPuan++;
            lblKazanilanPuan.Text = kazanilanPuan.ToString();

            //Level sistemi
            if (kazanilanPuan < 500)
            {
                arabalarinHareketHizi = 5;
                yolHizi = 5;
            }
            else if (kazanilanPuan > 500 && kazanilanPuan < 1250)
            {
                arabalarinHareketHizi = 7;
                yolHizi = 7;
            }
            else if (kazanilanPuan > 1250 && kazanilanPuan < 2000)
            {
                arabalarinHareketHizi = 10;
                yolHizi = 10;
            }
            else if (kazanilanPuan > 2000)
            {
                arabalarinHareketHizi = 13;
                yolHizi = 13;
            }

            //Araba h�zlar�
            pbAraba1.Top += arabalarinHareketHizi;
            pbAraba2.Top += arabalarinHareketHizi;
            pbAraba3.Top += arabalarinHareketHizi;
            pbAraba4.Top += arabalarinHareketHizi;

            //Yol h�z�
            pbYol.Top += yolHizi;
            if (pbYol.Top > pnlYarisAlani.Height) //Yol yenilenmesi
            {
                pbYol.Top = pbYol.Height * (-1);
            }

            //Araba hareketleri ve k�s�tlamalar�
            if (solHareket && pbArabam.Left > 0)
            {
                pbArabam.Left -= arabaminHareketHizi;
            }
            if (sagHareket && pbArabam.Right < pnlYarisAlani.Width)
            {
                pbArabam.Left += arabaminHareketHizi;
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
                SesCal("kazasesi.wav");

                //Patlama efekti ayarlar�
                pbPatlama.Visible = true;
                pbArabam.Controls.Add(pbPatlama); //Arabam nerdeyse patlama efektini oraya almak i�in
                pbPatlama.Location = new Point(-15, -15); //Arabam�n �zerindeki konumunu belirledim.
                pbPatlama.BringToFront();

                if (Convert.ToInt32(lblKazanilanPuan.Text) > Settings1.Default.enYuksekSkor)
                {
                    Settings1.Default.enYuksekSkor = Convert.ToInt32(lblKazanilanPuan.Text);
                    lblEnYuksekSkor.Text = lblKazanilanPuan.Text;
                    lblEnYuksekSkorKupa.Text = lblKazanilanPuan.Text;
                    KupaGoster(true);
                }

                tmrHareket.Stop();

                //Yeni oyun 
                DialogResult dr = MessageBox.Show($"Tebrikler Puan�n�z : {kazanilanPuan} \nYeni bir yar�� yapmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    YeniOyun();
                    OyunuBaslat();
                }
                else
                {
                    Application.Exit();
                }
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


        private void YeniOyun()
        {
            pbArabam.Location = new Point(493, 642);
            pbAraba1.Location = new Point(rnd.Next(200), rnd.Next(100));
            pbAraba2.Location = new Point(rnd.Next(250, 400), rnd.Next(100));
            pbAraba3.Location = new Point(rnd.Next(450, 600), rnd.Next(100));
            pbAraba4.Location = new Point(rnd.Next(650, 800), rnd.Next(100));

            pbPatlama.Visible = false;
            kazanilanPuan = 0;
        }

        /// <summary>
        /// Parametre olarak g�nderilen ses ad�n� �alan metod (!Dosyan�n bulundu�u dizinde Sesler klas�r�n�n i�inde olmal�)
        /// </summary>
        /// <param name="ses"></param>
        private void SesCal(string ses)
        {
            string sesDosyaYolu = Path.Combine(Application.StartupPath, "Sesler", ses);

            SoundPlayer sp = new SoundPlayer(sesDosyaYolu);
            sp.Play();
        }

        /// <summary>
        /// Kupa ve en y�ksek skor ile ilgili bilgilerin ve resimlerin g�r�n�rl���n� ayarlayan metod
        /// </summary>
        /// <param name="gorunurluk"></param>
        private void KupaGoster(bool gorunurluk)
        {
            pbKupa.Visible = gorunurluk;
            lblEnYuksekSkorKupaYazisi.Visible = gorunurluk;
            lblEnYuksekSkorKupa.Visible = gorunurluk;
        }



    }
}
