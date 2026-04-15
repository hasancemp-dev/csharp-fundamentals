using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06._1_ChallengeProject
{
    internal class DosyaYonetimi
    {
        private readonly string _stokDosyasi = "stok.txt";
        private readonly string _logDosyasi = "loglar.txt";

        // Stokları dosyadan okuyup Dictionary'e dönüştürür
        public Dictionary<string, int> StoklariOku()
        {
            var stoklar = new Dictionary<string, int>();

            if (!File.Exists(_stokDosyasi)) return stoklar;

            using (StreamReader sr = new StreamReader(_stokDosyasi, Encoding.UTF8))
            {
                string satir;
                while ((satir = sr.ReadLine()) != null)
                {
                    // Dosyadaki formatımız: "Pamuk Kumaş:150"
                    var parcalar = satir.Split(':');
                    if (parcalar.Length == 2 && int.TryParse(parcalar[1], out int miktar))
                    {
                        stoklar[parcalar[0]] = miktar;
                    }
                }
            }
            return stoklar;
        }

        // Güncel Dictionary'yi alıp dosyaya sıfırdan yazar (Üzerine yazar)
        public void StoklariKaydet(Dictionary<string, int> stoklar)
        {
            using (StreamWriter sw = new StreamWriter(_stokDosyasi, false, Encoding.UTF8)) // false = üzerine yaz
            {
                foreach (var item in stoklar)
                {
                    sw.WriteLine($"{item.Key}:{item.Value}");
                }
            }
        }

        // Yeni bir log satırını dosyanın sonuna ekler (Append)
        public void LogKaydet(IslemTipi islem, string urun, int miktar)
        {
            using (StreamWriter sw = new StreamWriter(_logDosyasi, true, Encoding.UTF8)) // true = sonuna ekle
            {
                string isaret = islem == IslemTipi.Giris ? "+" : "-";
                sw.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm} - {urun} {islem} yapıldı. Adet: {isaret}{miktar}");
            }
        }

        public void LoglariListele()
        {
            if (!File.Exists(_logDosyasi))
            {
                Console.WriteLine("Henüz kayıtlı bir log bulunmuyor.");
                return;
            }
            Console.WriteLine(File.ReadAllText(_logDosyasi));
        }
    }
}
