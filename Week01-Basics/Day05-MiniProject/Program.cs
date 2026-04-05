//Metodlar:
//1.Topla(double a, double b)
//2.Cikar(double a, double b)
//3.Carp(double a, double b)
//4.Bol(double a, double b) — sıfıra bölme kontrolü
//5. Faktoriyel(int n)
//6. AsalMi(int n)
//7. UsAl(double taban, int us)

bool devamMi = true;
while (devamMi)
{
    Console.Clear();
    Console.Write($"Menü:\n" +
$"═══════════════════════\n" +
  $" MATEMATİK KÜTÜPHANESİ\n" +
$"═══════════════════════\n" +
$"1) Toplama\n" +
$"2) Çıkarma\n" +
$"3) Çarpma\n" +
$"4) Bölme\n" +
$"5) Faktöriyel\n" +
$"6) Asal Sayı Kontrolü\n" +
$"7) Üs Alma\n" +
$"8) Çıkış\n" +
$"Seçiminiz: ");

    int secim = int.Parse(Console.ReadLine()!);
    if (secim == 8) break;
    else
    {
        switch (secim)
        {

            case 1:
                Console.Clear();
                Console.Write($"1. sayıyı girin: ");
                double birinciSayiT = double.Parse(Console.ReadLine()!);
                Console.Write("2. sayıyı girin: ");
                double ikinciSayiT = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Islem sonucu: {Topla(birinciSayiT, ikinciSayiT)}");
                break;
            case 2:
                Console.Clear();
                Console.Write($"1. sayıyı girin: ");
                double birinciSayiCi = double.Parse(Console.ReadLine()!);
                Console.Write("2. sayıyı girin: ");
                double ikinciSayiCi = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Islem sonucu: {Cikar(birinciSayiCi, ikinciSayiCi)}");
                break;
            case 3:
                Console.Clear();
                Console.Write($"1. sayıyı girin: ");
                double birinciSayiCa = double.Parse(Console.ReadLine()!);
                Console.Write("2. sayıyı girin: ");
                double ikinciSayiCa = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Islem sonucu: {Carp(birinciSayiCa, ikinciSayiCa)}");
                break;
            case 4:
                Console.Clear();
                Console.Write($"1. sayıyı girin: ");
                double birinciSayiB = double.Parse(Console.ReadLine()!);
                Console.Write("2. sayıyı girin: ");
                double ikinciSayiB = double.Parse(Console.ReadLine()!);
                Console.WriteLine($"Islem sonucu: {Bol(birinciSayiB, ikinciSayiB)}");
                break;
            case 5:
                Console.Clear();
                Console.Write($"Sayı girin: ");
                int birinciSayiFa = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"{birinciSayiFa}! = {Faktoriyel(birinciSayiFa)}");
                break;
            case 6:
                Console.Clear();
                Console.Write($"Sayı girin: ");
                int birinciSayiAs = int.Parse(Console.ReadLine()!);
                Console.WriteLine(AsalMi(birinciSayiAs) ? $"{birinciSayiAs} asal sayıdır" : $"{birinciSayiAs} asal değildir");

                break;
            case 7:
                Console.Clear();
                Console.Write($"Taban sayısı girin: ");
                double tabanSayisi = double.Parse(Console.ReadLine()!);
                Console.Write($"Us sayısı girin: ");
                int usSayisi = int.Parse(Console.ReadLine()!);
                Console.WriteLine($"{tabanSayisi}'in/nin {usSayisi} kuvveti: {UsAl(tabanSayisi, usSayisi)}");
                break;
        }//switch
    }
    Console.Write($"Başka bir işlem yapmak ister misiniz? E/H: ");
    string icSecim = Console.ReadLine()!;
    if (icSecim == "E") continue;
    else if (icSecim == "H") break;
    else
    {
        Console.Write($"Geçerli bir secim yapin: ");
        string sonSans = Console.ReadLine()!;
        if (sonSans != "E") break;
    }

}//while

//=======================================================================================//

double Topla(double a, double b)
{ 
    return a + b;
}
double Cikar(double a, double b)
{
    return a - b;
}
double Carp (double a, double b)
{
    return a * b;
}
double Bol(double a, double b)
{
    if (b != 0)
    {
        return a / b;
    }
    throw new DivideByZeroException("Bölme işlemi için bölen sıfır olamaz.");
}
int Faktoriyel(int n)
{
    for(int i = n-1; i > 1; i--)
    {
        n *= i;
    }
    return n;
} 
bool AsalMi (int n)
{
    if (n < 2) return false;
    for (int bolen = 2; bolen < n; bolen++)
    {
        if (n % bolen == 0) return false;
        
    }
    return true;
} 
 double UsAl(double taban, int us)
{
    double sonuc = 1;
    for (int i = 0; i < us; i++)
    {
        sonuc *= taban;
    }
    return sonuc;
} 