//ENUM:
//1:  Mevsim enum'u oluştur (Ilkbahar, Yaz, Sonbahar, Kis). Kullanıcıdan ay numarası (1-12) al, hangi mevsimde olduğunu enum ile göster.
Console.WriteLine($"1-12 arasında değer girin: ");

int mevsimSecimi = int.Parse(Console.ReadLine()!);

Mevsimler mevsim = mevsimSecimi switch
{
    1 or 2 or 12 => Mevsimler.Kis,
    3 or 4 or 5 => Mevsimler.Ilkbahar,
    6 or 7 or 8 => Mevsimler.Yaz,
    9 or 10 or 11 => Mevsimler.Sonbahar,
    _ => throw new ArgumentException("Hatalı ay girişi!")
};

Console.WriteLine($"Şu an {mevsim} mevsimindeyiz.");

//2:  Siparis Durumu enum'u oluştur (Beklemede, Hazirlaniyor, Kargoda, TeslimEdildi, IptalEdildi). Switch ile her duruma farklı mesaj yazdır.
Dictionary<int, SiparisDurumu> siparisler = new Dictionary<int, SiparisDurumu>()
 {
    {1234, SiparisDurumu.Hazirlaniyor},
    {2345, SiparisDurumu.IptalEdildi },
    {3456, SiparisDurumu.Beklemede },
    {1345, SiparisDurumu.TeslimEdildi },
    {1425, SiparisDurumu.Kargoda },
    {1666, SiparisDurumu.Hazirlaniyor }
};
Console.WriteLine("Yazılan durum, o durumda olan siparişleri gösterir. (Örn: Hazirlaniyor: 1234,1234 nolu siparişler Hazirlaniyor durumundadır)" +
                  "\nDurum: ");
string siparisKodu = Console.ReadLine()!;

SiparisDurumu aranan = Enum.Parse<SiparisDurumu>(siparisKodu);

foreach (var siparis in siparisler)
{
    if (siparis.Value == aranan)
        Console.WriteLine($"- {siparis.Key}");
}


//3:  Yetki enum'u oluştur (Admin=1, Moderator=2, Kullanici=3, Misafir=4). Kullanıcının yetkisine göre erişebileceği sayfaları listele.
Console.WriteLine("Yetki alanını öğrenmek istediğiniz kişinin yetki kodunu girin: ");
int yetkiKodu = int.Parse(Console.ReadLine()!);
Yetki yetki = (Yetki)yetkiKodu;
switch (yetki)
{
    case Yetki.Admin:
        Console.WriteLine("Admin tüm yetkilere sahiptir");
        break;
    case Yetki.Moderator:
        Console.WriteLine("Moderatör, Admine nazaran silme ve ekleme işini yapamaz");
        break;
    case Yetki.Kullanici:
        Console.WriteLine("Kullanici sadece iş tanımına uygun alanda yetkilere sahiptir, mesela sevkiyatçı üretimde iş yapamaz gibi");
        break;
    case Yetki.Misafir:
        Console.WriteLine("Misafir sadece okuyabilir.");
        break;
}
//TUPLE:
//4:  Bir metod yaz: int dizisi alıp (enBuyuk, enKucuk, ortalama) tuple'ı döndürsün.
(int EnBuyuk, int EnKucuk, double Ortalama) DiziAnalizi(int[] dizi)
{
    int enBuyuk = dizi.Max();
    int enKucuk = dizi.Min();
    double ortalama = dizi.Average();
    return (enBuyuk, enKucuk, ortalama);
}

var sonuc = DiziAnalizi(new int[] { 5, 10, 15 });

Console.WriteLine($"En büyük sayi: {sonuc.EnBuyuk}, en kucuk sayi: {sonuc.EnKucuk}, ortalama: {sonuc.Ortalama}");

//5:  Bir metod yaz: ad - soyad string'i alıp (ad, soyad) olarak ayırıp tuple döndürsün.
(string Ad, string Soyad) IsimAyirma(string tamAd)
{
    string[] parcalar = tamAd.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

    if (parcalar.Length >= 2)
    {
        string ad = parcalar[0];
        string soyad = parcalar[parcalar.Length - 1];
        return (ad, soyad);
    }

    return (tamAd, string.Empty);
}

var isim = IsimAyirma("Kemal Sunal");
Console.WriteLine($"Ad: {isim.Ad}, Soyad: {isim.Soyad}");

//6:  Bir metod yaz: saniye alıp(saat, dakika, saniye) tuple'ına çevirsin. Örn: 3661 → (1, 1, 1)
(int Saat, int Dakika, int Saniye) ZamanDonustur(int toplamSaniye)
{
    // Toplam saniyeyi 3600'e bölerek saati buluyoruz
    int saat = toplamSaniye / 3600;

    // Kalan saniyeden kaç dakika olduğunu buluyoruz
    int dakika = (toplamSaniye % 3600) / 60;

    // En son kalan ise saniyedir
    int saniye = toplamSaniye % 60;

    return (saat, dakika, saniye);
}

