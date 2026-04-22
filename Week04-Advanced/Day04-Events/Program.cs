// Event'leri taşıyacak delege. Genelde (object sender, EventArgs e) standartı kullanılır ama biz şimdilik basit tutalım:
using Day04_Events.Publisher;
Depo depo = new Depo(50);


//2.Adım: Yayıncı Sınıfı(Publisher) Depo sınıfını oluştur.

//İçinde int _stokMiktari olsun.
//KRİTİK NOKTA: public event StokAzaldiHandler StokAzaldi; şeklinde event tanımla.
//StokDusur(int adet) metodu yaz:
//Stok miktarını düşürsün.
//Eğer stok 20'nin altına düşerse, StokAzaldi event'ini tetiklesin (Ateşlesin!).
//3. Adım: Abone Olma(Program.cs)

//Depo nesnesi üret.
//Olay gerçekleşince ne yapılacağını söyle: depo.StokAzaldi += AlarmVer; depo.StokAzaldi += SatinAlmaBildir;
//4.Adım: Metotları Yaz(Handler)

//AlarmVer metodu: "DIIIT! Stok tehlikeli seviyede: {miktar}" desin.
//SatinAlmaBildir metody: "Satın alma birimine e-posta gönderildi." desin.




// ABONE OLMA İŞLEMİ (SUBSCRIPTION)
// 'depo' nesnesinin içindeki 'StokAzaldi' olayına 'AlarmVer' isimli metodumuzu kaydediyoruz ( += ).
// Artık sistem "Stok azaldı!" diye bağırdığında, AlarmVer metodu bunu duyup otomatik çalışacak.
depo.StokAzaldi += AlarmVer;

// ABONE OLMA İŞLEMİ 2
// Aynı olaya bir de 'SatinAlmaBildir' isimli metodu kaydediyoruz.
// C#'ta bir olaya dilediğiniz kadar farklı metodu aynı anda abone yapabilirsiniz (Buna Multicast Delegate denir).
depo.StokAzaldi += SatinAlmaBildir;

// Ekranda işlemlerin daha net ayrışması için görsel bir çizgi çekiyoruz.
Console.WriteLine("-------------------------------------------------");

// SİSTEMİ TEST ETME ZAMANI
// Stok düşürme metodunu çağırıyoruz. 50 - 10 = 40. 
// 40, 20'den küçük olmadığı için event (olay) TETİKLENMEYECEK. Sadece ekrana yazı yazacak.
depo.StokDusur(10);

// Bir daha stok düşürüyoruz. 40 - 15 = 25. 
// 25, 20'den küçük olmadığı için event yine TETİKLENMEYECEK.
depo.StokDusur(15);

// SON HAMLE
// Bir daha stok düşürüyoruz. 25 - 10 = 15.
// 15, 20'den KÜÇÜKTÜR! Şart sağlandığı için Depo sınıfı 'StokAzaldi' olayını ateşleyecek.
// Olay ateşlenince ona abone olan AlarmVer ve SatinAlmaBildir metotları sırasıyla otomatik olarak çalışacak!
depo.StokDusur(10);

// Konsol penceresinin işlemler bittikten sonra hemen kapanmasını engellemek için, 
// kullanıcıdan klavyeden bir Enter tuşuna basmasını bekliyoruz.
Console.ReadLine();
        
        // =======================================================================
        // EVENT TETİKLENDİĞİNDE ÇALIŞACAK OLAN METOTLAR (EVENT HANDLERS)
        // =======================================================================

        // Bu metot, en baştaki şablona (delegate) tam uyar: void döndürür, int parametre alır.
        // Olay gerçekleştiğinde bu kod bloğu çalışır ve ekrana uyarı basar.
        static void AlarmVer(int miktar)
{
    // \n karakteri konsolda bir alt satıra geçmek için kullanılır.
    Console.WriteLine($"\n[UYARI] DIIIT! Stok tehlikeli seviyede: {miktar}");
}

// Bu metot da en baştaki şablona (delegate) uyar.
// Olay gerçekleştiğinde, AlarmVer'den hemen sonra sırası geldiğinde bu da çalışır.
static void SatinAlmaBildir(int miktar)
{
    Console.WriteLine("[BİLGİ] Satın alma birimine e-posta gönderildi.");
}

public delegate void StokAzaldiHandler(int mevcutMiktar);