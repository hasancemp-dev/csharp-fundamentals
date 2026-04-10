//🏆 Hafta 2 — Meydan Okuma Projesi: "Mini Depo Yönetim"
//Bu sefer tek bir "txt" değil, iki farklı "txt" olacak!

//Enum: IslemTipi { Giris, Cikis, Duzeltme, Silme }
//Dictionary: Stok listesi: Dictionary<string, int> stoklar(Örn: "Pamuk Kumaş"-> 150)
//Log Listesi: Her işlem yapıldığında bunu "loglar.txt" dosyasına o anki tarih, saat ve IslemTipi ile birlikte kaydet. (Örn: 10.04.2026 15:00 - Pamuk Kumaş giriş yapıldı. Adet: +50)
//Stokların son halini ise "stok.txt" dosyasından oku ve oraya kaydet. Görev: Kullanıcı menüden "Ürün Girişi", "Ürün Çıkışı", "Stok Listele", "Log Kayıtlarını Gör" seçeneklerini seçebilecek. Olmayan üründen çıkış yapılırsa veya miktar eksiye düşerse Exception fırlatıp kullanıcıyı try-catch ile uyar!