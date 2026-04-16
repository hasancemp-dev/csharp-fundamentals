using System;
using System.Collections.Generic;
using System.Text;

namespace Day01_Generics.Generics.Classes
{
    public class Kutu<T>
    {
        private T _icerik;
        public T Icerik
        {
            get { return _icerik; }
            set { _icerik = value; }
        }
        public Kutu() { }

        public Kutu(T icerik)
        {
            _icerik = icerik;
        }

       public void IcerigiYazdir()
        {
            Console.WriteLine($"İçeriğin tipi: {typeof(T)}, Değeri: {Icerik}");
        }
    }
}
