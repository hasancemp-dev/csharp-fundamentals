/*
1:  Kullanıcıdan yaş al, 18'den büyükse "Yetişkin", değilse "Çocuk" yazdır
2:  Kullanıcıdan not al (0-100), harf notunu yazdır (A/B/C/D/F)
3:  Kullanıcıdan sayı al, pozitif/negatif/sıfır olduğunu söyle
4:  İki sayı al, büyük olanı yazdır (if-else ile)
5:  Üç sayı al, en büyüğünü bul (if-else ile)
6:  Kullanıcıdan yıl al, artık yıl mı kontrol et (4'e bölünür, 100'e bölünmez veya 400'e bölünür)
7:  Kullanıcıdan gün numarası al (1-7), switch ile gün adını yazdır
8:  Kullanıcıdan ay numarası al (1-12), switch ile kaç gün olduğunu söyle
9:  Basit hesap makinesi: iki sayı + operatör al, switch ile sonucu hesapla (+, -, *, /)
10: Kullanıcıdan sıcaklık al, 0 altı "Dondurucu", 0-15 "Soğuk", 15-25 "Ilık", 25+ "Sıcak"
11: Ternary ile: sayı çift mi tek mi kontrol et (sayi % 2 == 0 ? "Çift" : "Tek")
12: Ternary ile: iki string'den uzun olanını yazdır
13: && operatörü: yaş 18-65 arası VE öğrenci değilse "Tam bilet", değilse "İndirimli"
14: || operatörü: kullanıcı admin VEYA moderatör ise "Erişim var", değilse "Erişim yok"
15: İç içe if: kullanıcıdan cinsiyet ve yaş al, askerlik durumunu belirle
*/

//1

Console.Write("Yaşınızı girin: ");
int yas = int.Parse(Console.ReadLine()!);

if (yas >= 18)
{
    Console.WriteLine("Yetişkin");
}
else
{
    Console.WriteLine("Çocuk");
}

//2

Console.Write("Notunuzu girin: ");
int not = int.Parse(Console.ReadLine()!);

if (not >= 85)
{
    Console.WriteLine("Harf notunuz A, Tebrikler!");
}
else if (not >= 75)
{
    Console.WriteLine("Harf notunuz B, Başarılı");
}
else if (not >= 65)
{
    Console.WriteLine("Harf notunuz C, Geçer");
}
else if (not >= 45)
{
    Console.WriteLine("Harf notunuz D, Koşullu Geçer");
}
else
{
    Console.WriteLine("Harf notunuz F, Başarısız");
}

//3

Console.Write("Bir sayı girin: ");
int sayi = int.Parse(Console.ReadLine()!);

if (sayi > 0)
    Console.WriteLine("Sayı pozitif :)");

else if (sayi < 0)
    Console.WriteLine("Sayı negatif :(");
else
    Console.WriteLine("Sayı nötr :|");

//4

Console.WriteLine("2 adet sayi girin: ");
Console.Write("1. ");

int sayi1 = int.Parse(Console.ReadLine()!);

Console.Write("2. ");

int sayi2 = int.Parse(Console.ReadLine()!);


if (sayi1 > sayi2) Console.WriteLine($"{sayi1} olarak girilen ilk sayı büyüktür");
else if (sayi2 > sayi1) Console.WriteLine($"{sayi2} olarak girilen ikinci sayı büyüktür");
else Console.WriteLine("Sayılar birbirine eşit");

//5

Console.WriteLine("3 adet sayi girin: ");
Console.Write("1. ");

int ilkSayi = int.Parse(Console.ReadLine()!);

Console.Write("2. ");

int ikinciSayi = int.Parse(Console.ReadLine()!);

Console.Write("3. ");

int ucuncuSayi = int.Parse(Console.ReadLine()!);

int enBuyukSayi = ilkSayi;

if (enBuyukSayi < ikinciSayi) enBuyukSayi = ikinciSayi;
if (enBuyukSayi < ucuncuSayi) enBuyukSayi = ucuncuSayi;
Console.WriteLine($"En büyük sayı = {enBuyukSayi}");


//6 Buna çalış ve hep kısa ve öz yazmaya bak - !!! Her durumda değil !!!

Console.Write("Yıl giriniz(YYYY): ");
int yil = int.Parse(Console.ReadLine()!);

