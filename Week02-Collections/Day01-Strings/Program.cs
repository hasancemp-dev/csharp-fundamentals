//1:  Kullanıcıdan cümle al, kaç karakter olduğunu söyle

Console.Write("Cümle girin: ");
string inputLength = Console.ReadLine()!;
Console.WriteLine($"Girdiğiniz cümle {inputLength.Length} karakterdir.");

//2:  Kullanıcıdan cümle al, tamamen büyük ve küçük harfle yazdır

Console.Write("Cümle girin: ");
string inputUpNLow = Console.ReadLine()!;
Console.WriteLine($"Bu büyük harfli hali: {inputUpNLow.ToUpper()}\n" +
                  $"Bu da küçük harfli hali: {inputUpNLow.ToLower()}");

//3:  Kullanıcıdan cümle al, baş ve sondaki boşlukları temizleyip yazdır

Console.Write("Cümle girin: ");
string inputTrim = Console.ReadLine()!;
Console.WriteLine($"Bu baş boşluğu alınmış hali: {inputTrim.TrimStart()}\n" +
                  $"Bu sondaki boşluğu alınmış hali: {inputTrim.TrimEnd()}\n" +
                  $"Bu da iki taraflı: {inputTrim.Trim()}");

//4:  Kullanıcıdan cümle al, içinde "C#" geçiyor mu kontrol et

Console.Write("Cümle girin: ");
string inputContains = Console.ReadLine()!;
if (inputContains.Contains("C#")) Console.WriteLine($"Cümlenin içinde 'C#' geçiyor");
else Console.WriteLine($"Cümlenin içinde 'C#' geçmiyor");

//5:  Kullanıcıdan cümle al, bir kelimeyi başka bir kelimeyle değiştir

Console.Write("Cümle girin: ");
string inputReplace = Console.ReadLine()!;
Console.Write("Yazdığınız cümlenin içinden değiştirmek istediğiniz kelimeyi yazın: ");
string degisecekKelime = Console.ReadLine()!;
Console.Write("Yazdığınız cümlenin içine gelmesini istediğiniz kelimeyi yazın: ");
string yerineGelenKelime = Console.ReadLine()!;
Console.WriteLine($"Yeni cümleniz: {inputReplace.Replace(degisecekKelime, yerineGelenKelime)}");


//6:  Kullanıcıdan ad soyad al, baş harfleri yazdır (H.C.P.)

Console.Write("Ad-Soyad girin: ");
string inputInitials = Console.ReadLine()!;

string[] isimler = inputInitials.Split(' ');
string basHarf = "";

foreach (string isim in isimler)
{
    basHarf += char.ToUpper(isim[0]) + ".";
}

Console.WriteLine(basHarf);

//7:  Kullanıcıdan virgülle ayrılmış isimler al, Split ile ayır, her birini yazdır

Console.Write("Birden fazla isim girin ',' ile ayırınız: ");
string inputSplit = Console.ReadLine()!;

string[] adlar = inputSplit.Split(',');
for (int i = 0; i < adlar.Length; i++)
{
    Console.WriteLine(adlar[i]);
}

//8:  Kullanıcıdan email al, @ dan önceki kısmı (kullanıcı adı) yazdır

string emailAdress = Console.ReadLine()!;
emailAdress = emailAdress.Trim();
int atIsareti = emailAdress.IndexOf("@");
string kullaniciAdi = emailAdress.Substring(0, atIsareti);
Console.WriteLine($"Kullanıcı adınız: {kullaniciAdi}");

Console.Write("Cümle girin: ");
string inputReverse = Console.ReadLine()!;
inputReverse = inputReverse.Trim();

string[] kelimeler = inputReverse.Split(" ");
string[] tersineDuzen = new string[kelimeler.Length];
int uzunluk = kelimeler.Length;

for (int i = 0; i < uzunluk; i++)
{
    tersineDuzen[i] = kelimeler[uzunluk - 1 - i];
}

string yeniCumle = string.Join(" ", tersineDuzen);

Console.WriteLine(yeniCumle);

//10: Kullanıcıdan şifre al, güçlü mü kontrol et (min 8 karakter, büyük harf, küçük harf, rakam)
Console.Write("Şifre girin: ");
string sifre = Console.ReadLine()!;

bool yeterliUzunluk = sifre.Length >= 8;
bool buyukHarf = false;
bool kucukHarf = false;
bool rakam = false;

char[] buyukHarfler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
char[] kucukHarfler = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
char[] rakamlar = "0123456789".ToCharArray();
 
foreach (char c in sifre)
{
    if (char.IsUpper(c)) buyukHarf = true;
    if (char.IsLower(c)) kucukHarf = true;
    if (char.IsDigit(c)) rakam = true;
}
 
if (yeterliUzunluk && buyukHarf && kucukHarf && rakam)
    Console.WriteLine("Şifre güçlü.");
else
{
    Console.WriteLine("Şifre zayıf.");
    if (!yeterliUzunluk) Console.WriteLine("- En az 8 karakter olmalı.");
    if (!buyukHarf) Console.WriteLine("- Büyük harf içermeli.");
    if (!kucukHarf) Console.WriteLine("- Küçük harf içermeli.");
    if (!rakam) Console.WriteLine("- Rakam içermeli.");
}