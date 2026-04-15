using Day06._1_ExtraPractice.InsanKaynaklari.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Day06._1_ExtraPractice.InsanKaynaklari.FileMan
{
    internal class DosyaYonetimi : IVeriKaydedilebilir
    {
        private readonly string _dosyaYolu = "bordrolar.txt"; 
        public void BordroYazdir(string mesaj)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(_dosyaYolu, true, Encoding.UTF8))
                {
                    sw.WriteLine("================ BORDRO KAYDI ================");
                    sw.WriteLine($"Kayıt Tarihi: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                    sw.WriteLine($"İçerik: {mesaj}");
                    sw.WriteLine("----------------------------------------------");
                    sw.WriteLine(); 
                }
                Console.WriteLine("Bordro başarıyla 'bordrolar.txt' dosyasına kaydedildi.");
            }
            catch (Exception ex)
            { 
                throw new Exception($"Dosya yazma işlemi sırasında bir hata oluştu: {ex.Message}");
            }
        }
        public void BordrolariListele()
        { 
            if (!File.Exists(_dosyaYolu))
            {
                Console.WriteLine("Henüz kayıtlı bir bordro dosyası bulunamadı.");
                return; 
            }

            try
            { 
                using (StreamReader sr = new StreamReader(_dosyaYolu, Encoding.UTF8))
                {
                    Console.WriteLine("\n--- KAYITLI BORDROLAR ---");
                     
                    string satir;
                     
                    while ((satir = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(satir);
                    }

                    Console.WriteLine("-------------------------\n");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Dosya okunurken bir hata oluştu: {ex.Message}");
            }
        }
    }
}
