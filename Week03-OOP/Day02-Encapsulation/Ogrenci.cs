using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Day02_Encapsulation
{
    internal class Ogrenci
    {  
        private string _ad;
        private string _soyad;
        private int? _yas;

        public string Ad
        {
            get { return _ad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Öğrenci adı boş olamaz!");
                _ad = value;
            }
        }

        public string Soyad
        {
            get { return _soyad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Öğrenci soyadı boş olamaz!");
                _soyad = value;
            }
        }

        public int? Yas
        {
            get { return _yas; }
            set
            {
                if (value == null || value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException(nameof(value), "Yaş sıfır/boş/sayı dışı olamaz. 0-120 aralığında olmalıdır.");

                _yas = value;
            }
        }
         
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OgrenciNo { get; private set; }
         
        public Ogrenci(string ad, string soyad, int ogrenciNo)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo; 
        }

        public void KendiniTanit()
        { 
            Console.WriteLine($"Adım {Ad} {Soyad}, {Yas} yaşındayım. Okul numaram {OgrenciNo}");
        }
    }
}