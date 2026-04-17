// Önce bu listeyi Program.cs'e yapıştır:
using Day02_LINQ.Classes; 

var stoklar = new List<StokItem>
{
    new StokItem { Id = 1, Ad = "Pamuk Kumas", Miktar = 500, Fiyat = 150 },
    new StokItem { Id = 2, Ad = "Polyester Kumas", Miktar = 1200, Fiyat = 80 },
    new StokItem { Id = 3, Ad = "Ipek Kumas", Miktar = 50, Fiyat = 450 },
    new StokItem { Id = 4, Ad = "Keten Kumas", Miktar = 300, Fiyat = 200 },
    new StokItem { Id = 5, Ad = "Denim Kumas", Miktar = 800, Fiyat = 120 }
};

// GÖREVLER (Metod Syntax/Lambda kullanarak):

//1: "Miktarı 400'den fazla olan ürünleri bul ve listele."
var miktar400 = stoklar.Where(x => x.Miktar > 400).ToList();

//2: "Ürünleri fiyatına göre PAHALIDAN UCUZA doğru sırala."
var fiyatSirala = stoklar.OrderByDescending(x => x.Fiyat).ToList();

//3: "Ürünlerin sadece ADLARINI içeren yeni bir liste (string listesi) oluştur ve yazdır."  
var sadeceAdlar = stoklar.Select(x => x.Ad).ToList();
sadeceAdlar.ForEach(Console.WriteLine);

//4: "Adı 'Ipek Kumas' olan ürünü bul (First) ve ekrana bas."
var kumasBul = stoklar.FirstOrDefault(x => x.Ad == "Ipek Kumas");
if (kumasBul != null)
    Console.WriteLine($"Bulundu: {kumasBul.Ad}");
else
    Console.WriteLine("Ürün bulunamadı.");


//5: "Depodaki tüm ürünlerin toplam miktarını (Sum) hesapla."
var toplamStok = stoklar.Sum(x => x.Miktar);
Console.WriteLine($"Toplam Miktar: {toplamStok}");

//6: "Fiyatı 100 TL ile 300 TL arasında olan ürünlerin ortalama miktarını bul."
var fiyatAraligi = stoklar.Where(x => x.Fiyat > 100 && x.Fiyat < 300).Average(x => x.Miktar);


