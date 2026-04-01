/*
Alıştırma 1:  int tipinde yaşını tanımla, ekrana yazdır
Alıştırma 2:  string tipinde adını ve soyadını tanımla, birleştirip yazdır
Alıştırma 3:  double tipinde boyunu (metre cinsinden, ör: 1.75) tanımla, yazdır
Alıştırma 4:  decimal tipinde bir maaş tanımla, "N2" formatında yazdır
Alıştırma 5:  bool tipinde "ogrenciMi" tanımla, yazdır
Alıştırma 6:  char tipinde kan grubunu tanımla (ör: 'A'), yazdır
Alıştırma 7:  long tipinde TC kimlik numarası tanımla, yazdır
Alıştırma 8:  int → double implicit dönüşüm yap, iki değeri de yazdır
Alıştırma 9:  double → int explicit cast yap, veri kaybını göster
Alıştırma 10: string "2026" → int Parse ile dönüştür, 1 ekleyip yazdır
Alıştırma 11: string "abc" → int TryParse ile dönüştür, sonucu yazdır (true/false)
Alıştırma 12: Convert.ToInt32 ile string → int dönüşümü yap
Alıştırma 13: Convert.ToDouble ile string → double dönüşümü yap
Alıştırma 14: int'i ToString() ile string'e çevir, .GetType() ile tipini yazdır
Alıştırma 15: String interpolation ile "Benim adım X, yaşım Y" yazdır
Alıştırma 16: decimal maaşı { maas:C } formatında yazdır (para formatı)
Alıştırma 17: var keyword'ü ile 3 farklı tipte değişken tanımla, GetType() ile tiplerini yazdır
Alıştırma 18: const ile pi sayısını tanımla (3.14159), yazdır
Alıştırma 19: İki int değişken tanımla, topla/çıkar/çarp/böl, her sonucu yazdır
Alıştırma 20: int bölme vs double bölme farkını göster (7/2 vs 7.0/2.0)
*/

/*
//1

int ageAsInt = 31;
Console.WriteLine(ageAsInt);

//2

string name = "Hasan Cem";
string surname = "Pinar";

Console.WriteLine($"Name: {name}, Surname: {surname}, Age: {ageAsInt}");

//3

double height = 1.65;
Console.WriteLine(height);

//4

decimal salary = 52675.48m;
Console.WriteLine($"Salary:{salary:N2} TL");

//5

bool ogrenciMi = false;
Console.WriteLine(ogrenciMi);

//Önemli Uyarı!: Yerel değişken isimlerini mutlaka ama mutlaka camelCase olarak tanımla, PascalCase olarak sadece CLASS, METHOD ve PROPERTY'ler tanımlanır.

//6
//Benim kan grubum AB Lakin char dediğin için A diyeceğim

char bloodType = 'A';
Console.WriteLine(bloodType);

//7

long identityNum = 12345678910L;
Console.WriteLine(identityNum);

//8

double ageAsDouble = ageAsInt;
Console.WriteLine($"int: {ageAsInt}, double: {ageAsDouble}");

//9

double originalValue = 12.13;
int castedValue = (int)originalValue;
Console.WriteLine(castedValue);

//10

string yearStr = "2026";
int yearNum = int.Parse(yearStr);
Console.WriteLine(yearNum + 1);

//11

string alphabet = "abc";
bool isConverted = int.TryParse(alphabet, out int sonuc);

Console.WriteLine(isConverted);
Console.WriteLine(sonuc);

//12

string numberAsString = "51";
int numberAsInt = Convert.ToInt32(numberAsString);
Console.WriteLine(numberAsInt);  


//13

string numberAsStrToDouble = "51.1234";
double numberAsDouble = Convert.ToDouble(numberAsStrToDouble);
Console.WriteLine(numberAsDouble);  


//14

string numberAsStringAgain = numberAsInt.ToString();
Console.WriteLine(numberAsStringAgain);
Console.WriteLine(numberAsStringAgain.GetType());

//15

Console.WriteLine($"Benim adım {name}, yaşım {ageAsInt}");

//16

Console.WriteLine($"Maaşım {salary:C}");

//17

var letter = "harfler";
var number = 123;
var numberWithComma = 123.45;

Console.WriteLine($"letter'ın tipi : {letter.GetType()}, number'ın tipi: {number.GetType()}, numberWithComa'nın tipi: {numberWithComma.GetType()}");

//18

const double piNumber = 3.14159;

Console.WriteLine(piNumber);

//19

int num1 = 10;
int num2 = 2;

Console.WriteLine($"Toplama: num1 + num2 = {num1 + num2} \n" +
                  $"Çıkarma: num1 - num2 = {num1 - num2} \n" +
                  $"Çarpma : num1 * num2 = {num1 * num2} \n" +
                  $"Bölme  : num1 / num2 = {num1 / num2}");

//20

Console.WriteLine($"Difference of division with integer & double \n" +
                  $"With integer = {7/2}\n" +
                  $"With double  = {7.0/2.0}\n" +
                  $"While double shows us half after three but integer not, this is the difference");
*/

Console.Write("Adınızı girin: ");
string ad = Console.ReadLine();

Console.Write("Yaşınızı girin: ");
int yas = int.Parse(Console.ReadLine());

Console.Write("Maaşınızı girin: ");
decimal? maas = decimal.Parse(Console.ReadLine());

Console.WriteLine($"╔═══════════════════════╗\n" +
                  $"║   KİŞİSEL BİLGİ KARTI ║\n" +
                  $"╠═══════════════════════╣\n" +
                  $"║ Ad    : {ad, -14}║\n" +
                  $"║ Yaş   : {yas, -14}║\n" +
                  $"║ Maaş  : {maas:N2} TL  ║\n" +
                  $"╚═══════════════════════╝");








