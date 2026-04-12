using Day02_Encapsulation;
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

//3:  "Ogrenci" class'ını dünkü sürümden yükselt:
//    - Yaş 0 - 120 arasında olmalı(property ile kontrol)
//    -OgrenciNo sadece okunabilsin(private set)
//    -Constructor ile Ad, Soyad ve OgrenciNo zorunlu olsun

//4:  "Araba" class'ı yaz. 
//    - Motor hacmi(cc) olsun: 600 - 7000 arası olmalı
//    - Yıl: 1900'den küçük ya da bu yıldan büyük olamaz
//    - KmEkle(int km) metodu: toplam km'yi artırsın ama negatif girilirse hata versin


//5:  (Bonus)"Sifre" class'ı yaz:
//    - Şifre sadece set edilebilsin (write-only property!)
//    - SifreDogrula(string deneme) → true/false dönsün
//    - Şifre hiçbir zaman dışarıya verilemez (getter yok!)
