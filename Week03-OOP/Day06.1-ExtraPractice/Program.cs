//💼 Ekstra Pratik Projesi: "Melba Tekstil - İnsan Kaynakları ve Bordro Modülü"
//Bu proje ile Text dosyasından veri okuyup, Abstract sınıflarla onları nesneye çevirip maaşlarını hesaplayacağız!

//1. Enum ve Exception (Hafta 2 Pratiği)

//Enum: Departman { Uretim, Kalite, Lojistik, Yonetim }
//Eğer kullanıcı personelin çalışma gününü eksi girerse ArgumentOutOfRangeException fırlatan korumalar (Encapsulation).


//2. Arayüzler (Interface Pratiği)

//IMaasHesaplanabilir: İçerisinde double MaasHesapla(); imzası olsun.
//IVeriKaydedilebilir: İçerisinde void BordroYazdir(string mesaj); imzası olsun.


//3.Abstract Class(Soyutlama Pratiği)

//Personel adında abstract class oluştur(ve IMaasHesaplanabilir'i miras alsın).
//Properties: string TCKimlik, string AdSoyad, Departman Dept.
//Kural Koyucu (Abstract Metod): Interface'den gelen MaasHesapla() metodunu abstract override yap (içini doldurma, çocuklara bırak).


//4. Çocuk Sınıflar (Kalıtım ve Polimorfizm Pratiği)

//GundelikIsci : Personel
//Kendine has özellikleri: double GunlukYevmiye, int CalistigiGunSayisi
//MaasHesapla() metodunu ez: Formül = GunlukYevmiye * CalistigiGunSayisi
//SozlesmeliPersonel: Personel
//Kendine has özellikleri: double SabitMaas, double PrimOrani
//MaasHesapla() metodunu ez: Formül = SabitMaas + (SabitMaas * PrimOrani)


//5.Yardımcı Class(File I / O Pratiği)

//DosyaYonetimi isminde bir class yaz, IVeriKaydedilebilir uygulansın. BordroYazdir metodu bordrolar.txt dosyasına StreamWriter ile o anki tarihi ve veriyi formatlı şekilde yazsın. (Hafta 2!)


//6. Program.cs (Büyük Buluşma)

//List<Personel> sirket = new List<Personel>(); oluştur.
//İçine 2 adet Gündelik İşçi, 2 adet Sözleşmeli Personel ekle.
//foreach döngüsüyle hepsini dönüp polimorfik olarak her birinin MaasHesapla() metodunu çağırıp toplam ödenecek şirket maaş tutarını hesapla.
//Sonucu DosyaYonetimi nesnen ile .txt dosyasına kaydet!

using Day06._1_ExtraPractice.InsanKaynaklari.FileMan;
using Day06._1_ExtraPractice.InsanKaynaklari.Personel;
using Day06._1_ExtraPractice.InsanKaynaklari.Personel.Abstracts;
using System.Text;

List<Personel> sirket = new List<Personel>()
{
    new GundelikIsci { AdSoyad = "Yehu Gemoruv", TcKimlik = "99999999999", Dept = Departman.Uretim, GunlukYevmiye = 5500, CalistigiGunSayisi = 12},
    new GundelikIsci { AdSoyad = "Kamil Kocsever", TcKimlik = "88888888888", Dept = Departman.Uretim, GunlukYevmiye = 4800, CalistigiGunSayisi = 10},
    new SozlesmeliPersonel { AdSoyad = "Tamer Oluklu", TcKimlik = "77777777777", Dept = Departman.Lojistik, SabitMaas = 50000, PrimOrani = 0.15},
    new SozlesmeliPersonel { AdSoyad = "Lokman Erkoc", TcKimlik = "66666666666", Dept = Departman.Yonetim, SabitMaas = 150000, PrimOrani = 0.50}
};

double toplamOdenecekMaas = 0;
StringBuilder raporIcerigi = new StringBuilder();
raporIcerigi.AppendLine("--- AYLIK PERSONEL MAAŞ DÖKÜMÜ ---");
 
foreach (var personel in sirket)
{
    
    double maas = personel.MaasHesapla();
    toplamOdenecekMaas += maas;
     
    raporIcerigi.AppendLine($"{personel.AdSoyad} ({personel.Dept}) - Maaş: {maas:C2}");
}

raporIcerigi.AppendLine("----------------------------------");
raporIcerigi.AppendLine($"ŞİRKET TOPLAM ÖDEME TUTARI: {toplamOdenecekMaas:C2}");
 
DosyaYonetimi recorder = new DosyaYonetimi();
recorder.BordroYazdir(raporIcerigi.ToString());
 
Console.WriteLine("İşlem başarıyla tamamlandı. Detaylar bordrolar.txt dosyasına yazıldı.");
Console.WriteLine($"Toplam Ödenecek: {toplamOdenecekMaas:C2}");


enum Departman { Uretim, Kalite, Lojistik, Yonetim }


