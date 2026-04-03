/*

4 işlem + mod alma (%)
Sıfıra bölme kontrolü
İşlem sonrası "Devam etmek ister misiniz? (E/H)" sorusu — (bunu henüz döngü öğrenmediğin için goto ile yapabilirsin veya atlayabilirsin)
Geçersiz operatör girişinde hata mesajı (default)
Operatörü sayı değil, karakter olarak al (+, -, *, /, %) 
  
 */


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
                  "Mod     %");
    string islem = Console.ReadLine()!;
    double sonuc = 0;
    string secim;
    bool gecerliIslem = true;
    switch (islem)
    {
        case "+":
            sonuc = ilkSayi + ikinciSayi;
            break;
        case "-":
            sonuc = ilkSayi - ikinciSayi;
            break;
        case "*":
            sonuc = ilkSayi * ikinciSayi;
            break;
        case "/":
            if (ikinciSayi != 0)
            {
                sonuc = ilkSayi / ikinciSayi;
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
            }
            else
            {
                Console.Write("Mod işleminde ikinci sayı 0 olamaz.");
                gecerliIslem = false;
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
    secim = Console.ReadLine()!;
    if (secim == "E") continue;
    else { Console.WriteLine("Hoşçakal!"); break; }
}

