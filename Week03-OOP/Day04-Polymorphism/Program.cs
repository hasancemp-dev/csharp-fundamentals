using Day04_Polymorphism.UretimMakineleri;

//1:  "Makine"(Ata) sınıfı yaz.
//    -Özellikler: MakineKodu, UretilenMiktar.
//    - Virtual Metod: "UretimYap(int miktar)".Çıktı: "Makine X üretim yaptı. Tüketilen enerji 10 kW"
//    - İpucu: Üretim yapılınca UretilenMiktar artsın.

//2:  "DokumaMakinesi"(Çocuk) sınıfı yaz:
//    -Makine'den miras alsın.
//    - UretimYap() metodunu override etsin.Çıktı: "Dokuma Makinesi X, Y metre kumaş dokudu. Tüketilen enerji 50 kW"
//    - Kendine has özellik: CalismaHizi.


//3:  "IplikEgirmeMakinesi"(Çocuk) sınıfı yaz:
//    -Makine'den miras alsın.
//    - UretimYap() metodunu override etsin.Çıktı: "İplik Makinesi X, Y bobin ip eğirdi. Tüketilen enerji 20 kW"

//4:  "HesaplaMaliyet(int uretimMiktari)" adında normal(virtual olmayan) korunaklı bir metod yaz ataya.
//    - Çıktı şöyle bir mesaj versin "Ortalama birim maliyeti: X TL" (Miktarı rastgele bir fiyatla çarp).
//    - Çocuk sınıflar Üretim yaparken bu metodu da (babasından) çağırsın!

//5:  FINAL TESTİ(Program.cs):
//    -List < Makine > tipinde bir fabrika listesi yap.
//    - 1 adet normal Makine, 1 adet DokumaMakinesi, 1 adet IplikEgirmeMakinesi üret ve listeye ekle.
//    - `foreach (Makine m in fabrika)` ile tüm makineleri dönüp hepsine `UretimYap(100)` emri gönder.
//    - Polimorfizmin (her makinenin farklı ürettiğini) konsol ekranında gör!

List<Makine> fabrika = new List<Makine>();
Makine makine01 = new Makine()
{
    MakineKodu = 1,
    UretilenMiktar = 50
};
fabrika.Add(makine01);

DokumaMakinesi dokuma01 = new DokumaMakinesi()
{
    MakineKodu = 2,
    UretilenMiktar = 200,
    CalismaHizi = 1000
};
fabrika.Add(dokuma01);

IplikEgirmeMakinesi ipeg03 = new IplikEgirmeMakinesi()
{
    MakineKodu = 3,
    UretilenMiktar = 2000
};
fabrika.Add(ipeg03);

foreach(var makine in fabrika)
{
    Console.WriteLine(makine.UretimYap(100));
    Console.WriteLine(makine);
}