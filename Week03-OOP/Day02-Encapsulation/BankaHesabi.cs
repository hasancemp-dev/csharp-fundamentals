using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Encapsulation
{
    internal class BankaHesabi
    {
        private double _bakiye = 0;

        public double Bakiye
        {
            get { return _bakiye; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Bakiye sıfırın altına düşemez!");
                else
                    _bakiye = value;
            }
        }
        public override string ToString()
        {
            return $"Bakiyeniz: {_bakiye}";
        }
        public void ParaYatir(double? miktar)
        {
            if (miktar != null)
                if (miktar > 0)
                {
                    _bakiye += (double)miktar;
                    Console.WriteLine($"Hesap Güncel Bakiyesi: {_bakiye}");
                }

        }
        public void ParaCek(double? miktar)
        {
            if (miktar != null)
                if (miktar > 0 && _bakiye >= miktar)
                    _bakiye -= (double)miktar;
                else throw new ArgumentException("Yetersiz bakiye!");
        }
    }
}
