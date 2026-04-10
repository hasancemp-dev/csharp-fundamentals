//📱 KİŞİ REHBERİ

//ENUM:
//enum Kategori { Aile, Arkadas, Is, Diger } ✅

//HER KİŞİDE:
//-Ad Soyad(string)
//- Telefon(string)
//- Email(string ?) → nullable, opsiyonel
//- Kategori (Kategori enum)

//MENÜ:
//═══════════════════════════
//     📱 KİŞİ REHBERİ
//═══════════════════════════
//1) Kişi Ekle
//2) Tüm Kişileri Listele
//3) İsme Göre Ara
//4) Kategoriye Göre Filtrele
//5) Kişi Sil
//6) Kaydet (dosyaya)
//7) Çıkış
//Seçiminiz: _

//DETAYLAR:
//-Kişiler Dictionary<string, (string Telefon, string? Email, Kategori Kat)> ile tutulsun
//- "Kaydet" seçeneği → kişileri "rehber.txt"ye yazsın
//- Program açılışında "rehber.txt" varsa otomatik yüklesin
//- Try-catch ile tüm girdileri doğrula
//- Arama: Contains ile kısmi eşleşme (ör: "Has" yazınca "Hasan" bulsun)


//// Dictionary yapısı
//Dictionary<string, (string Telefon, string? Email, Kategori Kat)> rehber = new();

//// Ekleme
//rehber["Hasan Çelik"] = ("05551234567", "hasan@mail.com", Kategori.Arkadas);

//// Dosyaya kaydetme formatı (her satır bir kişi)
//// Hasan Çelik|05551234567|hasan@mail.com|Arkadas

//// Dosyadan okurken Split('|') ile ayır


using System;
using System.Collections.Generic;
using System.IO;



Dictionary<string, (string Telefon, string? Email, Kategori Kat)> rehber = new();
const string DOSYA_ADI = "rehber.txt";

DosyadanYukle();

while (true)
{
    Console.WriteLine("\n═══════════════════════════");
    Console.WriteLine("     📱 KİŞİ REHBERİ");
    Console.WriteLine("═══════════════════════════");
    Console.WriteLine("1) Kişi Ekle");
    Console.WriteLine("2) Tüm Kişileri Listele");
    Console.WriteLine("3) İsme Göre Ara");
    Console.WriteLine("4) Kategoriye Göre Filtrele");
    Console.WriteLine("5) Kişi Sil");
    Console.WriteLine("6) Kaydet (dosyaya)");
    Console.WriteLine("7) Çıkış");
    Console.Write("Seçiminiz: ");

    string? secim = Console.ReadLine();

    switch (secim)
    {
        case "1": KisiEkle(); break;
        case "2": TumKisileriListele(); break;
        case "3": IsmdeGoreAra(); break;
        case "4": KategoriyeGoreFiltrele(); break;
        case "5": KisiSil(); break;
        case "6": DosyayaKaydet(); break;
        case "7":
            Console.WriteLine("Çıkılıyor...");
            return;
        default:
            Console.WriteLine("Geçersiz seçim. Lütfen 1-7 arası bir değer girin.");
            break;
    }
}


// ─── 1) KİŞİ EKLE ───────────────────────────────────────────────────────
void KisiEkle()
{
    try
    {
        Console.Write("Ad Soyad: ");
        string? adSoyad = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(adSoyad))
            throw new Exception("Ad Soyad boş olamaz.");

        if (rehber.ContainsKey(adSoyad))
            throw new Exception($"'{adSoyad}' zaten rehberde kayıtlı.");

        Console.Write("Telefon: ");
        string? telefon = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(telefon))
            throw new Exception("Telefon boş olamaz.");

        Console.Write("Email (boş bırakabilirsiniz): ");
        string? email = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(email)) email = null;

        Kategori kategori = KategoriSec();

        rehber[adSoyad] = (telefon, email, kategori);
        Console.WriteLine($"✅ '{adSoyad}' rehbere eklendi.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Hata: {ex.Message}");
    }
}

// ─── 2) TÜM KİŞİLERİ LİSTELE ───────────────────────────────────────────
void TumKisileriListele()
{
    if (rehber.Count == 0)
    {
        Console.WriteLine("Rehber boş.");
        return;
    }

    Console.WriteLine("\n--- Tüm Kişiler ---");
    foreach (var kisi in rehber)
        KisiYazdir(kisi.Key, kisi.Value);
}

// ─── 3) İSME GÖRE ARA ───────────────────────────────────────────────────
void IsmdeGoreAra()
{
    try
    {
        Console.Write("Aranacak isim: ");
        string? aranan = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(aranan))
            throw new Exception("Arama terimi boş olamaz.");

        bool bulundu = false;
        Console.WriteLine($"\n--- '{aranan}' için Sonuçlar ---");

        foreach (var kisi in rehber)
        {
            if (kisi.Key.Contains(aranan, StringComparison.OrdinalIgnoreCase))
            {
                KisiYazdir(kisi.Key, kisi.Value);
                bulundu = true;
            }
        }

        if (!bulundu)
            Console.WriteLine("Eşleşen kişi bulunamadı.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Hata: {ex.Message}");
    }
}

