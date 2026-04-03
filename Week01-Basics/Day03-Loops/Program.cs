
//1:  1'den 10'a kadar sayıları yazdır (for)

for (byte i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

//2:  10'dan 1'e kadar geri sayım yap (for)

for (byte n = 10; n >= 1; n--)
{
    Console.WriteLine(n);
}

//3:  1'den 100'e kadar çift sayıları yazdır (for + if veya for ile i+=2)

for (byte x = 1; x <= 100; x++)
{
    if (x % 2 == 0) Console.WriteLine(x);
}

//4:  Kullanıcıdan sayı al, o sayının faktöriyelini hesapla (for)

Console.Write("Tam sayi yazın: ");
int y = int.Parse(Console.ReadLine()!);
int sonuc = 1;
for (; 0 < y; y--)
{
    sonuc *= y;
}
Console.WriteLine($"İslem sonucu: {sonuc}");

//5:  Çarpım tablosu: kullanıcıdan sayı al, 1-10 arası çarpımını göster (for)

Console.Write("Tam sayı yazın: ");
int z = int.Parse(Console.ReadLine()!);
for (int k = 1; k <= 10; k++)
{
    Console.WriteLine($"{z} x {k} = {z * k}");
}

//6:  1'den 100'e kadar sayıların toplamını bul (while)

int sayi = 1;
int toplam = 0;
while (sayi <= 100)
{
    toplam += sayi;
    sayi++;
}
Console.WriteLine($"Toplam: {toplam}");

//7:  Kullanıcıdan sürekli sayı al, 0 girene kadar devam et, toplamı göster (while)

int top = 0;

while (true)
{
    Console.Write("Sayı girin: ");
    int girilenSayi = int.Parse(Console.ReadLine()!);
    if (girilenSayi != 0)
    {
        top += girilenSayi;
    }
    else break;
}

Console.WriteLine($"Toplam: {top}");

//8:  Şifre kontrolü: doğru şifre girilene kadar sor, 3 hak ver (while + sayaç)

string dogruSifre = "12345";
int verilenHak = 3;

while (verilenHak > 0)
{
    Console.Write("Lütfen şifre girin: ");
    string girilenSifre = Console.ReadLine()!;
    if (girilenSifre == dogruSifre) { Console.WriteLine("Erişim verildi"); break; }
    else
    {
        verilenHak--;
        if (verilenHak == 0) { Console.WriteLine("Giriş başarısız, hesap bloke edildi."); break; }
    }
}

//9:  Menü sistemi: do -while ile seçenek göster, çıkış seçilene kadar dönsün

int secim;
do
{
    Console.WriteLine("===== MENÜ =====");
    Console.WriteLine("1) Profili Görüntüle");
    Console.WriteLine("2) Ayarlar");
    Console.WriteLine("3) Yardım");
    Console.WriteLine("4) Çıkış");
    Console.Write("Seçiminiz: ");

    secim = int.Parse(Console.ReadLine()!);

    switch (secim)
    {
        case 1:
            Console.WriteLine("Profil sayfası açıldı.\n");
            break;
        case 2:
            Console.WriteLine("Ayarlar sayfası açıldı.\n");
            break;
        case 3:
            Console.WriteLine("Yardım sayfası açıldı.\n");
            break;
        case 4:
            Console.WriteLine("Çıkış yapıldı.");
            break;
        default:
            Console.WriteLine("Geçersiz seçim!\n");
            break;
    }

} while (secim != 4);


//10: Bir string dizisi tanımla, foreach ile elemanları yazdır

string[] arabalar = ["audi", "bmw", "mercedes", "skoda", "lancia"];

foreach (string araba in arabalar)
{
    Console.WriteLine(araba);
}

//11: Bir int dizisi tanımla, foreach ile toplamını bul

int[] sayilar = [12, 33, 2, 45, 65, 32, 23, 41, 1];
int total = 0;
foreach (int say in sayilar)
{
    toplam += say;
}
Console.WriteLine($"Toplam: {total}");

//12: İç içe for: 5x5 yıldız(*) matrisi yazdır 

for (int satir = 1; satir <= 5; satir++)
{
    for (int sutun = 1; sutun <= 5; sutun++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}

//13: İç içe for: dik üçgen yıldız deseni yazdır

for (int satir = 1; satir <= 5; satir++)
{
    for (int sutun = 1; sutun <= satir; sutun++)
    {
        Console.Write("* ");
    }
    Console.WriteLine("");
}

//14: 1 - 100 arası asal sayıları bul (for + iç içe for/kontrol)

 for(int bizimSayi = 2; bizimSayi <= 100; bizimSayi++)
{
    bool asalMi = true;

    for(int bolen = 2; bolen < bizimSayi; bolen++)
    {
        if (bizimSayi % bolen == 0)
        {
            asalMi = false;
            break;
        }
    }
    if (asalMi)
        Console.WriteLine(bizimSayi);
}

//15: FizzBuzz: 1 - 100 arası, 3'e bölünenler "Fizz", 5'e bölünenler "Buzz", ikisine de bölünenler "FizzBuzz"

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0) Console.WriteLine($"{i},FizzBuzz");
    else if (i % 5 == 0) Console.WriteLine($"{i},Buzz");
    else if (i % 3 == 0) Console.WriteLine($"{i},Fizz");
}