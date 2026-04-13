using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Encapsulation
{
    internal class Araba
    {
        //4:  "Araba" class'ı yaz. 
        //    - Motor hacmi(cc) olsun: 600 - 7000 arası olmalı
        //    - Yıl: 1900'den küçük ya da bu yıldan büyük olamaz
        //    - KmEkle(int km) metodu: toplam km'yi artırsın ama negatif girilirse hata versin

        private string _marka;
        private string _model;
        private int _motorHacmi;
        private int _yil;
        private int _km;

        public string? Marka
        {
            get { return _marka; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş olamaz");
                _marka = value;
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş olamaz");
                _model = value;
            }
        }
        public int MotorHacmi
        {
            get { return _motorHacmi; }
            set
            {
                if (value < 600 || value > 7000)
                    throw new ArgumentException("Motor Hacmi 600cc ile 7000cc arasında olmalı");
                _motorHacmi = value;
            }
        }
        public int Yil
        {
            get { return _yil; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year )
                    throw new ArgumentException("1900 yilindan eski araba girişi olamaz");
                _yil = value;
            }
        }
        public int Km
        {
            get { return _km; }
            private set { _km = value; }
        }

        public Araba() { }

        public Araba(string? marka, string model, int motorHacmi, int yil, int km)
        {
            Marka = marka ?? throw new ArgumentNullException(nameof(marka));
            Model = model ?? throw new ArgumentNullException(nameof(model));
            MotorHacmi = motorHacmi;
            Yil = yil;
            Km = km;
        }

        public override string ToString()
        {
            return
                $"Marka      : {Marka}\n" +
                $"Model      : {Model}\n" +
                $"Motor Hacmi: {MotorHacmi}\n" +
                $"Yıl        : {Yil}\n" +
                $"KM         : {Km}";
        }

        public void KmEkle(int eklenecekKm)
        {
            if (eklenecekKm < 0)
            {
                throw new ArgumentException("Eklenecek kilometre negatif bir değer olamaz!");
            }

            Km += eklenecekKm; // Toplam km'yi artırıyoruz
            Console.WriteLine($"Araca {eklenecekKm} km eklendi. Güncel Kilometre: {Km}");
        }
    }
}
