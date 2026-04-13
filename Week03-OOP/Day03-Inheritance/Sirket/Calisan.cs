using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Inheritance.Sirket
{
    internal class Calisan
    {
        private string? _ad;
        private string? _soyad;
        private double? _maas;

        public string? Ad
        {
            get { return _ad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Ad alanı boş bırakılamaz");
                _ad = value;
            }
        }
        public string? Soyad
        {
            get { return _soyad; }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Soyad alanı boş bırakılamaz");
                _soyad = value;
            }
        }
        public double? Maas
        {
            get { return _maas; }
            private set { _maas = value; }
        }

        public Calisan(string? ad, string? soyad)
        {
            Ad = ad ?? throw new ArgumentNullException(nameof(ad));
            Soyad = soyad ?? throw new ArgumentNullException(nameof(soyad));
        }

        public override string ToString()
        {
            return
                $"Ad-Soyad: {Ad} {Soyad}\n" +
                $"Maas    : {Maas}\n";
        }

        public virtual string MesaiYap()
        {
            return $"Çalışan mesaiye kaldı";
        }

    }
}
