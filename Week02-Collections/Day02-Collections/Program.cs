//1:  Boş bir List<string> oluştur, 5 şehir ekle, yazdır
using System.Linq;
using System.Runtime.Serialization;

List<string> listemiz = new List<string>()
{
    "Bursa",
    "Istanbul",
    "Ankara",
    "Izmir",
    "Kocaeli"
};

Console.WriteLine("Listemizdeki elemanlar sırasıyla:");
foreach (var eleman in listemiz)
{
    Console.WriteLine($"-{eleman}");
}

//2:  List'ten belirli bir şehri sil, kalan şehirleri yazdır
listemiz.Remove("Izmir");
Console.WriteLine("Güncel listemiz:");
foreach (var eleman in listemiz)
{
    Console.WriteLine($"-{eleman}");
}

//3:  Kullanıcıdan sürekli isim al, "q" girene kadar List'e ekle, sonra yazdır
Console.Write("Isim girin (cikmak istediğinizde 'q' & 'Q' tuslayın): ");
string isim;
while (true)
{
    isim = Console.ReadLine()!;
    if (isim == "q" || isim == "Q") break;
    listemiz.Add(isim);
}
Console.WriteLine("Güncel listemiz:");
foreach (var eleman in listemiz)
{
    Console.WriteLine($"-{eleman}");
}

//4:  List<int> ile sayılar al, en büyük, en küçük, ortalamayı bul
Console.Write("Sayi girin (cikmak istediğinizde '0(sifir)' tuslayın): ");
List<int> sayilar = new List<int>();
int sayi;
while (true)
{
    sayi = int.Parse(Console.ReadLine()!);
    if (sayi == 0) break;
    sayilar.Add(sayi);
}
Console.WriteLine($"Sayilar listesinin;\n" +
                  $"En büyük elemanı: {sayilar.Max()}\n" +
                  $"En küçük elemanı: {sayilar.Min()}\n" +
                  $"Ortalaması: {sayilar.Average()}");

//5:  İki List<int> birleştir, sırala, tekrar edenleri kaldır
Console.Write("Sayi girin (cikmak istediğinizde '0(sifir)' tuslayın): ");
List<int> digerSayilar = new List<int>();
while (true)
{
    sayi = int.Parse(Console.ReadLine()!);
    if (sayi == 0) break;
    digerSayilar.Add(sayi);
} 
digerSayilar.AddRange(sayilar);
digerSayilar.Sort();
List<int> benzersiz = digerSayilar.Distinct().ToList();

Console.WriteLine("Birleşmiş ve benzersiz liste:");
foreach (var eleman in benzersiz)
{
    Console.WriteLine($"-{eleman}");
}

//6:  Dictionary<string, int> ile öğrenci-not sistemi: isim - not ekle, yazdır

Dictionary<string, int> ogrenciNot = new Dictionary<string, int>();
Console.WriteLine($"Kac ogrenci gireceksiniz?");
int ogrenciSayisi = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Ogrenci isim ve notunu giriniz:");
int not;
for(int i = 0; i < ogrenciSayisi; i++)
{
    isim = Console.ReadLine()!;
    not = int.Parse(Console.ReadLine()!);
    ogrenciNot.Add(isim, not);
}

//7:  Dictionary ile telefon rehberi: isim - numara ekle, isimle arama yap
//8:  Dictionary ile kelime sayacı: cümledeki her kelimenin kaç kez geçtiğini say
//9:  List<string> içinde arama: kullanıcıdan kelime al, eşleşenleri listele
//10: Dictionary<string, List<string>> ile ders-öğrenci eşlemesi
