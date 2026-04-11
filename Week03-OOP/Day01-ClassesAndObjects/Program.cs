using Day01_ClassesAndObjects;

//1:  "Telefon" adında bir class oluştur. (Marka, Model, Fiyat, BataryaKapasitesi özellikleri olsun).
Telefon telefon = new Telefon()
{
    Marka = "Gigaset",
    Model = "Desk 200",
    Fiyat = 1410,
    BataryaKapasitesi = "Prize bağlanır"
};
Telefon ceptel = new Telefon()
{
    Marka = "Samsung",
    Model = "S26 Ultra",
    Fiyat = 98580,
    BataryaKapasitesi = "5000mAh"
};

//2:  "AramaYap(string numara)" adında bir metodu olsun. "X numarası aranıyor..." yazsın.
telefon.AramaYap("02244525458");

//3:  Ana programında(yukarıda) 2 farklı Telefon nesnesi oluştur, farklı değerler verip metodlarını çağır.
ceptel.AramaYap("5375492717");
Console.WriteLine(telefon);

//4:  "Ogrenci" adında bir class oluştur. (Ad, Soyad, Yas, OgrenciNo özellikleri olsun). Bir de "KendiniTanit()" metodu olsun (Adım X, numaram Y gibi).
Ogrenci ogrenci = new Ogrenci()
{
    Ad = "Hasan",
    Soyad = "Pinar",
    Yas = 32,
    OgrenciNo = 192
};

ogrenci.KendiniTanit();
//5:  Şimdi Ogrenci nesnelerinden 3 tane üretip bunları List<Ogrenci> içine ekle. Foreach döngüsü ile hepsinin "KendiniTanit()" metodunu tek tek çağır!
Ogrenci ogrenci2 = new Ogrenci()
{
    Ad = "Mert Ali",
    Soyad = "Pinar",
    Yas = 2,
    OgrenciNo = 193
};
Ogrenci ogrenci3 = new Ogrenci() 
{
    Ad = "Yaprak",
    Soyad = "Pinar",
    Yas = 31,
    OgrenciNo = 191
};

List<Ogrenci> ogrenciler = new List<Ogrenci>();
ogrenciler.Add(ogrenci);
ogrenciler.Add(ogrenci2);
ogrenciler.Add(ogrenci3);

foreach(var gelen in ogrenciler)
{
    gelen.KendiniTanit();
}
