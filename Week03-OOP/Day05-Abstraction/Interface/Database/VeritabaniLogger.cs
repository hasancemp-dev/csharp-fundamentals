using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05_Abstraction.Interface.Database
{
    internal class VeritabaniLogger : ILoggable
    {
        public void LogKayitEt(string mesaj)
        {
            Console.WriteLine($"Veritabanına kaydedildi: {mesaj}");
        }
    }
}
