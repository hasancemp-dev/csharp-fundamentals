using Day06_WeeklyProject.Abstracts;
using Day06_WeeklyProject.Interfaces;
using Day06_WeeklyProject.Interfaces.ToFile;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_WeeklyProject.Trades
{
    internal class SiparisIslemleri
    {
        public List<Urun> SiparisEkrani { get; set; }
        public ILoggable Logger { get; set; }

        public SiparisIslemleri(ILoggable logger)
        {
            Logger = logger;
            SiparisEkrani = new List<Urun>();
        }

        public string UrunEkle(Urun yeniUrun)
        {
            SiparisEkrani.Add(yeniUrun);
            Logger.LogKayitEt($"Siparişe yeni ürün eklendi: UrunKodu: {yeniUrun.UrunKodu}");
            return $"Siparişe eklendi.";
        }

        public void FaturayiKes()
        {
            double toplamTutar = 0;
            foreach (var eleman in SiparisEkrani)
            {
                toplamTutar += eleman.FiyatHesapla();
            }

            Logger.LogKayitEt($"Siparişte {SiparisEkrani.Count} kalem ürün var.\n" +
                              $"Toplam Tutar    : {toplamTutar} TL\n" +
                              $"Fatura Tarihi   : {DateTime.Now.ToShortDateString()}");

            Console.WriteLine($"Toplam Fatura Tutarı: {toplamTutar} TL");
        }
    }


}
