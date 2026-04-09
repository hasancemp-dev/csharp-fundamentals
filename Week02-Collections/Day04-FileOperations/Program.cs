using System.ComponentModel.Design;
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

File.AppendAllText(gunlugum, yazilacakSatirlar + "\n");

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
string musteriSoyadi;
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
            File.AppendAllText(musteriDosyasi, adSoyadTel + "\n");

            MusteriSirala();
            break;
        case 2:
            MusteriSirala();
            break;
        default:
            throw new Exception("Hatalı giriş! Kontrol ediniz ve tekrar deneyin");

    }
    Console.Write("\nTekrar veri girişi yapmak ister misiniz? E/H: ");
    string sonSecim = Console.ReadLine()!;
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

Console.WriteLine("Hangi uygulamayı açalım?" +
                  "1) Sayı Tahmin" +
                  "2) Hesap Makinesi" +
                  "Seçimin:");
secim = int.Parse(Console.ReadLine()!);

while (true)
{
    switch (secim)
    {
        case 1:
            string logSayiTahmin = "SayiTahminScores.txt";
            DateTime tarihST = DateTime.Now;
            Random sayi = new Random();

            int oyunSayisi = 1;
            List<string> oyunlar = new List<string>();
            string secimString;

            while (true)
            {
                bool bulduMu = false;
                Console.Clear();
                Console.WriteLine(" ===========SAYI TAHMİN OYUNU===========");
                int rastgeleSayi = sayi.Next(1, 101);
                Console.WriteLine($"A)1-100 arası bir sayı tuttum. 10 hakkın var! \n" +
                                  $"B)Geçmiş skorları görüntüle");
                string ilksecim = Console.ReadLine()!;
                switch (ilksecim)
                {
                    case "A":
                        for (int hak = 1; hak <= 10; hak++)
                        {
                            Console.WriteLine("");
                            Console.Write($"Tahminini gir: ");
                            int tahmin = int.Parse(Console.ReadLine()!);
                            if (tahmin > rastgeleSayi) Console.Write(" benimki daha düşük, in");
                            else if (tahmin < rastgeleSayi) Console.Write(" benimki daha yüksek, çık");
                            else if (tahmin == rastgeleSayi)
                            {
                                Console.WriteLine($"{hak}. denemede buldun");
                                bulduMu = true;
                                oyunlar.Add($"Oyun {oyunSayisi}: {hak} deneme");
                                File.AppendAllText(logSayiTahmin, $"Oyun {oyunSayisi}: {hak} deneme - " + tarihST + "\n");
                                oyunSayisi++;
                                break;
                            }
                        }
                        break;
                    case "B":
                        if (!File.Exists(logSayiTahmin)) 
                            Console.WriteLine("Böyle bir dosya yok!");
                        // bir defa gözükür o da ilk bu kodu yazdıktan hemen sonra oyun oynanmadan geçmiş görüntülenirse.
                        else
                        {
                            string[] gecmis = File.ReadAllLines(logSayiTahmin);
                            int sayac = 1;
                            foreach (var kayit in gecmis)
                            {
                                Console.WriteLine($"{sayac}) {kayit}");
                                sayac++;
                            }
                        }

                        break;
                }

                if (!bulduMu)
                {
                    Console.WriteLine("Hakkını doldurdun :( ");
                    oyunlar.Add($"Oyun {oyunSayisi}: Bulamadı");
                    File.AppendAllText(logSayiTahmin, $"Oyun {oyunSayisi}: Bulamadı - " + tarihST + "\n");
                    oyunSayisi++;
                    Console.WriteLine($"Yeni oyun? E/H: ");
                    secimString = Console.ReadLine()!;
                    if (secimString == "E") continue;
                    else break;
                }
                if (bulduMu)
                {
                    Console.WriteLine("Yeni oyun? E/H: ");
                    secimString = Console.ReadLine()!;
                    if (secimString == "E") continue;
                    else break;
                }

            }


            foreach (var gelen in oyunlar)
            {
                Console.WriteLine(gelen);
            }
            break;

        case 2:
            string logHesapMakinesi = "HesapMakineGecmis.txt";
            DateTime tarihHM = DateTime.Now;
            Console.WriteLine("Hoşgeldin!");
            while (true)
            {
                Console.Write("1. Sayı: ");
                double ilkSayi = double.Parse(Console.ReadLine()!);

                Console.Write("2. Sayı: ");

                double ikinciSayi = double.Parse(Console.ReadLine()!);

                Console.Write("İşlem operatörü seçin: \n" +
                              "Toplama +\n" +
                              "Çıkarma - \n" +
                              "Çarpma  * \n" +
                              "Bölme   / \n" +
                              "Mod     %\n" +
                              "Geçmiş: G");
                string islem = Console.ReadLine()!;
                double sonuc = 0;
                bool gecerliIslem = true;
                switch (islem)
                {
                    case "+":
                        sonuc = ilkSayi + ikinciSayi;
                        File.AppendAllText(logHesapMakinesi, $" {ilkSayi} + {ikinciSayi} = {sonuc} - " + tarihHM + "\n");
                        break;
                    case "-":
                        sonuc = ilkSayi - ikinciSayi;
                        File.AppendAllText(logHesapMakinesi, $" {ilkSayi} - {ikinciSayi} = {sonuc} - " + tarihHM + "\n");
                        break;
                    case "*":
                        sonuc = ilkSayi * ikinciSayi;
                        File.AppendAllText(logHesapMakinesi, $" {ilkSayi} * {ikinciSayi}= {sonuc} - " + tarihHM + "\n");
                        break;
                    case "/":
                        if (ikinciSayi != 0)
                        {
                            sonuc = ilkSayi / ikinciSayi;
                            File.AppendAllText(logHesapMakinesi, $" {ilkSayi} / {ikinciSayi} = {sonuc} - " + tarihHM + "\n");
                        }
                        else
                        {
                            Console.Write("Bölme işleminde ikinci sayı 0 olamaz");
                            gecerliIslem = false;
                        }
                        break;
                    case "%":
                        if (ikinciSayi != 0)
                        {
                            sonuc = ilkSayi % ikinciSayi;
                            File.AppendAllText(logHesapMakinesi, $" {ilkSayi} % {ikinciSayi} = {sonuc} - " + tarihHM + "\n");
                        }
                        else
                        {
                            Console.Write("Mod işleminde ikinci sayı 0 olamaz.");
                            gecerliIslem = false;
                        }
                        break;
                    case "G":
                        string[] gecmis = File.ReadAllLines(logHesapMakinesi);
                        int sayac = 1;
                        foreach (var kayit in gecmis)
                        {
                            Console.WriteLine($"{sayac}) {kayit}");
                            sayac++;
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem ya da operatör");
                        gecerliIslem = false;
                        break;
                }
                if (gecerliIslem)
                {
                    Console.WriteLine($"İşlem sonucu: {sonuc}");
                }
                Console.Write("Başka işlem yapmak ister misiniz? E/H: ");
                secimString = Console.ReadLine()!;
                if (secimString == "E") continue;
                else { Console.WriteLine("Hoşçakal!"); break; }
            }
            break;
        default:
            throw new Exception("Hatalı seçim! Konrol edip tekrar deneyin");


    }
}


