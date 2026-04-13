using Day02_Encapsulation;
using System.ComponentModel.Design;
using System.Data;

//1:  "Banka Hesabı" class'ı yaz. Bakiye private olsun, 
//    property ile kontrollü erişilsin (eksi olamaz). 
//    Para yatırma (ParaYatir) ve para çekme (ParaCek) metodları olsun. 
//    ParaCek: bakiyeden fazla çekilirse exception fırlatsın.

BankaHesabi vadesizHesap = new BankaHesabi();
while (true)
{
    Console.WriteLine("=====VADESIZ HESAP=====" +
                      "\n1)Bakiye Görüntüle" +
                      "\n2)Para Yatir" +
                      "\n3)Para Çek");
    Console.Write("Seçiminiz: ");
    int secim = int.Parse(Console.ReadLine()!);
    double? miktar;
    switch (secim)
    {
        case 1:
            Console.WriteLine(vadesizHesap);
            break;
        case 2:
            Console.Write($"Yatırılacak tutarı girin: ");
            string? miktarString = Console.ReadLine();
            miktar = double.TryParse(miktarString, out double paraYatir) ? paraYatir : (double?)null;
            vadesizHesap.ParaYatir(miktar);
            break;
        case 3:
            Console.Write($"Çekilecek tutarı girin: ");
            miktarString = Console.ReadLine();
            miktar = double.TryParse(miktarString, out double paraCek) ? paraCek : (double?)null;
            vadesizHesap.ParaCek(miktar);
            break;
        default:
            throw new Exception("Geçersiz kategori seçimi (0-3 arası girin).");
    }
    Console.Write($"Menüye geri dönmek ister misiniz? E/H: ");
    string? secimString = Console.ReadLine();
    if (secimString == "E") continue;
    else if (secimString == "H") break;
    else Console.WriteLine("Hatalı giriş lüfen tekrar deneyin");
}

//2:  "Urun" class'ı yaz. Ad, Fiyat, Stok özellikleri olsun.
//    Fiyat negatif olamaz, Stok negatif olamaz.
//    SatisYap(int adet) metodu olsun: stok yetmiyorsa exception fırlatsın.
//Urun kalem = new Urun { Ad = "kalem", Fiyat = 10, Stok = 100 };
//Urun silgi = new Urun { Ad = "silgi", Fiyat = 15, Stok = 75 };
//Urun cetvel = new Urun { Ad = "cetvel", Fiyat = 50, Stok = 120 };
//Urun defter = new Urun { Ad = "defter", Fiyat = 40, Stok = 83 };

//List<Urun> urunler = new List<Urun>()
//{
//   kalem,
//   silgi,
//   cetvel,
//   defter
//};
//Console.WriteLine("Kırtasiyemize hoş geldiniz!");
//Console.Write("Alışveriş öncesinde harçlık miktarınızı girin: ");
//string? girdi = Console.ReadLine();
//double? harclik = double.TryParse(girdi, out double deger) ? deger : (double?)null;
//if (harclik == null)
//    throw new ArgumentException("Alışverişe başlamak için mutlaka bir değer girmelisiniz");
//else
//{
//    while (true)
//    {
//        Console.Clear();
//        Console.WriteLine("Almak istediğiniz ürünü seçin");
//        Console.WriteLine("=-=-=-=-=-=MENU=-=-=-=-=-=\n" +
//                          "1)Kalem\n" +
//                          "2)Silgi\n" +
//                          "3)Cetvel\n" +
//                          "4)Defter\n" +
//                          "5)Harclik tutar ekleme\n" +
//                          "6)Cikis");
//        int? secim = int.Parse(Console.ReadLine());
//        if (secim != null)
//        {
//            double? toplam = 0.00;
//            switch (secim)
//            {
//                case 1:
//                    Console.WriteLine("Kaç adet istersiniz?");
//                    girdi = Console.ReadLine();
//                    int? adet = int.TryParse(girdi, out int degerKalem) ? degerKalem : (int?)null;
//                    toplam = kalem.Fiyat * adet;

