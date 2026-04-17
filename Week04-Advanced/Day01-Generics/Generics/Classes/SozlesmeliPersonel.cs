namespace Day01_Generics.Generics.Classes
{
    internal class SozlesmeliPersonel : Personel
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
