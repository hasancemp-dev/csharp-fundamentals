using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_ClassesAndObjects
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public int OgrenciNo;

        public void KendiniTanit()
        {
            Console.WriteLine($"Adım {Ad} {Soyad}, {Yas} yaşındayım. Okul numaram {OgrenciNo}");
        }
    }
}