//                    if ((harclik - toplam) < 0)
//                    {
//                        Console.WriteLine("Yetersiz bakiye");
//                    }
//                    else
//                    {
//                        kalem.SatisYap(adet);
//                        harclik -= toplam;
//                        Console.WriteLine($"Satış yapıldı");
//                    }

//                    Console.WriteLine($"Güncel bakiye: {harclik}");
//                    break;
//                case 2:
//                    Console.WriteLine("Kaç adet istersiniz?");
//                    girdi = Console.ReadLine();
//                    adet = int.TryParse(girdi, out int degerSilgi) ? degerSilgi : (int?)null;
//                    toplam = silgi.Fiyat * adet;
//                    if ((harclik - toplam) < 0)
//                    {
//                        Console.WriteLine("Yetersiz bakiye");
//                    }
//                    else
//                    {
//                        silgi.SatisYap(adet);
//                        harclik -= toplam;
//                        Console.WriteLine($"Satış yapıldı");
//                    }

//                    Console.WriteLine($"Güncel bakiye: {harclik}");
//                    break;
//                case 3:
//                    Console.WriteLine("Kaç adet istersiniz?");
//                    girdi = Console.ReadLine();
//                    adet = int.TryParse(girdi, out int degerCetvel) ? degerCetvel : (int?)null;
//                    toplam = cetvel.Fiyat * adet;
//                    if ((harclik - toplam) < 0)
//                    {
//                        Console.WriteLine("Yetersiz bakiye");
//                    }
//                    else
//                    {
//                        cetvel.SatisYap(adet);
//                        harclik -= toplam;
//                        Console.WriteLine($"Satış yapıldı");
//                    }

//                    Console.WriteLine($"Güncel bakiye: {harclik}");
//                    break;
//                case 4:
//                    Console.WriteLine("Kaç adet istersiniz?");
//                    girdi = Console.ReadLine();
//                    adet = int.TryParse(girdi, out int degerDefter) ? degerDefter : (int?)null;
//                    toplam = defter.Fiyat * adet;
//                    if ((harclik - toplam) < 0)
//                    {
//                        Console.WriteLine("Yetersiz bakiye");
//                    }
//                    else
//                    {
//                        defter.SatisYap(adet);
//                        harclik -= toplam;
//                        Console.WriteLine($"Satış yapıldı");
//                    }


Urun kalem = new Urun { Ad = "kalem", Fiyat = 10, Stok = 100 };
Urun silgi = new Urun { Ad = "silgi", Fiyat = 15, Stok = 75 };
Urun cetvel = new Urun { Ad = "cetvel", Fiyat = 50, Stok = 120 };
Urun defter = new Urun { Ad = "defter", Fiyat = 40, Stok = 83 };

List<Urun> urunler = new List<Urun>()
{
   kalem,
   silgi,
   cetvel,
   defter
};
Console.WriteLine("Kırtasiyemize hoş geldiniz!");
Console.Write("Alışveriş öncesinde harçlık miktarınızı girin: ");
string? girdi = Console.ReadLine();
double? harclik = double.TryParse(girdi, out double deger) ? deger : (double?)null;
if (harclik == null)
    throw new ArgumentException("Alışverişe başlamak için mutlaka bir değer girmelisiniz");
