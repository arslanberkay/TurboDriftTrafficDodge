using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboDriftTrafficDodge.UI
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        List<Oyuncu> oyuncular = new List<Oyuncu>();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanıcı adı boş olmamalıdır!");
                return;
            }
            if (tbZorluk.Value == 0)
            {
                MessageBox.Show("Geçersiz zorluk seviyesi");
                return;
            }

            Oyuncu yeniOyuncu = new Oyuncu();
            yeniOyuncu.KullaniciAdi = txtKullaniciAdi.Text;
            yeniOyuncu.Zorluk = ZorlukSeviyesiBelirle(lblZorlukSeviyesi.Text);

            //Jsonda kayıtlı olan oyuncuları getir ve kontrol et içinde aynı kullanıcı adında olamaz!
            oyuncular.Add(yeniOyuncu);

            ArabaYarisAlani form1 = new ArabaYarisAlani(this); //Form1 e FOrm2 yi gönderiyoruz
            form1.ShowDialog();
            this.Hide();
        }

        private void tbZorluk_Scroll(object sender, EventArgs e)
        {
            switch (tbZorluk.Value)
            {
                case int zorlukSeviyesi when (zorlukSeviyesi > 0 && zorlukSeviyesi <= 20):
                    lblZorlukSeviyesi.Text = "Çok kolay";
                    break;
                case int zorlukSeviyesi when (zorlukSeviyesi > 20 && zorlukSeviyesi <= 40):
                    lblZorlukSeviyesi.Text = "Kolay";
                    break;
                case int zorlukSeviyesi when (zorlukSeviyesi > 40 && zorlukSeviyesi <= 60):
                    lblZorlukSeviyesi.Text = "Orta";
                    break;
                case int zorlukSeviyesi when (zorlukSeviyesi > 60 && zorlukSeviyesi <= 80):
                    lblZorlukSeviyesi.Text = "Zor";
                    break;
                case int zorlukSeviyesi when (zorlukSeviyesi > 80 && zorlukSeviyesi <= 100):
                    lblZorlukSeviyesi.Text = "Çok Zor";
                    break;
            }
        }

        /// <summary>
        /// İçine gönderilen zorluk seviyesini enum tipinde geriye döndüren metod
        /// </summary>
        /// <param name="zorlukSeviyesi"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public ZorlukSeviyesi ZorlukSeviyesiBelirle(string zorlukSeviyesi)
        {

            return zorlukSeviyesi switch
            {
                "Çok kolay" => ZorlukSeviyesi.CokKolay,
                "Kolay" => ZorlukSeviyesi.Kolay,
                "Orta" => ZorlukSeviyesi.Orta,
                "Zor" => ZorlukSeviyesi.Zor,
                "Çok Zor" => ZorlukSeviyesi.CokZor,
                _ => throw new Exception("Geçersiz zorluk seviyesi")
            };

        }




    }
}