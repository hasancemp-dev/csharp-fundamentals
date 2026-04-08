using System.IO;

//1:  Basit bir not defteri: "notlar.txt" adında bir dosyaya 3 satır yazı yazdır ve sonra bu dosyayı okuyup ekrana bas.

string dosyaYolu = "notlar.txt";

string[] yazilacakYazi =
{
    "1.satır",
    "2.satır",
    "3.satır"
};

bool varMi = File.Exists(dosyaYolu);

if (varMi)
{
    File.WriteAllLines(dosyaYolu, yazilacakYazi);
}
else File.WriteAllLines(dosyaYolu, yazilacakYazi);


string[] satirSatir = File.ReadAllLines(dosyaYolu);
foreach (var satir in satirSatir)
{
    Console.WriteLine(satir);
}

//2:  Dosya varlık kontrolü: Kullanıcıdan bir dosya adı iste (Örn: "test.txt"). File.Exists ile kontrol et. Varsa "Bu dosya zaten mevcut", yoksa "Dosya oluşturuldu" deyip yeni bir txt dosyası yarat.

string yeniDosya = "hasan.txt";

varMi = File.Exists(yeniDosya);

if (!varMi)
{
    File.Create(yeniDosya);
    Console.WriteLine("Dosya oluşturuldu");
}
else
    Console.WriteLine("Bu dosya zaten mevcut.");

//3:  Günlük(Log) tutucu: Kullanıcıdan bir mesaj iste. Mesajı "gunluk.txt" dosyasının sonuna (AppendAllText) o anki saat ile birlikte eklesin.
string gunlugum = "gunluk.txt";
Dictionary<DateTime, string> gunlukLog = new Dictionary<DateTime, string>();

DateTime yeniGun = DateTime.Now;
Console.WriteLine("Günlüğe ne yazmak istersin?");
string yeniLog = Console.ReadLine()!;

gunlukLog.Add(yeniGun, yeniLog);

List<string> yazilacakSatirlar = new List<string>();
foreach (var kayit in gunlukLog)
{
    string satir = kayit.Key.ToShortDateString() + " - " + kayit.Value;
    yazilacakSatirlar.Add(satir);
}

File.AppendAllLines(gunlugum, yazilacakSatirlar);

Console.WriteLine("\nKayıt günlüğe başarıyla işlendi!");

//4:  Listeden Dosyaya: 5 elemanlı bir List<string> (iller listesi) oluştur. File.WriteAllLines kullanarak bunu txt'ye dönüştür. Ardından txt'yi tekrar okuyup elemanların sonuna " - Türkiye" yazarak ekrana bas.
List<string> sehirler = new List<string>()
{
    "Bursa",
    "İzmir",
    "Ankara",
    "Mardin",
    "Kırklareli"
};

string sehirDosyasi = "sehirler.txt";


File.WriteAllLines(sehirDosyasi, sehirler);

string[] sehirlerDizi = File.ReadAllLines(sehirDosyasi);
foreach (var kayit in sehirlerDizi)
{
    Console.WriteLine(kayit + " - Türkiye");
}

//5:  Mini Veritabanı: Müşteri bilgisi kaydetme. Kullanıcı "1" tuşuna basarsa Ad, Soyad ve Telefon alıp "musteriler.txt" dosyasına virgülle ayrılmış şekilde eklesin (Örn: Hasan, Çelik,55512345). "2"ye basarsa txt dosyasını okuyup müşterileri liste şeklinde göstersin.
Console.WriteLine("==========MENU==========");
Console.WriteLine("1) Müşteri Bilgisi Gir\n" +
                  "2) Müşteri Bilgisi Sırala");
Console.WriteLine("Seçiminiz: ");
int secim = int.Parse(Console.ReadLine()!);

string musteriDosyasi = "musteriler.txt";

string musteriAdi;
string musteriSoyadi ;
long cepTel;

string adSoyadTel;
 
while (true)
{
    switch (secim)
    {
        case 1: 
            Console.Write($"\nMüşteri Ad: ");
            musteriAdi = Console.ReadLine()!;
            Console.Write($"\nMüşteri Soyad: ");
            musteriSoyadi = Console.ReadLine()!;
            Console.Write($"\nMüşteri Cep Telefonu: ");
            cepTel = long.Parse(Console.ReadLine()!);
            adSoyadTel = $"{musteriAdi}, {musteriSoyadi}, {cepTel}"; 
            File.AppendAllText(musteriDosyasi, adSoyadTel);

            MusteriSirala();
            break;
        case 2:
            MusteriSirala();
            break;
        default:
            throw new Exception("Hatalı giriş! Kontrol ediniz ve tekrar deneyin");

    }
    Console.Write("\nTekrar veri girişi yapmak ister misiniz? E/H: ");
    string sonSecim =  Console.ReadLine()!;
    if (sonSecim == "E") continue;
    else break;
}

void MusteriSirala()
{
    int sayac = 1;
    string[] yazdirilacakSatilars = File.ReadAllLines(musteriDosyasi);

    foreach (var kayit in yazdirilacakSatilars)
    {
        Console.WriteLine($"{sayac}) {kayit}");
        sayac++;
    }
}


//6: (Zorluk: ⭐⭐⭐) Önceki projelerden Hesap Makinesi veya Sayı Tahmin Oyununu düşün. Bu programdaki skorları veya yapılan işlemleri "gecmis.txt" dosyasına kalıcı olarak kaydeden bir yapı kur.


/*
 * 1. Dosya Var Mı Kontrolü (Exists)
csharp
string dosyaYolu = "rehber.txt";
bool varMi = File.Exists(dosyaYolu); // Varsa true, yoksa false

2. Dosyaya Yazma (WriteAllText & WriteAllLines)
Eski veriyi siler, komple baştan yazar:

csharp
File.WriteAllText("mesaj.txt", "Merhaba Dünya!"); // Tek bir metin yazar
csharp
string[] ogrenciler = { "Ali", "Ayşe", "Veli" };
File.WriteAllLines("ogrenciler.txt", ogrenciler); // Listenin her elemanını alt alta yazar
3. Dosyanın Sonuna Ekleme (AppendAllText & AppendAllLines)
Eski veriye dokunmaz, en altına yeni satır ekler:

csharp
File.AppendAllText("log.txt", "Sisteme saat 10:00'da giriş yapıldı.\n"); // Sonuna ekler
4. Dosyadan Okuma (ReadAllText & ReadAllLines)
csharp
string tumIcerik = File.ReadAllText("mesaj.txt"); // Dosyadaki her şeyi tek parça string olarak alır.
csharp
string[] satirSatir = File.ReadAllLines("ogrenciler.txt"); // Her satırı dizinin bir elemanı yapar.
foreach (string satir in satirSatir)
{
    Console.WriteLine(satir);
}
5. Dosya Silme (Delete)
csharp
File.Delete("eski_dosya.txt");
*/



