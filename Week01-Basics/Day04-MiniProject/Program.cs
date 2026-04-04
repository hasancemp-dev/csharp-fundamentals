
//1.Kullanıcıdan öğrenci sayısını al
Console.Write("Öğrenci sayısı: ");
int ogrenciSayisi = int.Parse(Console.ReadLine()!);
Console.Write(ogrenciSayisi+ "\n");
//2. Her öğrenci için isim ve not al (iki dizi: isimler[] ve notlar[])
string[] isimler = new string[ogrenciSayisi];
string isim;
int[] notlar = new int[ogrenciSayisi];
int not = 0;
Console.Write($"══════════════════════════\n" +
              $"  SINIF KARNESI\n" +
              $"══════════════════════════\n");
string harfNotu = "";
for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.Write($"{i + 1}. İsim: "); 
    isim = Console.ReadLine()!;
    isimler[i] = isim;
    Console.Write("Not: ");
    not = int.Parse(Console.ReadLine()!);
    notlar[i] = not;
    if (not >= 85) harfNotu = "A";
    else if (not >= 75) harfNotu = "B";
    else if (not >= 65) harfNotu = "C";
    else if (not >= 45) harfNotu = "D";
    else harfNotu = "F";
    Console.WriteLine($"{isimler[i]}    - {notlar[i]} - {harfNotu}");
}
//3.Harf notunu hesapla(85+ A, 75+ B, 65+ C, 45+ D, altı F)
 
//4.En yüksek notu, en düşük notu ve sınıf ortalamasını göster
int enYuksek = notlar[0];
int enDusuk = notlar[0];
int toplam = 0;
double ortalama = 0;
for (int i = 0; i < ogrenciSayisi; i++)
{
    toplam += notlar[i];
}
for (int i = 0; i < notlar.Length; i++)
{
    if (notlar[i] > enYuksek) enYuksek = notlar[i];
    if (notlar[i] < enDusuk) enDusuk = notlar[i];
}
ortalama = (double)toplam / notlar.Length;

Console.WriteLine($"En yüksek : {enYuksek}\n" +
                  $"En düşük  : {enDusuk}\n" +
                  $"Ortalaması: {ortalama:N2}");

//5. Ortalamanın üstündeki öğrencileri listele
int sayac = 0;
Console.WriteLine($"Ortalama üstündekiler:");
foreach (int gelen in notlar)
{
    if (gelen > ortalama) 
    {
        Console.WriteLine($"- {isimler[sayac]} ({notlar[sayac]})"); 
    }
    sayac++;
}

/*
 

Öğrenci sayısı: 3
1. İsim: Ali    Not: 85
2. İsim: Veli   Not: 60
3. İsim: Ayşe   Not: 92

══════════════════════════
  SINIF KARNESI
══════════════════════════
Ali    - 85 - A
Veli   - 60 - D
Ayşe   - 92 - A

En yüksek: 92 (Ayşe)
En düşük:  60 (Veli)
Ortalama:  79.00

Ortalamanın üstündekiler:
- Ali (85)
- Ayşe (92)



*/