using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Abstraction.Abstract
{
    abstract class Kullanici
    {
        private string? _ad;
        private string? _rol;
        public string? Ad 
        {
            get { return _ad; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş bırakılamaz.");
                _ad = value;
            } 
        }
        public string? Rol
        {
            get { return _rol; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("Bu alan boş bırakılamaz.");
                _rol = value;
            }
        }

        protected Kullanici(string? ad, string? rol)
        {
            Ad = ad;
            Rol = rol;
        }

        public void GirisYap()
        {
            Console.WriteLine($"Kullanıcı {Ad} giriş yaptı.");
        }
        public abstract void IslemYap();
    }
}
