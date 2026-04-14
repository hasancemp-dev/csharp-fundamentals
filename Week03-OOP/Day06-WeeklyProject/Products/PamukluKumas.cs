using Day06_WeeklyProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_WeeklyProject.Products
{
    internal class PamukluKumas : Urun
    {
        private double? _birimFiyat = 150.5;

        public PamukluKumas(string? urunKodu, double? metraj) : base(urunKodu, metraj)
        {
        }

        public double? BirimFiyat
        {
            get { return _birimFiyat; }
        }
        public override double FiyatHesapla()
        {
            double pamukluKaliteVergisi = 1.10;
            if (Metraj == null || BirimFiyat == null)
            {
                throw new InvalidOperationException("Hesaplama yapılamadı: Metraj veya Birim Fiyat tanımlanmamış (null).");
            }

            if (Metraj < 0)
            {
                throw new InvalidOperationException("Parametreleri kontrol edin: Metraj negatif olamaz.");
            }

            return (Metraj.Value * BirimFiyat.Value) * pamukluKaliteVergisi;
        }
    }
}
