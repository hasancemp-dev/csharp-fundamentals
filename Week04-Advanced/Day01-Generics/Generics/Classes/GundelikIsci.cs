namespace Day01_Generics.Generics.Classes
{
    public class GundelikIsci : Personel
    {
        private double _gunlukYevmiye;
        private int _calistigiGunSayisi;

        public double GunlukYevmiye
        {
            get { return _gunlukYevmiye; }
            set
            { 
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Günlük yevmiye sıfır veya eksi bir değer olamaz.");

                _gunlukYevmiye = value;
            }
        }

        public int CalistigiGunSayisi
        {
            get { return _calistigiGunSayisi; }
            set
            { 
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Çalışılan gün sayısı sıfır veya eksi girilemez.");

                _calistigiGunSayisi = value;
            }
        }
        public override double MaasHesapla()
        {
            double maas = GunlukYevmiye * CalistigiGunSayisi;
            return maas;
        }
    }
}
