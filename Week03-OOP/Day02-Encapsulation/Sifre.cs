using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Encapsulation
{
    internal class Sifre
    {
        //5:  (Bonus)"Sifre" class'ı yaz:
        //    - Şifre sadece set edilebilsin (write-only property!)
        //    - SifreDogrula(string deneme) → true/false dönsün
        //    - Şifre hiçbir zaman dışarıya verilemez (getter yok!)
        [PasswordPropertyText]
        private string _sifre;

        public string KullaniciSifresi
        {
           set { _sifre = value; }
        }

        public Sifre(string kullaniciSifresi)
        {
            KullaniciSifresi = kullaniciSifresi;
        }

        public bool SifreDogrula(string deneme)
        {
            if (deneme == _sifre)
                return true;
            else
                return false;
        }
    }
}
