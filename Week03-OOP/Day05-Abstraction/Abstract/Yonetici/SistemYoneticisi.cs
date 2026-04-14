using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Abstraction.Abstract.Yonetici
{
    internal class SistemYoneticisi : Kullanici
    {
        public SistemYoneticisi(string ad) : base(ad, "Sistem Yöneticisi")
        {
        }
        public override void IslemYap()
        {
            Console.WriteLine("Yönetici yeni roller tanımlıyor.");
        }
    }
}
