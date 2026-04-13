using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Encapsulation
{
    internal class Urun
    {
        private string? _ad;
        private double? _fiyat;
        private int? _stok;

        public Urun() { }
        public Urun(string ad, double fiyat, int stok)
        {
            _ad = ad;
            _fiyat = fiyat;
            _stok = stok;
        }

        public string? Ad
        {
            get { return _ad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ürün adı boş olamaz!");
                _ad = value;
            }
        }
        public double? Fiyat
        {
            get { return _fiyat; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Fiyat sıfırın altına düşemez");
                _fiyat = value;
            }
        }
        public int? Stok
        {
            get { return _stok; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Stok sıfırın altına düşemez");
                _stok = value;
            }
        }
        public override string ToString()
        {
            return $"=-=-=-=ÜRÜN=-=-=-=\n" +
                   $"Adı   : {_ad}\n" +
                   $"Fiyatı: {_fiyat}\n" +
                   $"Stok  : {_stok}\n";
        }
        public string SatisYap(int? adet)
        {
            if (adet < 0 || _stok < adet || adet == null)
                throw new ArgumentException("Adet değeri geçersiz (sıfır/boş) ya da stok miktarından fazla. Kontrol edip tekrar deneyin.");
            else
            {
                _stok -= adet;
                return $"Satış gerçekleşti. {adet} satış yapıldı";
            }
        }
    }
}
