using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Polymorphism.UretimMakineleri
{
    internal class DokumaMakinesi : Makine
    {
        private int? _calismaHizi;

        public int? CalismaHizi
        {
            get { return _calismaHizi; }
            set
            {
                if (value.GetValueOrDefault(0) <= 0)
                {
                    throw new ArgumentException("Geçerli ve pozitif bir çalışma hızı girilmelidir.");
                }
                _calismaHizi = value;
            }
        }

        public DokumaMakinesi() { }

        public DokumaMakinesi(int? makineKodu, int? uretilenMiktar, int? calismaHizi) : base(makineKodu, uretilenMiktar)
        {
            CalismaHizi = calismaHizi;
        }

        public override string UretimYap(int miktar)
        {
            int? toplam = (CalismaHizi * miktar) / 100;
            if (toplam is not int)
                throw new ArgumentException("Geçerli ve pozitif bir değer olmalıdır.");
            else
            {
                UretilenMiktar += toplam;

                string maliyetBilgisi = base.HesaplaMaliyet(miktar);

                return $"Dokuma Makinesi {MakineKodu}, {miktar} metre kumaş dokudu. Tüketilen enerji 50 kW\n" + maliyetBilgisi;
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Calisma Hizi   : {CalismaHizi}\n";
        }
    }
}
