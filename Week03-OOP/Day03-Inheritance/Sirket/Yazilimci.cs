using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Day03_Inheritance.Sirket
{
    internal class Yazilimci : Calisan
    {
        private string? _bildigiDiller; 
        public string? BildigiDiller
        {
            get { return _bildigiDiller; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş bırakılamaz");
                _bildigiDiller = value;
            }
        }

        public Yazilimci(string? ad, string? soyad, string? bildigiDiller) : base(ad, soyad)
        {
            BildigiDiller = bildigiDiller;
        }
        public override string MesaiYap()
        {
            return "Yazılımcı kod yazarak mesaiye kaldı.";
        }

    }
}
