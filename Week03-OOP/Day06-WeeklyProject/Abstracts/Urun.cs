using Day06_WeeklyProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_WeeklyProject.Abstracts
{
    abstract class Urun : IHesaplanabilir
    {
        private string? _urunKodu;
        private double? _metraj;

        public string? UrunKodu
        {
            get { return _urunKodu; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş bırakılamaz");
                _urunKodu = value;
            }
        }
        public double? Metraj
        {
            get { return _metraj; }
            set
            {
                if (value.GetValueOrDefault(0) <= 0)
                    throw new ArgumentNullException("Geçerli ya da pozitif değer giriniz");
                _metraj = value;
            }
        }

        protected Urun(string? urunKodu, double? metraj)
        {
            UrunKodu = urunKodu;
            Metraj = metraj;
        }

        public abstract double FiyatHesapla();
    }
}
