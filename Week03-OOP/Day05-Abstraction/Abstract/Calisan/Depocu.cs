using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Abstraction.Abstract.Calisan
{
    internal class Depocu : Kullanici
    {
        public Depocu(string ad) : base(ad, "Depocu")
        {
        }
        public override void IslemYap()
        {
            Console.WriteLine("Depocu stok sayımı yapıyor.");
        }
    }
}
