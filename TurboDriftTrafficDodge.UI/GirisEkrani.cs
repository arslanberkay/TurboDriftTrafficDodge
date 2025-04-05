using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurboDriftTrafficDodge.UI.Models;

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
            if (tbZorluk.Value == 0 && !chkKolaydanZora.Checked)
            {
                MessageBox.Show("Geçersiz zorluk seviyesi");
                return;
            }

            Oyuncu yeniOyuncu = new Oyuncu();
            yeniOyuncu.KullaniciAdi = txtKullaniciAdi.Text;
            yeniOyuncu.Zorluk = lblZorlukSeviyesi.Text;

            //Kayıtlı oyuncuları getir
            var kayitliOyuncular = JSONDosya.Oku();

            foreach (var kayitliOyuncu in kayitliOyuncular)
            {
                if (kayitliOyuncu.KullaniciAdi == yeniOyuncu.KullaniciAdi)
                {
                    MessageBox.Show("Bu kullanıcı adı daha önce alındı!");
                    return;
                }
            }

            oyuncular.Add(yeniOyuncu);
            JSONDosya.YeniOyuncuKaydet(oyuncular);

            ArabaYarisAlani form1 = new ArabaYarisAlani(); //Form1 e FOrm2 yi gönderiyoruz
            form1.ShowDialog();
            this.Hide();
        }

        private void tbZorluk_Scroll(object sender, EventArgs e)
        {
            if (chkKolaydanZora.Checked)
            {
                lblZorlukSeviyesi.Visible = false;
               
            }
            else
            {
                lblZorlukSeviyesi.Visible = true;
            }

            switch (tbZorluk.Value)
            {
                case int zorlukSeviyesi when (zorlukSeviyesi > 0 && zorlukSeviyesi <= 20):
                    lblZorlukSeviyesi.Text = "Çok Kolay";
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

        private void chkKolaydanZora_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKolaydanZora.Checked)
            {
                lblZorlukSeviyesi.Text = chkKolaydanZora.Text;
                lblZorlukSeviyesi.Visible = false;
                tbZorluk.Value = 0;
                tbZorluk.Enabled = false;
            }
            else
            {
                lblZorlukSeviyesi.Text = string.Empty;
                tbZorluk.Enabled = true;
            }

        }
    }
}