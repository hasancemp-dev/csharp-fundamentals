using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_Inheritance.Banka
{
    internal class VadeliHesap : Hesap
    {
        public override double? ParaCek(double? cekilecekTutar)
        {
            double cezaOrani = 0.20;
            double? cezaDahilTutar = cekilecekTutar + (cekilecekTutar * cezaOrani);

            return base.ParaCek(cezaDahilTutar);
        }

    }
}