// ─── 4) KATEGORİYE GÖRE FİLTRELE ────────────────────────────────────────
void KategoriyeGoreFiltrele()
{
    try
    {
        Kategori secilenKat = KategoriSec();

        bool bulundu = false;
        Console.WriteLine($"\n--- {secilenKat} Kategorisi ---");

        foreach (var kisi in rehber)
        {
            if (kisi.Value.Kat == secilenKat)
            {
                KisiYazdir(kisi.Key, kisi.Value);
                bulundu = true;
            }
        }

        if (!bulundu)
            Console.WriteLine("Bu kategoride kişi bulunamadı.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Hata: {ex.Message}");
    }
}

// ─── 5) KİŞİ SİL ────────────────────────────────────────────────────────
void KisiSil()
{
    try
    {
        Console.Write("Silinecek kişinin adı: ");
        string? adSoyad = Console.ReadLine()?.Trim();
        if (string.IsNullOrEmpty(adSoyad))
            throw new Exception("Ad Soyad boş olamaz.");

        if (!rehber.ContainsKey(adSoyad))
            throw new Exception($"'{adSoyad}' rehberde bulunamadı.");

        rehber.Remove(adSoyad);
        Console.WriteLine($"✅ '{adSoyad}' silindi.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Hata: {ex.Message}");
    }
}

// ─── 6) DOSYAYA KAYDET ──────────────────────────────────────────────────
void DosyayaKaydet()
{
    try
    {
        using StreamWriter yazar = new StreamWriter(DOSYA_ADI, append: false);

        foreach (var kisi in rehber)
        {
            // Format: AdSoyad|Telefon|Email|Kategori
            // Email null ise boş string yazılır
            string satir = $"{kisi.Key}|{kisi.Value.Telefon}|{kisi.Value.Email ?? ""}|{kisi.Value.Kat}";
            yazar.WriteLine(satir);
        }

        Console.WriteLine($"✅ {rehber.Count} kişi '{DOSYA_ADI}' dosyasına kaydedildi.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Dosya yazma hatası: {ex.Message}");
    }
}

// ─── DOSYADAN YÜKLE (program açılışında) ────────────────────────────────
void DosyadanYukle()
{
    if (!File.Exists(DOSYA_ADI)) return;

    try
    {
        string[] satirlar = File.ReadAllLines(DOSYA_ADI);
        int yuklenen = 0;

        foreach (string satir in satirlar)
        {
            string[] parcalar = satir.Split('|');

            // Geçerli format: 4 parça olmalı
            if (parcalar.Length != 4) continue;

            string adSoyad = parcalar[0].Trim();
            string telefon = parcalar[1].Trim();
            string? email = string.IsNullOrEmpty(parcalar[2]) ? null : parcalar[2].Trim();

            // Enum parse — geçersizse atla
            if (!Enum.TryParse(parcalar[3].Trim(), out Kategori kategori)) continue;

            rehber[adSoyad] = (telefon, email, kategori);
            yuklenen++;
        }

        Console.WriteLine($"📂 '{DOSYA_ADI}' dosyasından {yuklenen} kişi yüklendi.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Dosya okuma hatası: {ex.Message}");
    }
}

// ─── YARDIMCI: KATEGORİ SEÇ ─────────────────────────────────────────────
Kategori KategoriSec()
{
    Console.WriteLine("Kategori seçin:");
    Console.WriteLine("  0) Aile");
    Console.WriteLine("  1) Arkadas");
    Console.WriteLine("  2) Is");
    Console.WriteLine("  3) Diger");
    Console.Write("Seçim: ");

    string? girdi = Console.ReadLine();

    return girdi switch
    {
        "0" => Kategori.Aile,
        "1" => Kategori.Arkadas,
        "2" => Kategori.Is,
        "3" => Kategori.Diger,
        _ => throw new Exception("Geçersiz kategori seçimi (0-3 arası girin).")
    };
}

// ─── YARDIMCI: KİŞİ YAZDIR ──────────────────────────────────────────────
void KisiYazdir(string adSoyad, (string Telefon, string? Email, Kategori Kat) bilgi)
{
    Console.WriteLine($"  Ad-Soyad: {adSoyad}");
    Console.WriteLine($"  Telefon  : {bilgi.Telefon}");
    Console.WriteLine($"  Mail     : {bilgi.Email ?? "(email yok)"}");
    Console.WriteLine($"  Kategori : {bilgi.Kat}");
    Console.WriteLine();
}


enum Kategori { Aile, Arkadas, Is, Diger }