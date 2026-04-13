using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Inheritance.Sirket
{
    internal class Muhasebeci : Calisan
    {
        private string? _muhasebeYazilimi;
        public string? MuhasebeYazilimi
        {
            get { return _muhasebeYazilimi; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş bırakılamaz");
                _muhasebeYazilimi = value;
            }
        }

        public Muhasebeci(string? ad, string? soyad, string? muhasebeYazilimi) : base(ad, soyad)
        {
            MuhasebeYazilimi = muhasebeYazilimi;
        }
        public override string MesaiYap()
        {
            return "Muhasebeci fatura keserek mesaiye kaldı.";
        }
    }
}
