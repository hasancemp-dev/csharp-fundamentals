//1:  Boş bir List<string> oluştur, 5 şehir ekle, yazdır
using System.Collections.Immutable;
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
for (int i = 0; i < ogrenciSayisi; i++)
{
    Console.Write($"İsim girin: ");
    isim = Console.ReadLine()!;
    Console.WriteLine("");
    Console.Write("Not girin: ");
    not = int.Parse(Console.ReadLine()!);
    ogrenciNot.Add(isim, not);
}
Console.WriteLine($"Öğrenci ve notlar:");
foreach (var gelen in ogrenciNot)
{
    Console.WriteLine($"{gelen.Key} - {gelen.Value}");
}

//7:  Dictionary ile telefon rehberi: isim - numara ekle, isimle arama yap

Dictionary<string, long> telefonRehberi = new Dictionary<string, long>();
Console.WriteLine($"Kac kisi gireceksiniz?");
int kisiSayisi = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Isim ve telefon giriniz:");
long telefon;
for (int i = 0; i < kisiSayisi; i++)
{
    Console.Write($"İsim girin: ");
    isim = Console.ReadLine()!;
    Console.WriteLine("");
    Console.Write("Telefon girin: ");
    telefon = long.Parse(Console.ReadLine()!);
    telefonRehberi.Add(isim, telefon);
}
Console.Write($"Kimin telefon numarasını öğrenmek istersiniz?: ");
string arananKisi = Console.ReadLine()!;
bool bulunduMu = false;
foreach (var gelen in telefonRehberi)
{
    if (gelen.Key == arananKisi) { bulunduMu = true; Console.WriteLine($"{arananKisi}'in/nin telefon no'su: {gelen.Value}"); break; }
    else bulunduMu = false;
}
if (!bulunduMu) Console.WriteLine("Aradığınız kişinin telefonu bulunamadı");

//8:  Dictionary ile kelime sayacı: cümledeki her kelimenin kaç kez geçtiğini say
Dictionary<string, int> kelimeSayaci = new Dictionary<string, int>();
Console.Write($"Bir cümle girin: ");
string girilenCumle = Console.ReadLine()!;

string[] kelimeler = girilenCumle.Split(' ');

foreach (string kelime in kelimeler)
{
    if (kelimeSayaci.ContainsKey(kelime))
        kelimeSayaci[kelime]++;
    else
        kelimeSayaci[kelime] = 1;
}

foreach (var kv in kelimeSayaci)
    Console.WriteLine($"{kv.Key}: {kv.Value}");

//9:  List<string> içinde arama: kullanıcıdan kelime al, eşleşenleri listele
List<string> inputWords = new List<string>();
Console.WriteLine($"Kaç kelime girmek istersin:");
int kacKez = int.Parse(Console.ReadLine()!);
Console.Write("Kelimelerini girebilirsin: ");
for (int i = 0; i < kacKez; i++)
{
    string kelime = Console.ReadLine()!;
    inputWords.Add(kelime);
}
Console.Write("Aramak istediğin kelimeyi (veya harfi) gir: ");
string arananKelime = Console.ReadLine()!;

Console.WriteLine("Eşleşen kelimeler:");
foreach (string gelen in inputWords)
{
    if (gelen.Contains(arananKelime))
    {
        Console.WriteLine(gelen);
    }
}

//10: Dictionary<string, List<string>> ile ders-öğrenci eşlemesi 
Dictionary<string, List<string>> dersOgrencileri = new Dictionary<string, List<string>>();

dersOgrencileri["Matematik"] = new List<string> { "Ali", "Ayşe", "Veli" };

dersOgrencileri["Fizik"] = new List<string> { "Mehmet", "Zeynep" };

foreach (var ders in dersOgrencileri)
{
    Console.WriteLine($"\n--- {ders.Key} Dersi Öğrencileri ---");
    foreach (string ogrenci in ders.Value)
    {
        Console.WriteLine($"- {ogrenci}");
    }
}
