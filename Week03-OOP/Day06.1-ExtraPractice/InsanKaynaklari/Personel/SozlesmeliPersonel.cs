using Day06._1_ExtraPractice.InsanKaynaklari.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06._1_ExtraPractice.InsanKaynaklari.Personel
{
    internal class SozlesmeliPersonel : Abstracts.Personel
    {
        private double _sabitMaas;
        private double _primOrani;

        public double SabitMaas
        {
            get { return _sabitMaas; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Sabit maaş sıfır ya da eksi olamaz");

                _sabitMaas = value;
            }
        }
        public double PrimOrani
        {
            get { return _primOrani; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Prim orani sıfır ya da eksi olamaz");

                _primOrani = value;
            }
        }
        public override double MaasHesapla()
        {
            double maas = SabitMaas + (SabitMaas * PrimOrani);
            return maas;
        }
    }
}
