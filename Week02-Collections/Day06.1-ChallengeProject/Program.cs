//🏆 Hafta 2 — Meydan Okuma Projesi: "Mini Depo Yönetim"
//Bu sefer tek bir "txt" değil, iki farklı "txt" olacak!

//Enum: IslemTipi { Giris, Cikis, Duzeltme, Silme }
//Dictionary: Stok listesi: Dictionary<string, int> stoklar(Örn: "Pamuk Kumaş"-> 150)
//Log Listesi: Her işlem yapıldığında bunu "loglar.txt" dosyasına o anki tarih, saat ve IslemTipi ile birlikte kaydet. (Örn: 10.04.2026 15:00 - Pamuk Kumaş giriş yapıldı. Adet: +50)
//Stokların son halini ise "stok.txt" dosyasından oku ve oraya kaydet. Görev: Kullanıcı menüden "Ürün Girişi", "Ürün Çıkışı", "Stok Listele", "Log Kayıtlarını Gör" seçeneklerini seçebilecek. Olmayan üründen çıkış yapılırsa veya miktar eksiye düşerse Exception fırlatıp kullanıcıyı try-catch ile uyar!


using Day06._1_ChallengeProject;

DepoYonetimi depo = new DepoYonetimi();

while (true)
{
    Console.WriteLine("\n=== MİNİ DEPO YÖNETİMİ ===");
    Console.WriteLine("1. Ürün Girişi");
    Console.WriteLine("2. Ürün Çıkışı");
    Console.WriteLine("3. Stok Listele");
    Console.WriteLine("4. Log Kayıtlarını Gör");
    Console.WriteLine("5. Çıkış");
    Console.Write("Seçiminiz: ");

    string secim = Console.ReadLine();

    try
    {
        if (secim == "1" || secim == "2")
        {
            Console.Write("Ürün Adı: ");
            string urunAd = Console.ReadLine();

            Console.Write("Miktar: ");
            if (!int.TryParse(Console.ReadLine(), out int miktar))
                throw new FormatException("Lütfen geçerli bir sayı giriniz.");

            if (secim == "1")
            {
                depo.UrunGirisi(urunAd, miktar);
                Console.WriteLine("✅ Ürün girişi başarıyla kaydedildi.");
            }
            else
            {
                depo.UrunCikisi(urunAd, miktar);
                Console.WriteLine("✅ Ürün çıkışı başarıyla kaydedildi.");
            }
        }
        else if (secim == "3") depo.StoklariListele();
        else if (secim == "4") depo.LoglariGoster();
        else if (secim == "5") break;
        else Console.WriteLine("Geçersiz seçim!");
    }
    catch (Exception ex)
    {
        // DepoYonetimi sınıfından fırlatılan InvalidOperationException, KeyNotFoundException vb. 
        // tüm hatalar burada yakalanır ve program çökmeden kullanıcıya gösterilir.
        Console.WriteLine($"\n İŞLEM BAŞARISIZ: {ex.Message}");
    }
}

public enum IslemTipi
{
    Giris,
    Cikis,
    Duzeltme, // İleride eklenebilecek özellikler için
    Silme
}