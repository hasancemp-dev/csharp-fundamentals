using Day06._1_ExtraPractice.InsanKaynaklari.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06._1_ExtraPractice.InsanKaynaklari.Personel.Abstracts
{
    internal abstract class Personel : IMaasHesaplanabilir
    {
        private string _tcKimlik;
        private string _adSoyad;

        public string TcKimlik
        {
            get { return _tcKimlik; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("TC Kimlik numarası boş bırakılamaz.");
                if (value.Length != 11)
                    throw new ArgumentException("TC Kimlik numarası 11 haneli olmalıdır.");
                _tcKimlik = value;
            }
        }

        public string AdSoyad
        {
            get { return _adSoyad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Ad Soyad alanı boş bırakılamaz.");
                _adSoyad = value;
            }
        }

        public Departman Dept { get; set; }

        public abstract double MaasHesapla();
    }
}
