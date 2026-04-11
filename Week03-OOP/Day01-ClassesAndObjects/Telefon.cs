using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01_ClassesAndObjects
{
    internal class Telefon
    {
        public string Marka;
        public string Model;
        public int Fiyat;
        public string BataryaKapasitesi;

        public override string ToString()
        {
            return $"Marka             : {Marka}\n" +
                   $"Model             : {Model}\n" +
                   $"Fiyat             : {Fiyat:C2}\n" +
                   $"Batarya Kapasitesi: {BataryaKapasitesi}";
        }
        public void AramaYap(string? numara)
        {
            if (numara != null)
            {
                if (numara.Length >= 10)
                {
                    Console.WriteLine($"{numara} aranıyor...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Bağlandı");
                }
                else throw new FormatException("Telefon numaraları 10 haneli olmalıdır. Örn: 5xx-xxx-xx-xx");
            }
            else throw new NullReferenceException("Veri girişi yapılmamış & hatalı girilmiştir. Lütfen kontrol edip terkar deneyin");

        }
    }
}
