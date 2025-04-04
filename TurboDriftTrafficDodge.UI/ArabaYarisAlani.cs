using System.Configuration;
using System.Media;
using TurboDriftTrafficDodge.UI.Models;

namespace TurboDriftTrafficDodge.UI
{
    public partial class ArabaYarisAlani : Form
    {

        private GirisEkrani GirisEkraniFormu;
        public ArabaYarisAlani(GirisEkrani girisEkraniFormu)
        {
            InitializeComponent();
            YeniOyun();
            GirisEkraniFormu = girisEkraniFormu;
        }
        public ArabaYarisAlani()
        {
            InitializeComponent();
            YeniOyun();
        }

        Random rnd = new Random();

        double kazanilanPuan = 0;
        double leveleGoreArtisMiktari = 0;
        int arabalarinHareketHizi;
        int arabaminHareketHizi = 10;
        int yolHizi;
        bool sagHareket = false;
        bool solHareket = false;

        List<Oyuncu> oyuncular = JSONDosya.Oku();

        public void OyunculariTabloyaEkle()
        {
            foreach (var oyuncu in oyuncular)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = oyuncu.KullaniciAdi;
                listViewItem.SubItems.Add(oyuncu.Zorluk.ToString());
                listViewItem.SubItems.Add(oyuncu.Skor.ToString());
                lstvOyuncular.Items.Add(listViewItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            TabloOlustur();
            OyunculariTabloyaEkle();

        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            OyunuBaslat();
        }

        private void OyunuBaslat()
        {
            SesCal();
            tmrHareket.Start();
            btnOyunuBaslat.Visible = false;

        }

        private void tmrHareket_Tick(object sender, EventArgs e)
        {
            lblKazanilanPuan.Text = ((int)kazanilanPuan).ToString();
            kazanilanPuan += leveleGoreArtisMiktari;

            //Level sistemi 
            switch (oyuncular.Last().Zorluk)
            {
                case "Kolaydan Zora":
                    if (kazanilanPuan < 250)
                    {
                        arabalarinHareketHizi = 5;
                        yolHizi = 5;
                        leveleGoreArtisMiktari = 0.2;
                    }
                    else if (kazanilanPuan >= 250 && kazanilanPuan < 750)
                    {
                        arabalarinHareketHizi = 7;
                        yolHizi = 7;
                        leveleGoreArtisMiktari = 0.4;
                    }
                    else if (kazanilanPuan >= 750 && kazanilanPuan < 1500)
                    {
                        arabalarinHareketHizi = 10;
                        yolHizi = 10;
                        leveleGoreArtisMiktari = 0.6;
                    }
                    else if (kazanilanPuan >= 1500 && kazanilanPuan < 2250)
                    {
                        arabalarinHareketHizi = 13;
                        yolHizi = 13;
                        leveleGoreArtisMiktari = 0.8;
                    }
                    else if (kazanilanPuan >= 2250)
                    {
                        arabalarinHareketHizi = 15;
                        yolHizi = 15;
                        leveleGoreArtisMiktari = 1;
                    }
                    break;
                case "�ok Kolay":
                    arabalarinHareketHizi = 5;
                    yolHizi = 5;
                    leveleGoreArtisMiktari = 0.2;
                    break;
                case "Kolay":
                    arabalarinHareketHizi = 7;
                    yolHizi = 7;
                    leveleGoreArtisMiktari = 0.4;
                    break;
                case "Orta":
                    arabalarinHareketHizi = 10;
                    yolHizi = 10;
                    leveleGoreArtisMiktari = 0.6;
                    break;
                case "Zor":
                    arabalarinHareketHizi = 13;
                    yolHizi = 13;
                    leveleGoreArtisMiktari = 0.8;
                    break;
                case "�ok Zor":
                    arabalarinHareketHizi = 15;
                    yolHizi = 15;
                    leveleGoreArtisMiktari = 1;
                    break;
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
            int rastgeleAraba = rnd.Next(1, 10);
            pbAraba.Top = rnd.Next(0, 150) * (-1);

            switch (rastgeleAraba)
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

        private void ListViewGuncelle()
        {
            lstvOyuncular.Clear();
            TabloOlustur();
            OyunculariTabloyaEkle();
        }

        private void OyunuBitir()
        {
            //E�er benim arabam ba�ka bir araba yada engel ile ayn� konuma girerse(�arparsa) oyun sonlan�r.
            if ((pbArabam.Bounds.IntersectsWith(pbAraba1.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba2.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba3.Bounds) || pbArabam.Bounds.IntersectsWith(pbAraba4.Bounds)))
            {
                Oyuncu oynayanOyuncu = oyuncular.Last(); //Son oyuncumu al�r.
                oynayanOyuncu.Skor = ((int)kazanilanPuan);
                JSONDosya.OyuncuGuncelle(oyuncular);
                ListViewGuncelle();


                SesCal("kazasesi.wav");
                btnOyunuBaslat.Visible = true;


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
                DialogResult dr = MessageBox.Show($"Tebrikler Puan�n�z : {((int)kazanilanPuan)} \nYeni bir yar�� yapmak ister misiniz?", "Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    YeniOyun();
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

            solHareket = false;
            sagHareket = false;
            pbPatlama.Visible = false;
            KupaGoster(false);
            kazanilanPuan = 0;
        }
        public SoundPlayer sp;

        /// <summary>
        /// Parametre olarak g�nderilen ses ad�n� �alan metod (!Dosyan�n bulundu�u dizinde Sesler klas�r�n�n i�inde olmal�)
        /// </summary>
        private void SesCal()
        {
            string sesDosyaYolu = Path.Combine(Application.StartupPath, "Sesler", $"{GirisEkraniFormu.cbMuzik.SelectedItem}.wav");

            if (sesDosyaYolu != null)
            {
                sp = new SoundPlayer(sesDosyaYolu);
                sp.Play();
            }
        }

        private void SesCal(string ses)
        {
            string sesDosyaYolu = Path.Combine(Application.StartupPath, "Sesler", ses);

            sp = new SoundPlayer(sesDosyaYolu);
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

        private void TabloOlustur()
        {
            lstvOyuncular.View = View.Details;
            lstvOyuncular.GridLines = true;
            lstvOyuncular.Columns.Add("Oyuncu", 125);
            lstvOyuncular.Columns.Add("Zorluk", 100);
            lstvOyuncular.Columns.Add("Skor", 100);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            tmrHareket.Stop();

            Menu menu = new Menu(this);
            menu.ShowDialog();
        }
    }
}
