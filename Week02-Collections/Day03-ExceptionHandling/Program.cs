//1:  Kullanıcıdan bir yaş (int) iste. Harf girerse program çökmesin, try-catch ile "Geçersiz yaş girdiniz" yazsın.
try
{
    Console.Write("Bir yaş girin: ");
    int girilenYas = int.Parse(Console.ReadLine()!);
}
catch (Exception hata)
{
    Console.WriteLine($"Hatali giris! Lütfen kontrol edip tekrar deneyin");
}

//2:  Kullanıcıdan 2 sayı al ve böl. Sıfıra bölme hatasını (DivideByZeroException) ve format hatasını (FormatException) ayrı ayrı yakala.
try
{
    Console.Write("Bir sayı girin: ");
    double birinciSayi = double.Parse(Console.ReadLine()!);
    Console.Write("Bir sayı daha girin: ");
    double ikinciSayi = double.Parse(Console.ReadLine()!);
    if (ikinciSayi == 0) throw new DivideByZeroException("Bölme işleminde ikinci eleman sıfır olamaz");
    else Console.WriteLine($"İşlem sonucu: {birinciSayi / ikinciSayi}");
}
catch (DivideByZeroException hata)
{
    Console.WriteLine(hata.Message);
}

catch (FormatException)
{
    Console.WriteLine($"Hata! Lütfen kontrol edip tekrar deneyin. Format hatası...");
}

//3:  5 elemanlı bir int dizisi oluştur. Kullanıcıdan bir indeks numarası iste ve o indeksteki değeri yazdır. Kullanıcı 10 girerse çıkacak IndexOutOfRangeException hatasını yakala.
try
{
    int[] integerDizisi = { 0, 1, 2, 3, 4 };
    Console.Write($"Indeks no girin: ");
    int indeksNo = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Seçilen indeks no'ya göre liste elemanı: {integerDizisi[indeksNo]}");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Liste boyutunu aştı. Tekrar deneyin, girilen deger 1-5 arasında olmalı.");
}

//4:  Bir do-while döngüsü içinde kullanıcıdan geçerli bir tamsayı (int) istesin. Kullanıcı doğru formatta bir sayı girene kadar sormaya ve hata mesajı vermeye devam etsin. (Özellikle çok işe yarar!)
bool basarili = false;

do
{
    try
    {
        Console.Write("Bir tam sayı girin: ");
        int sayi = int.Parse(Console.ReadLine()!);
        basarili = true;
        Console.WriteLine($"Başarılı! Girdiğiniz sayı: {sayi}");
    }
    catch (FormatException)
    {
        Console.WriteLine("HATA: Geçersiz bir format girdiniz. Tekrar deneyin.");
    }

} while (!basarili);

//5:  Kendi Hatanı Fırlat (Throw): Bir metot yaz (Örn: void YasDogrula(int yas)). Eğer yaş 0'dan küçük veya 120'den büyük gelirse throw new ArgumentOutOfRangeException("Geçersiz yaş!") fırlatsın.Programda try-catch ile metodu test et.
try
{
    Console.Write("Yaşınızı girin: ");
    int yas = int.Parse(Console.ReadLine()!);
    YasDogrula(yas);
}
catch (Exception)
{
    Console.WriteLine("Geçersiz yaş!");
}
void YasDogrula(int yas)
{
    if (yas <= 0 || yas >= 120) throw new ArgumentOutOfRangeException("Geçersiz yaş!");
}
