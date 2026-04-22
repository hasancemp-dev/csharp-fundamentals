using System;
using System.Collections.Generic;
using System.Text;

namespace Day04_Events.Publisher
{
    public class Depo
    {
        private int _stokMiktari;
        public int StokMiktari
        {
            get { return _stokMiktari; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "Stok miktarı 0'dan küçük olamaz.");
                }
                _stokMiktari = value;
            }
        }
        public event StokAzaldiHandler StokAzaldi;
        public Depo(int baslangicStoku)
        {
            _stokMiktari = baslangicStoku;

            Console.WriteLine($"Depo oluşturuldu. Başlangıç stoğu: {_stokMiktari}");
        }
        public void StokDusur(int adet)
        {
            _stokMiktari -= adet;

            Console.WriteLine($"Stoktan {adet} adet düşüldü. Kalan stok: {_stokMiktari}");
             
            if (_stokMiktari < 20)
            { 
                if (StokAzaldi != null)
                { 
                    StokAzaldi(_stokMiktari);
                }
            }

        }
    }
}

