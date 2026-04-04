////1:  5 elemanlı int dizisi tanımla, for ile yazdır

//int[] sayiListesi = [1,2,3,4,5];

//for(int q = 0; q < sayiListesi.Length; q++)
//{ 
//    Console.WriteLine($"Listemizin {q+1}. elemanı, {sayiListesi[q]}");
//}

////2:  Kullanıcıdan 5 not al (diziye kaydet), foreach ile yazdır

//int[] kullaniciNotlari = new int[5];
//Console.Write("5 adet sayı girin:\n");

//for(int i = 0; i < 5; i++)
//{
//    Console.Write("- ");
//    int girilenSayi = int.Parse(Console.ReadLine()!);
//    kullaniciNotlari[i] = girilenSayi;
//}
//foreach(int eleman in kullaniciNotlari)
//{
//    Console.WriteLine($"Liste elemanlarımız: {eleman}");
//} 

////3:  Bir int dizisinin en büyük elemanını bul (for ile, Array.Sort kullanma)

//int[] sayilarListesi = new int[] { 15, 1, 90, 53, 67, 59 };
//int enBuyuk = sayilarListesi[0];

//foreach (int gelen in sayilarListesi)
//{
//    enBuyuk = (gelen > enBuyuk) ? enBuyuk = gelen : enBuyuk;
//}
//Console.WriteLine($"Listenin en büyük sayısı {enBuyuk}.");

////4:  Bir int dizisinin en küçük elemanını bul

//int[] sayilarListesi = new int[] { 15, 1, 90, 53, 67, 59 };
//int enKucuk = sayilarListesi[0];

//foreach (int gelen in sayilarListesi)
//{
//    enKucuk = (gelen < enKucuk) ? enKucuk = gelen : enKucuk;
//}
//Console.WriteLine($"Listenin en küçük sayısı {enKucuk}.");

//5:  Bir int dizisinin ortalamasını hesapla

int[] sayilarListesi = new int[] { 15, 1, 90, 53, 67, 59 };
int toplam = 0;
double ortalama = 0; 

foreach (int gelen in sayilarListesi)
{
    toplam += gelen; 
}
ortalama = (double)toplam / sayilarListesi.Length;
Console.WriteLine($"Liste elemanlarının ortalaması: {ortalama:N2}");

//6:  Bir diziyi ters sırada yazdır (Array.Reverse kullanmadan, for ile)
//7:  Bir string dizisinde kullanıcının aradığı elemanı bul, index'ini yazdır
//8:  İki diziyi birleştirip yeni bir diziye koy
//9:  Bir dizideki tekrar eden elemanları bul
//10: Array.Sort ile diziyi sırala, Array.Reverse ile ters çevir
//11: 3x3 matris tanımla, iç içe for ile yazdır
//12: Kullanıcıdan 10 not al, en yüksek, en düşük ve ortalamayı göster

/*
🔨 Mini Proje: Öğrenci Not Sistemi
Kullanıcıdan öğrenci sayısını al
Her öğrenci için isim ve not al (iki dizi: isimler[] ve notlar[])
Harf notu hesapla
En yüksek, en düşük, sınıf ortalaması göster
Ortalamanın üstündeki öğrencileri listele
*/