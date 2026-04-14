//🏭 Hafta 3, Gün 6 — Haftalık Proje: "Melba Tekstil Mini-ERP Sipariş Modülü"
//Bu hafta öğrendiğin Tüm OOP Mimarisi'ni (Encapsulation, Inheritance, Polymorphism, Abstraction, Interface) tek bir projede birleştiriyoruz! Proje tamamen senin nihai hedefin olan Tekstil fabrikası üstüne kurgulandı.

//Görev Listesi:
//Klasörleme yapısı kurabilirsin (Örn: Modeller /, Arayuzler / gibi).

//1.Arayüzler(Interface) ILoggable adında bir interface oluştur. Tıpkı dünkü gibi void LogKayitEt(string mesaj); içersin.DosyaLogger isimli bir class oluştur ve ILoggable implemente ederek bir .txt dosyasına (veya Console'a) log atsın.

//IHesaplanabilir adında bir interface oluştur. double FiyatHesapla(); içersin.

//2.Soyut Sınıf(Abstract Class) Urun isminde abstract bir class oluştur ve IHesaplanabilir arayüzünü implemente etsin.

//Properties:
//string UrunKodu(Boş olamaz)
//double Metraj(0 veya negatif olamaz — Encapsulation!)
//Constructor: Urun(string urunKodu, double metraj)
//Virtual / Abstract Metod: Interface'den gelen FiyatHesapla() metodunu çocuk sınıflara bırak (abstract olarak taşıyabilirsin). (Makine çalışması gibi).
//3.Çocuk Sınıflar(Inheritance & Polymorphism) İki farklı ürün class'ı yaz: PamukluKumas ve PolyesterKumas. Her ikisi de Urun sınıfından miras alsın.

//PamukluKumas: Kendine ait(sadece okunabilir) double BirimFiyat = 150.5; property'si olsun. FiyatHesapla() metodunda Metraj * BirimFiyat değerine %10 pamuklu kalite vergisi ekleyerek sonucu döndürsün.
//PolyesterKumas: Kendine ait double BirimFiyat = 80.2; property'si olsun. FiyatHesapla() metodunu düz şekilde (Metraj * BirimFiyat) hesaplasın.
//4. Servis Sınıfı SiparisIslemleri isminde bir class oluştur. (Bütün ticari işler burada dönecek)

//Properties:
//List<Urun> _siparisEkrani adında private bir listesi olsun(içine Pamuklu veya Polyester alacak).
//ILoggable _logger adında bir değişkeni olsun.
//Constructor: SiparisIslemleri(ILoggable logger) şeklinde başlatılsın. İçerisinde referansı eşitlesin ve listeyi (new List<Urun>()) başlatsın.
//Metodlar:
//UrunEkle(Urun yeniUrun): Listeye ürün eklesin ve logger ile "Siparişe yeni ürün eklendi: UrunKodu" diye loglasın.
//FaturayiKes(): Bütün listeyi(foreach) dönsün.Listedeki tüm ürünlerin polimorfik olarak FiyatHesapla() metodunu çalıştırıp Toplam bir fatura tutarını ekrana bassın. Ve sonucu loglasın!
//5. Program.cs (Büyük Karşılaşma)

//1 Adet DosyaLogger üret.
//1 Adet SiparisIslemleri üret (Logger'ı içine ver).
//Birkaç tane PamukluKumas ve PolyesterKumas nesneleri üretip siparişe (UrunEkle ile) ekle.
//En son FaturayiKes() metodunu çağırarak işlemi tamamla.
//Bu projeyi tamamladığında, endüstri standartlarında tam teşekküllü bir katmanlı (interface -> abstract -> concrete->service) mimari yazmış olacaksın. Melba Tekstil'in en sağlam temeli atılıyor! Başarılar! 🚀


using Day06_WeeklyProject.Interfaces.ToFile;
using Day06_WeeklyProject.Products;
using Day06_WeeklyProject.Trades;


DosyaLogger recorder = new DosyaLogger();
SiparisIslemleri order = new SiparisIslemleri(recorder);

PamukluKumas poplin = new PamukluKumas("POP1000", 2870.43);
PolyesterKumas saten = new PolyesterKumas("SAT0320", 3200.89);
PamukluKumas molino = new PamukluKumas("MOL0100", 1000.89);
PolyesterKumas alpin = new PolyesterKumas("ALP0400", 6700.9);
PolyesterKumas angelica = new PolyesterKumas("ANG0230", 500.89);
PolyesterKumas jesica = new PolyesterKumas("JES7450", 9000.89);

    
    

order.UrunEkle(poplin);
order.UrunEkle(saten);
order.UrunEkle(alpin);
order.UrunEkle(molino);
order.UrunEkle(angelica);
order.UrunEkle(jesica);

order.FaturayiKes();
