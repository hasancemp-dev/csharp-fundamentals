//1:  "Calisan"(Ata), "Yazilimci" ve "Muhasebeci" (Çocuklar) sınıflarını tasarla.
//    - Calisan'da Ad, Soyad, Maas özellikleri olsun.
//    - Yazilimci'da ekstra "BildiğiDiller" özelliği olsun.
//    - Muhasebeci'de ekstra "MuhasebeYazilimi" özelliği olsun.

//2:  Constructors ile Veri Gönderimi:
//    "Calisan" sınıfının yapıcı metodu (constructor) "Ad" ve "Soyad" zorunlu istesin.
//    "Yazilimci" sınıfının constructor'ında da bu bilgileri alıp "base(ad, soyad)" ile ataya gönder.

//3:  Metod Ezme(Virtual/Override):
//    -"Calisan" sınıfında "MesaiYap()" adında bir virtual metod olsun. Çıktı: "Çalışan mesaiye kaldı."
//    - "Yazilimci" bunu override etsin.Çıktı: "Yazılımcı kod yazarak mesaiye kaldı."
//    - "Muhasebeci" bunu override etsin.Çıktı: "Muhasebeci fatura keserek mesaiye kaldı."

//4:  "Hesap"(Ata) sınıfı oluştur. "VadesizHesap" ve "VadeliHesap" bunu miras alsın.
//    - Hesap'ta "HesapSahibi" ve "Bakiye" özellikleri olsun.
//    - "ParaCek" metodu 'virtual' olsun (sadece bakiyeden normal düşsün).
//    - "VadeliHesap" (Çocuk), ParaCek metodunu 'override' etsin ve eğer para çekilirse ekstra %20 ceza kesintisi yapsın.
