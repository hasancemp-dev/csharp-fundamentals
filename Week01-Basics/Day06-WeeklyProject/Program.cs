//🎮 SAYI TAHMİN OYUNU

//1. Bilgisayar 1-100 arası rastgele bir sayı tutar
//2. Oyuncu tahmin eder
//3. Her tahmin sonrası: "Daha büyük" veya "Daha küçük" ipucu verilir
//4. Oyuncu doğru bildiğinde kaç denemede bulduğu söylenir
//5. Maksimum 10 tahmin hakkı var
//6. Oyun bittikten sonra "Tekrar oynamak ister misiniz?" sorusu
//7. Skor tablosu: her oyunun sonucunu dizide sakla (kaç denemede buldu)

//🎮 SAYI TAHMİN OYUNU
//1-100 arası bir sayı tuttum. 10 hakkın var!

//Tahminini gir: 50
//⬆️ Daha büyük!

//Tahminini gir: 75
//⬇️ Daha küçük!

//Tahminini gir: 63
//🎉 Tebrikler! 3 denemede buldun!

//Tekrar oynamak ister misin? (E/H): E... (yeni oyun)

//📊 SKOR TABLOSU
//Oyun 1: 3 deneme
//Oyun 2: 7 deneme
//Oyun 3: Bulamadı

 

Random sayi = new Random();
 
int oyunSayisi = 1;
List<string> oyunlar = new List<string>();
string secim;

while (true)
{
    bool bulduMu = false;
    Console.Clear();
    Console.WriteLine(" ===========SAYI TAHMİN OYUNU===========");
    int rastgeleSayi = sayi.Next(1, 101);
    Console.WriteLine($"1-100 arası bir sayı tuttum. 10 hakkın var!");
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
            oyunSayisi++;
            break;
        }  
    }
    if (!bulduMu) 
    {
        Console.WriteLine("Hakkını doldurdun :( ");
        oyunlar.Add($"Oyun {oyunSayisi}: Bulamadı"); 
        oyunSayisi++; 
        Console.WriteLine($"Yeni oyun? E/H: ");
        secim = Console.ReadLine()!;
        if (secim == "E") continue; 
        else break; 
    } 
    if(bulduMu)
    {
        Console.WriteLine("Yeni oyun? E/H: ");
        secim = Console.ReadLine()!;
        if (secim == "E") continue;
        else break;
    }
}
foreach(var gelen in oyunlar)
{
    Console.WriteLine(gelen);
}