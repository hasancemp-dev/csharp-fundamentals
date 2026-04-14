using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day06_WeeklyProject.Interfaces.ToFile
{
    internal class DosyaLogger : ILoggable
    {
        public void LogKayitEt(string mesaj)
        {
            string dosya = "LogKayit.txt";
            DateTime tarih = DateTime.Now;
            if (!(string.IsNullOrWhiteSpace(mesaj)))
            {
                File.AppendAllText(dosya, $"{mesaj} {DateTime.Now.ToShortDateString} \n");
                Console.WriteLine($"TXT dosyasına kayıt edildi: {mesaj}");
            }
            else
                throw new ArgumentNullException("Log kaydı boş gönderilemez");
        }
    }
}
