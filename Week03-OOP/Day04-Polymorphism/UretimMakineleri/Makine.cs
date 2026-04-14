using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Polymorphism.UretimMakineleri
{
    internal class Makine
    {
        private int? _makineKodu;
        private int? _uretilenMiktar;

        public int? MakineKodu
        {
            get { return _makineKodu; }
            set
            {
                if (value.GetValueOrDefault(0) <= 0)
                {
                    throw new ArgumentException("Geçerli ve pozitif bir makine kodu girilmelidir.");
                } 
                _makineKodu = value; 
            }
        }
        public int? UretilenMiktar
        {
            get { return _uretilenMiktar; }
            set
            {
                if (value.GetValueOrDefault(0) <= 0)
                {
                    throw new ArgumentException("Geçerli ve pozitif bir üretilen miktar girilmelidir.");
                }
                _uretilenMiktar = value;
            }
        }
        public Makine() { }
        public Makine(int? makineKodu, int? uretilenMiktar)
        {
            MakineKodu = makineKodu;
            UretilenMiktar = uretilenMiktar;
        }
        public virtual string UretimYap(int miktar)
        {
            UretilenMiktar += miktar;
            return $"Makine {_makineKodu} üretim yaptı. Tüketilen enerji 10 kW";
        }
        public override string ToString()
        {
            return
                $"Makine Kodu    : {MakineKodu}\n" +
                $"Uretilen Miktar: {UretilenMiktar}\n";
        }

        public string HesaplaMaliyet(int uretimMiktari)
        {
            double dolar = 44.68;
            double toplam = uretimMiktari * (1.5 * dolar);
            double karliSatis = toplam * 1.20;
           
            return 
                $"Ortalama birim maliyeti: {toplam} TL\n" +
                $"Satış {karliSatis} kadar olmalı ki kâr gerçekleşsin.";
        }
    }
}
