using Day01_Generics.Generics.Interfaces; 

namespace Day01_Generics.Generics.Classes
{
    public abstract class Personel : IMaasHesaplanabilir
    {
        private string _tcKimlik;
        private string _adSoyad;

        public string TcKimlik
        {
            get { return _tcKimlik; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("TC Kimlik numarası boş bırakılamaz.");
                if (value.Length != 11)
                    throw new ArgumentException("TC Kimlik numarası 11 haneli olmalıdır.");
                _tcKimlik = value;
            }
        }

        public string AdSoyad
        {
            get { return _adSoyad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Ad Soyad alanı boş bırakılamaz.");
                _adSoyad = value;
            }
        }

        public Departman Dept { get; set; }

        public abstract double MaasHesapla();

        public override string ToString()
        {
            return $"{AdSoyad} - {Dept} ({TcKimlik})";
        }
    }
}
