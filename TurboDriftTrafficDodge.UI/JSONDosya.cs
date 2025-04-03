using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace TurboDriftTrafficDodge.UI
{
    public class JSONDosya
    {
        public static void Kaydet(List<Oyuncu> yeniOyuncular)
        {
            //Dosya yolu oluşturma
            string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "OyuncuData");
            string jsonDosyaYolu = Path.Combine(hedefDizin, "oyuncu.json");

            //Klasör Kontrolü
            if (!Directory.Exists(hedefDizin))
            {
                Directory.CreateDirectory(hedefDizin);
            }

            List<Oyuncu> oyuncular;

            //Dosya Kontrolü - Json Dosyasının okunması ve mevcut verilerin alınması
            if (!File.Exists(jsonDosyaYolu))
            {
                oyuncular = new List<Oyuncu>(); //oyuncular boş liste olarak oluşturulur.
            }
            else
            {
                string kayitliOyuncularJsonu = File.ReadAllText(jsonDosyaYolu); //Dosya içeriği okunuyor.
                var kayitliOyuncular = JsonSerializer.Deserialize<List<Oyuncu>>(kayitliOyuncularJsonu); //Json formatındaki metin Oyuncu türündeki nesnelerin listesine dönüştürülüyor.

                if (kayitliOyuncularJsonu == null)
                {
                    return;
                }

                oyuncular = kayitliOyuncular; //Okunan veriler oyuncular listesine aktarılıyor.
            }

            //Yeni oyuncuları listeye eklemek
            oyuncular.AddRange(yeniOyuncular); //Yeni oyuncular listesindeki yeni oyuncuları oyuncular listesine ekler.

            //Listeyi json olarak kaydetme
            var jsonAyarlar = new JsonSerializerOptions { WriteIndented = true }; //Json'un güzel okunabilir olmasını sağlar.
            string jsonVeri = JsonSerializer.Serialize(oyuncular, jsonAyarlar);
            File.WriteAllText(jsonDosyaYolu, jsonVeri);
        }

        public static List<Oyuncu> Oku()
        {
            //Dosya yolu oluşturma
            string projeDizini = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string hedefDizin = Path.Combine(projeDizini, @"..\..\..\", "OyuncuData");
            string jsonDosyaYolu = Path.Combine(hedefDizin, "oyuncu.json");

            //Klasör Kontrolü
            if (!Directory.Exists(hedefDizin))
            {
                Directory.CreateDirectory(hedefDizin);
            }

            if (!File.Exists(jsonDosyaYolu))
            {
                File.WriteAllText(jsonDosyaYolu, "{}");
            }

            //Json Verisini Okuma
            string jsonVeri = File.ReadAllText(jsonDosyaYolu); //Json dosyasının tamamını okur.
            var jsonAyarlar = new JsonSerializerOptions { WriteIndented = true };
            var oyuncular = JsonSerializer.Deserialize<List<Oyuncu>>(jsonVeri,jsonAyarlar);

            return oyuncular;
        }



    }
}