var saniye = ZamanDonustur(1000);
Console.WriteLine($"{saniye} saniye: {saniye.Saat} saat, {saniye.Dakika} dakika ve {saniye.Saniye} saniye yapıyor");

//NULLABLE:
//7:  int? tipinde bir değişken tanımla. Null ise "Değer atanmamış", değilse değeri yazdır. 
Console.Write("Bir sayı girin (boş bırakabilirsiniz): ");
string girdi = Console.ReadLine()!;
int? yas = string.IsNullOrEmpty(girdi) ? null : int.Parse(girdi);

if (yas.HasValue)
    Console.WriteLine($"Yaş: {yas.Value}");
else
    Console.WriteLine("Değer atanmamış");

//8:  Kullanıcıdan yaş iste. Boş bırakırsa (Enter) null olarak kaydet, ?? ile varsayılan 18 ata. 
Console.Write("Yaşınızı girin: ");
string girdi2 = Console.ReadLine()!;
int? yas2 = string.IsNullOrEmpty(girdi2) ? null : int.Parse(girdi2);
int gercekYas = yas2 ?? 18;
Console.WriteLine($"Yaşınız: {gercekYas}");

//9:  Bir öğrenci kaydı oluştur: isim(string), yas(int ?), not(double ?).Null olanları "Bilgi yok" olarak göster. 
List<string> ogrenciler = new List<string>();

Console.WriteLine("Öğrenci Kayıt Sistemine Hoş Geldiniz");

// 1. İsim Girişi
Console.Write("Öğrenci ad-soyadını girin: ");
string? adSoyad = Console.ReadLine();
// Eğer isim boş girildiyse (sadece enter), null kabul edelim
if (string.IsNullOrWhiteSpace(adSoyad)) adSoyad = null;

// 2. Yaş Girişi
Console.Write("Öğrenci yaşını girin: ");
string? yasVerisi = Console.ReadLine();
yas = int.TryParse(yasVerisi, out int yasSonuc) ? yasSonuc : (int?)null;

// 3. Not Girişi (Soru double? istemişti, double yapalım)
Console.Write("Öğrenci notunu girin: ");
string? notVerisi = Console.ReadLine();
double? ogrenciNotu = double.TryParse(notVerisi, out double notSonuc) ? notSonuc : (double?)null;

// 4. Çıktıyı Hazırlama (İstenen: Null ise "Bilgi yok" yaz)
// Burada ?? operatörü: "Eğer soldaki null ise sağdaki metni yaz" der.
string ogrenciKaydi = $"Öğrenci Ad-Soyad: {adSoyad ?? "Bilgi yok"}\n" +
                     $"Yaşı            : {yas?.ToString() ?? "Bilgi yok"}\n" +
                     $"Notu            : {ogrenciNotu?.ToString() ?? "Bilgi yok"}\n" +
                     $"---------------------------";

ogrenciler.Add(ogrenciKaydi);

// Listeyi ekrana yazdıralım
Console.WriteLine("\nKayıt Tamamlandı!\n");
foreach (var kayit in ogrenciler)
{
    Console.WriteLine(kayit);
}

//10: Bir metod yaz: iki nullable int alıp toplamını döndürsün. Birisi null ise diğerini, ikisi de null ise 0 döndürsün.
Console.WriteLine($"2 adet sayı girin lütfen");

Console.Write($"\n1. sayi: ");
string? inputSayi1 = Console.ReadLine();
int? sayi1 = int.TryParse(inputSayi1, out int s1) ? s1 : (int?)null;


Console.Write($"\n2. sayi: ");
string? inputSayi2 = Console.ReadLine();
int? sayi2 = int.TryParse(inputSayi2, out int s2) ? s2 : (int?)null;

Console.WriteLine(Topla(sayi1, sayi2));


     
//========NULLABLE========
int Topla(int? sayi1, int? sayi2)
{
    if (sayi1 == null && sayi2 == null) return 0;
    if (sayi1 == null) return sayi2.Value;
    if (sayi2 == null) return sayi1.Value;

    return sayi1.Value + sayi2.Value;
}
// ========ENUM========
enum Mevsimler
{
    Kis,
    Ilkbahar,
    Yaz,
    Sonbahar,
    Belirsiz
}

enum SiparisDurumu
{
    Beklemede,
    Hazirlaniyor,
    Kargoda,
    TeslimEdildi,
    IptalEdildi
}

enum Yetki
{
    Admin = 1,
    Moderator = 2,
    Kullanici = 3,
    Misafir = 4
}



