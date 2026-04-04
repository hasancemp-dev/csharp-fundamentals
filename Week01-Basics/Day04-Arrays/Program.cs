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

////5:  Bir int dizisinin ortalamasını hesapla

//int[] sayilarListesi = new int[] { 15, 1, 90, 53, 67, 59 };
//int toplam = 0;
//double ortalama = 0; 

//foreach (int gelen in sayilarListesi)
//{
//    toplam += gelen; 
//}
//ortalama = (double)toplam / sayilarListesi.Length;
//Console.WriteLine($"Liste elemanlarının ortalaması: {ortalama:N2}");

////6:  Bir diziyi ters sırada yazdır (Array.Reverse kullanmadan, for ile)

//string[] isMakineleri = new string[] {"vinç", "kamyon", "greyder", "ekskavatör", "kepçe" };

//Console.WriteLine("Liste elemanlarının tersten sıralanışı:");
//for (int i = isMakineleri.Length - 1; i >= 0; i--)
//{
//    Console.WriteLine("-" + isMakineleri[i]); 
//}

////7:  Bir string dizisinde kullanıcının aradığı elemanı bul, index'ini yazdır

//string[] stringDizesi = new string[] { "su sisesi", "atistirmaliklar", "atiklar", "genel ayarlar", "ilaclar", "health bar", "ecza dolabi", "giyim cekmecesi" };

//Console.Write("Aradığınız liste elemanını birebir girin(Türkçe karakter olmadan): ");
//string arananDize = Console.ReadLine()!;

//Console.WriteLine($"Aradığınız liste elemanın indexi: {Array.IndexOf(stringDizesi, arananDize)} ");

////8:  İki diziyi birleştirip yeni bir diziye koy

//int[] birinciDize = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int[] ikinciDize = new int[] { 8, 7, 6, 5, 4, 3, 2, 1 };
//int[] birlesim = new int[birinciDize.Length+ikinciDize.Length];
//Console.Write("Yeni liste elemanları: ");

//for(int i = 0; i <birinciDize.Length; i++)
//{
//    birlesim[i] = birinciDize[i];
//}
//for(int i = 0; i <ikinciDize.Length; i++)
//{
//    birlesim[i + birinciDize.Length] = ikinciDize[i];
//}
//foreach(int gelen in birlesim)
//{
//    Console.WriteLine(gelen);
//}

////9:  Bir dizideki tekrar eden elemanları bul ?????
//int[] liste = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

//for (int i = 0; i < liste.Length; i++)
//{
//    for (int j = i + 1; j < liste.Length; j++)  // i'den sonrakilerle karşılaştır
//    {
//        if (liste[i] == liste[j])
//        {
//            Console.WriteLine($"Tekrar eden: {liste[i]}");
//            break;  // aynı elemanı birden fazla yazdırma
//        }
//    }
//}


////10: Array.Sort ile diziyi sırala, Array.Reverse ile ters çevir

//int[] liste = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
//Array.Sort(liste);
//Array.Reverse(liste);
//foreach (int gelen in liste)
//{
//    Console.WriteLine(gelen);
//}

////11: 3x3 matris tanımla, iç içe for ile yazdır

//int[,] matris =
//{
//    {1,2,3},
//    {4,5,6},
//    {7,8,9}
//};
//for (int satir = 0; satir < 3; satir++)
//{
//    for (int sutun = 0; sutun < 3; sutun++)
//    {
//        Console.Write($"{matris[satir,sutun]}");
//    }
//    Console.WriteLine("");
//}

////12: Kullanıcıdan 10 not al, en yüksek, en düşük ve ortalamayı göster

//Console.Write($"10 adet sayı giriniz: \n");
//int[] girilenSayilar = new int[10];
//int girilenSayi;
//int min;
//int max;
//int toplam = 0;
//double ortalama = 0;
//for (int i = 0; i < 10; i++)
//{
//    girilenSayi = int.Parse(Console.ReadLine()!);
//    girilenSayilar[i] = girilenSayi;
//    toplam += girilenSayi;
//}
//min = girilenSayilar[0];
//max = girilenSayilar[0];
//for (int i = 1; i < 10; i++)
//{
//    if (girilenSayilar[i] > max) max = girilenSayilar[i];
//    if (girilenSayilar[i] < min) min = girilenSayilar[i];
//}
//ortalama = (double)toplam / 10;

//Console.WriteLine($"Girdiğiniz sayıların en büyüğü: {max}, en küçüğü: {min}, ortalaması {ortalama}");

/*
🔨 Mini Proje: Öğrenci Not Sistemi
Kullanıcıdan öğrenci sayısını al
Her öğrenci için isim ve not al (iki dizi: isimler[] ve notlar[])
Harf notu hesapla
En yüksek, en düşük, sınıf ortalaması göster
Ortalamanın üstündeki öğrencileri listele

*/