using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06._1_ChallengeProject
{
    internal class DepoYonetimi
    {
        private Dictionary<string, int> _stoklar;
        private DosyaYonetimi _dosyaYonetimi;

        public DepoYonetimi()
        {
            _dosyaYonetimi = new DosyaYonetimi();
            _stoklar = _dosyaYonetimi.StoklariOku(); // Program başlarken eski verileri diskten çek
        }

        public void UrunGirisi(string urunAd, int miktar)
        {
            if (miktar <= 0) throw new ArgumentException("Giriş miktarı 0 veya eksi olamaz.");

            if (_stoklar.ContainsKey(urunAd))
                _stoklar[urunAd] += miktar;
            else
                _stoklar[urunAd] = miktar;

            // İşlemler bitti, diske kaydet
            _dosyaYonetimi.StoklariKaydet(_stoklar);
            _dosyaYonetimi.LogKaydet(IslemTipi.Giris, urunAd, miktar);
        }

        public void UrunCikisi(string urunAd, int miktar)
        {
            if (miktar <= 0) throw new ArgumentException("Çıkış miktarı 0 veya eksi olamaz.");

            // 1. Kural: Ürün var mı?
            if (!_stoklar.ContainsKey(urunAd))
                throw new KeyNotFoundException($"HATA: '{urunAd}' isimli ürün depoda bulunamadı!");

            // 2. Kural: Yeterli stok var mı?
            if (_stoklar[urunAd] < miktar)
                throw new InvalidOperationException($"HATA: Yetersiz stok! Mevcut: {_stoklar[urunAd]}, İstenen: {miktar}");

            // Çıkışı yap
            _stoklar[urunAd] -= miktar;

            // Eğer stok 0 olduysa sözlükten tamamen silebiliriz (İsteğe bağlı)
            if (_stoklar[urunAd] == 0) _stoklar.Remove(urunAd);

            _dosyaYonetimi.StoklariKaydet(_stoklar);
            _dosyaYonetimi.LogKaydet(IslemTipi.Cikis, urunAd, miktar);
        }

        public void StoklariListele()
        {
            Console.WriteLine("\n--- GÜNCEL STOK DURUMU ---");
            if (_stoklar.Count == 0) Console.WriteLine("Depo şu an boş.");

            foreach (var item in _stoklar)
                Console.WriteLine($"- {item.Key}: {item.Value} adet");
            Console.WriteLine("--------------------------\n");
        }

        public void LoglariGoster() => _dosyaYonetimi.LoglariListele();
    }
}
