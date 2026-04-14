using Day06_WeeklyProject.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_WeeklyProject.Products
{
    internal class PolyesterKumas : Urun
    {
        private double? _birimFiyat = 80.20;
        public double? BirimFiyat
        {
            get { return _birimFiyat; }
        }
        public PolyesterKumas(string? urunKodu, double? metraj) : base(urunKodu, metraj)
        {
        }

        public override double FiyatHesapla()
        {
            if (Metraj == null || BirimFiyat == null)
            {
                throw new InvalidOperationException("Hesaplama yapılamadı: Metraj veya Birim Fiyat tanımlanmamış (null).");
            }

            if (Metraj < 0)
            {
                throw new InvalidOperationException("Parametreleri kontrol edin: Metraj negatif olamaz.");
            }

            return (Metraj.Value * BirimFiyat.Value) ;
        }
    }
}