if ((yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0))
    Console.WriteLine("Artık yıl");
else
    Console.WriteLine("Artık yıl değil");

//7

Console.Write("Bir gün numarası girin(1-7): ");
int gun = int.Parse(Console.ReadLine()!);

switch(gun)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz işlem");
        break;
}

//8

Console.Write("İstediğiniz bir ayın sayı karşılığını girin(1-12): ");
int ay = int.Parse(Console.ReadLine()!);

switch (ay)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("31 gün");
        break;
    case 2:
        Console.WriteLine("28 gün");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("30 gün");
        break;
    default:
        Console.WriteLine("Geçersiz giriş");
        break;
}

//9

Console.Write("2 adet sayı giriniz:\n" +
              "1. ");
double firstNumber = double.Parse(Console.ReadLine()!);

Console.Write("2. ");

double secondNumber = double.Parse(Console.ReadLine()!);

Console.Write("İşlem operatörü seçiniz(1-4): \n" +
              "1. Toplama\n" +
              "2. Çıkarma\n" +
              "3. Çarpma\n" +
              "4. Bölme\n" +
              "Seçiniz: ");

int islem = int.Parse(Console.ReadLine()!);
double sonuc;

switch(islem)
{
    case 1:
        sonuc = firstNumber + secondNumber;
        Console.WriteLine(sonuc);
        break;
    case 2:
        sonuc = firstNumber - secondNumber;
        Console.WriteLine(sonuc);
        break;
    case 3:
        sonuc = firstNumber * secondNumber;
        Console.WriteLine(sonuc);
        break;
    case 4:
        if (secondNumber == 0) Console.WriteLine("Bölme işleminde ikinci sayı 0(sıfır) olamaz");
        else
        {
            sonuc = firstNumber / secondNumber;
            Console.WriteLine(sonuc);
        }
        break;
}

//10

Console.Write("Hava kaç derece(Celsius): ");
int havaSicakligi = int.Parse(Console.ReadLine()!);

if (havaSicakligi <= 0)
    Console.WriteLine("Dondurucu");
else if (havaSicakligi > 0 && havaSicakligi <= 15)
    Console.WriteLine("Soğuk");
else if (havaSicakligi > 15 && havaSicakligi <= 25)
    Console.WriteLine("Ilık");
else
    Console.WriteLine("Sıcak");

//11

Console.Write("Sayı giriniz: ");

int number = int.Parse(Console.ReadLine()!);

string islemSonucu = (number % 2 == 0) ? "Çift" : "Tek";

Console.WriteLine(islemSonucu);

//12

Console.Write("2 Cümle yazınız: \n" +
              "1. ");

string ilkCumle = Console.ReadLine()!;

Console.Write("2. ");

string ikinciCumle = Console.ReadLine()!;


string uzunCumle = (ilkCumle.Length > ikinciCumle.Length) ? ilkCumle : ikinciCumle;

Console.WriteLine($"En uzun cümle '{uzunCumle}' ");

//13   

Console.Write("Yaşınızı girin: ");

int kisininYasi = int.Parse(Console.ReadLine()!);

Console.Write("Öğrenci misiniz Evet için E/Hayır için H basın: ");

char ogrenciMi = char.Parse(Console.ReadLine()!); 

if (kisininYasi >= 18 && kisininYasi <= 65 && ogrenciMi == 'H') Console.WriteLine("Tam");
else Console.WriteLine("İndirimli");

//14

Console.Write("Rolünüz nedir?: ");

string rol = Console.ReadLine()!;

if (rol == "admin" || rol == "moderatör")
    Console.WriteLine("Erişim izniniz var");
else
    Console.WriteLine("Erişim izniniz yok");

//15

Console.Write("Cinsiyetinizi girin Erkek için E / Kız için K: ");

char cinsiyetSecimi = char.Parse(Console.ReadLine()!);

Console.Write("Yaşınızı girin: ");

yas = int.Parse(Console.ReadLine()!);

if (cinsiyetSecimi == 'K')
    Console.WriteLine("Askerlikten muaf");
else
{
    if (yas < 20)
        Console.WriteLine($"Askerliğe kalan süre {20 - yas}");
    else
    {
        Console.WriteLine("Askerlik için elverişli");
    }
}
 