else
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Almak istediğiniz ürünü seçin");
        Console.WriteLine("=-=-=-=-=-=MENU=-=-=-=-=-=\n" +
                          "1)Kalem\n" +
                          "2)Silgi\n" +
                          "3)Cetvel\n" +
                          "4)Defter\n" +
                          "5)Harclik tutar ekleme\n" +
                          "6)Cikis");
        int? secim = int.Parse(Console.ReadLine());
        if (secim != null)
        {
            double? toplam = 0.00;
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Kaç adet istersiniz?");
                    girdi = Console.ReadLine();
                    int? adet = int.TryParse(girdi, out int degerKalem) ? degerKalem : (int?)null;
                    toplam = kalem.Fiyat * adet;

                    if ((harclik - toplam) < 0)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    else
                    {
                        kalem.SatisYap(adet);
                        harclik -= toplam;
                        Console.WriteLine($"Satış yapıldı");
                    }

                    Console.WriteLine($"Güncel bakiye: {harclik}");
                    break;
                case 2:
                    Console.WriteLine("Kaç adet istersiniz?");
                    girdi = Console.ReadLine();
                    adet = int.TryParse(girdi, out int degerSilgi) ? degerSilgi : (int?)null;
                    toplam = silgi.Fiyat * adet;
                    if ((harclik - toplam) < 0)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    else
                    {
                        silgi.SatisYap(adet);
                        harclik -= toplam;
                        Console.WriteLine($"Satış yapıldı");
                    }

                    Console.WriteLine($"Güncel bakiye: {harclik}");
                    break;
                case 3:
                    Console.WriteLine("Kaç adet istersiniz?");
                    girdi = Console.ReadLine();
                    adet = int.TryParse(girdi, out int degerCetvel) ? degerCetvel : (int?)null;
                    toplam = cetvel.Fiyat * adet;
                    if ((harclik - toplam) < 0)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    else
                    {
                        cetvel.SatisYap(adet);
                        harclik -= toplam;
                        Console.WriteLine($"Satış yapıldı");
                    }

                    Console.WriteLine($"Güncel bakiye: {harclik}");
                    break;
                case 4:
                    Console.WriteLine("Kaç adet istersiniz?");
                    girdi = Console.ReadLine();
                    adet = int.TryParse(girdi, out int degerDefter) ? degerDefter : (int?)null;
                    toplam = defter.Fiyat * adet;
                    if ((harclik - toplam) < 0)
                    {
                        Console.WriteLine("Yetersiz bakiye");
                    }
                    else
                    {
                        defter.SatisYap(adet);
                        harclik -= toplam;
                        Console.WriteLine($"Satış yapıldı");
                    }

                    Console.WriteLine($"Güncel bakiye: {harclik}");
                    break;
                case 5:
                    Console.WriteLine("Kaç TL eklemek istersiniz?");
                    girdi = Console.ReadLine();
                    double? eklenecekTutar = double.TryParse(girdi, out double deger1) ? deger1 : (double?)null;
                    if (eklenecekTutar is double)
                    {
                        harclik += eklenecekTutar;
                        Console.WriteLine($"Güncel bakiye: {harclik}");
                    }
                    else
                        throw new Exception("Hata! Kontrol edip tekrar deneyin!");
                    break;
                case 6:
                    Console.WriteLine("Çıkış yapıldı");
                    break;
                default:
                    throw new Exception("Hata! Girilen değer limit dışıdır. 1-6 arası bir değer girilmelidir");
            }
            if (secim != 6)
            {
                Console.WriteLine("Almak istediğiniz başka ürün ya da yapmak istediğiniz işlem var mıdır? E/H");
                girdi = Console.ReadLine();
                if (string.Equals(girdi, "E", StringComparison.OrdinalIgnoreCase)) continue;
                else break;
            }

        }
        else throw new NullReferenceException("Değer boş bırakılamaz. 1-6 arası değer girilmelidir");
    }
}

//3:  "Ogrenci" class'ını dünkü sürümden yükselt:
//    - Yaş 0 - 120 arasında olmalı(property ile kontrol)
//    -OgrenciNo sadece okunabilsin(private set)
//    -Constructor ile Ad, Soyad ve OgrenciNo zorunlu olsun

Ogrenci ogrenci = new Ogrenci("Hasan Cem", "Pınar", 32);
ogrenci.Yas = 12;
ogrenci.KendiniTanit();

//4:  "Araba" class'ı yaz. 
//    - Motor hacmi(cc) olsun: 600 - 7000 arası olmalı
//    - Yıl: 1900'den küçük ya da bu yıldan büyük olamaz
//    - KmEkle(int km) metodu: toplam km'yi artırsın ama negatif girilirse hata versin

Araba araba = new Araba("Renault", "Clio Symbol", 1499, 2006, 132200);
araba.KmEkle(1000);
Console.WriteLine(araba);

//5:  (Bonus)"Sifre" class'ı yaz:
//    - Şifre sadece set edilebilsin (write-only property!)
//    - SifreDogrula(string deneme) → true/false dönsün
//    - Şifre hiçbir zaman dışarıya verilemez (getter yok!)

Sifre sifre = new Sifre("12345");

sifre.SifreDogrula("12345");