using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04_Polymorphism.UretimMakineleri
{
    internal class IplikEgirmeMakinesi : Makine
    {
        public override string UretimYap(int miktar)
        {
            UretilenMiktar += miktar;

            string maliyetBilgisi = base.HesaplaMaliyet(miktar);

            return $"İplik Makinesi {MakineKodu}, {miktar * 2} bobin ip eğirdi. Tüketilen enerji 20 kW\n" + maliyetBilgisi;
        }
    }
}
