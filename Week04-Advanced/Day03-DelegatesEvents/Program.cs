using Day03_DelegatesEvents.Classes;

// 1. Delegemizi tanımlıyoruz (En altta imzasını verdik)
MatematikDelege matDelege;

// 2. Topla metoduna bağlayalım ve çalıştıralım
matDelege = Maths.Topla;
int toplamSonuc = matDelege(10, 5);
Console.WriteLine($"[DELEGE] Topla işlemi sonucu: {toplamSonuc}");

// 3. Carp metoduna bağlayalım ve çalıştıralım
matDelege = Maths.Carp;
int carpSonuc = matDelege(10, 5);
Console.WriteLine($"[DELEGE] Carp işlemi sonucu: {carpSonuc}");

// Delegeler, metotları bir değişkende tutup istediğimiz yere ulaştırmamızı sağlar.
// Yarın sabah bu mantığın 'Events' (Olaylar) kısmına nasıl bağlandığını göreceğiz.

public delegate int MatematikDelege(int sayi1, int sayi2);
