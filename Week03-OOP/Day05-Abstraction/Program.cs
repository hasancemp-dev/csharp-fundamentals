using Day05_Abstraction.Abstract.Calisan;
using Day05_Abstraction.Abstract.Yonetici;
using Day05_Abstraction.Interface;
using Day05_Abstraction.Interface.Database;
using Day05_Abstraction.Interface.File;
//1:  "ILoggable" adında bir interface yarat.
//    -İçinde sadece şu imza olsun: `void LogKayitEt(string mesaj);`

//2:  "VeritabaniLogger" ve "DosyaLogger" adında iki class yarat. 
//    İkisi de "ILoggable" interface'ini implemente (miras) etsin (zorunlu olarak LogKayitEt yazacaksın).
//    - VeritabaniLogger çıktısı: "Veritabanına kaydedildi: [mesaj]"
//    - DosyaLogger çıktısı: "TXT dosyasına yazıldı: [mesaj]"

//3:  "Kullanici"(Abstract Class) yarat.
//    - Özellik: string Ad, string Rol (Rol sadece okunabilir - private set veya direk getter ver).
//    - Constructor: Kullanici(string ad, string rol) zorunlu olsun.
//    -Normal Metod: void GirisYap() -> "Kullanıcı [Ad] giriş yaptı." yazsın.
//    - Abstract Metod: `public abstract void IslemYap();` (Kural: Her çocuk kendi işlemini belirlesin!)

//4:  "SistemYoneticisi" ve "Depocu" class'ları yarat, "Kullanici" sınıfından miras alsınlar.
//    - IslemYap()'ı override etsinler. 
//    - Depocu çıktısı: "Depocu stok sayımı yapıyor."
//    - Yönetici çıktısı: "Yönetici yeni roller tanımlıyor."

//5:  FINAL(Program.cs):
//    -SistemYoneticisi ve Depocu nesneleri yarat.
//    - ILoggable turunde bir logger seç (ister veritabanı ister dosya).
//    - Kullanıcıları Giriş Yaptır, İşlem Yaptır ve sonunda Logger ile logla!


string? mesaj = "";
SistemYoneticisi yonetici = new SistemYoneticisi("Hasan");
Depocu depocu = new Depocu("Emre");
ILoggable vtlogger = new VeritabaniLogger();
ILoggable dosyalogger = new DosyaLogger();

yonetici.GirisYap();
depocu.GirisYap();

yonetici.IslemYap();
depocu.IslemYap();

mesaj = "sistem yöneticisi giriş yaptı";
vtlogger.LogKayitEt(mesaj);
mesaj = "depocu giriş yaptı";
vtlogger.LogKayitEt(mesaj);
mesaj = "yönetici yeni bilgi girişleri yaptı";
vtlogger.LogKayitEt(mesaj);
mesaj = "depocu yeni ürün girişleri yaptı";
vtlogger.LogKayitEt(mesaj);

mesaj = $"Bilgi ve işlemler dosyaya kaydedildi - {DateTime.Now.ToShortDateString}";
dosyalogger.LogKayitEt(mesaj);

