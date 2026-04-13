using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Inheritance.Banka
{
    internal class Hesap
    {
        private string? _hesapSahibi;
        private double? _bakiye;

        public string? HesapSahibi
        {
            get { return _hesapSahibi; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş bırakılamaz");
                _hesapSahibi = value;
            }
        }
        public double? Bakiye
        {
            get { return _bakiye; }
            private set { _bakiye = value; }
        }

        public virtual double? ParaCek(double? cekilecekTutar)
        {
            if (Bakiye is double && cekilecekTutar is double)
            {
                Bakiye = Bakiye - cekilecekTutar;
                if (Bakiye < 0)
                    throw new ArgumentOutOfRangeException("Bakiye sifirin altına düşemez");
                else
                    return Bakiye;
            }
            else
                throw new ArgumentException("Değer tipi yanlış, sayısal ifade yer alması gerekmektedir.");
        }

    }
}
