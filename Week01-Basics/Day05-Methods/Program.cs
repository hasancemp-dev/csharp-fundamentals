//1:  void metod: parametre almadan "Merhaba Dünya" yazdıran metod
void IlkCumle()
{
    Console.WriteLine("Merhaba Dünya");
}

IlkCumle();

//2:  void metod: string parametre alıp "Merhaba {isim}" yazdıran metod
void Selamlama(string isim)
{
    Console.WriteLine($"Merhaba {isim}!");
}
Console.Write("İsminizi girin: ");
string isim = Console.ReadLine()!;
Selamlama(isim);

//3:  int döndüren metod: iki sayıyı toplayıp sonucu döndür
int ToplamaYap(int a, int b)
{
    return a + b;
} 
Console.WriteLine(ToplamaYap(1, 2));

//4:  double döndüren metod: bir dizinin ortalamasını hesapla
double OrtalamaHesapla(int[] dizi)
{
    int toplam = 0;
    double ortalama = 0;
    for(int i = 0; i < dizi.Length; i++)
    {
        toplam += dizi[i];
    }
    ortalama = (double)toplam / dizi.Length;
    return ortalama;
}
int[] dizi = { 1, 2, 3, 4 };
Console.WriteLine(OrtalamaHesapla(dizi));

//5:  bool döndüren metod: sayının çift olup olmadığını kontrol et
bool CiftMi(int a)
{
    return a % 2 == 0;
}

Console.WriteLine(CiftMi(1));

//6:  bool döndüren metod: sayının asal olup olmadığını kontrol et
bool AsalMi(int a)
{
    bool asalMi = true;
    for(int i = 2; i<a; i++)
    {
        if (a % i == 0) { asalMi = false; break; }
    }
    return asalMi ;
}

Console.WriteLine(AsalMi(7));

//7:  string döndüren metod: notu alıp harf notunu döndür (85→A, 75→B...)
string HarfNotuHesapla(int not)
{
    string harfNotu = "";
    if (not >= 85) harfNotu = "A";
    else if (not >= 75) harfNotu = "B";
    else if (not >= 65) harfNotu = "C";
    else if (not >= 45) harfNotu = "D";
    else harfNotu = "F";
    return harfNotu;
}

Console.WriteLine(HarfNotuHesapla(90));

//8:  Overloading: Alan hesapla — kare(1 param), dikdörtgen(2 param), daire(1 param)

Console.WriteLine(Geometri.AlanHesapla(5));
Console.WriteLine(Geometri.AlanHesapla(5,8));
Console.WriteLine(Geometri.DaireAlani(3));

//9:  Varsayılan parametre: KDV hesapla(tutar, kdvOrani = 0.20)

double KDVHesapla(double tutar, double kdvOrani = 0.20)
{
    return tutar + (tutar * kdvOrani);
}

Console.Write("Tutar girin: ");
double tutar = double.Parse(Console.ReadLine()!);
Console.WriteLine($"KDV Dahil tutar: {KDVHesapla(tutar)}");

//10: ref kullanarak: iki sayının yerini değiştir (swap)
void Swap(ref int a,ref int b)
{
    int gecici = a;
    a = b;
    b = gecici;
}

int x = 5, y = 10;
Swap(ref x, ref y);
Console.WriteLine($"Yeni değerler x: {x}, y: {y}");




class Geometri
{
    public static double AlanHesapla(double kenar)
    {
        return kenar * kenar;
    }
    public static double AlanHesapla(double en, double boy)
    {
        return en * boy;
    }
    public static double DaireAlani(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }
}
