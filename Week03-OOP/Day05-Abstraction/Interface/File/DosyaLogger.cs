using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Abstraction.Interface.File
{
    internal class DosyaLogger : ILoggable
    {
        public void LogKayitEt(string mesaj)
        {
            Console.WriteLine($"TXT dosyasına yazıldı: {mesaj}");
        }
    }
}
