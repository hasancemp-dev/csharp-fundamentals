//1:  "Generic Kutu"(Generic Box):
//    -"Kutu<T>" isminde bir generic sınıf oluştur.
//    - İçinde T tipinde "Icerik" property'si olsun.
//    - Metod: "IcerigiYazdir()"->İçeriğin tipini ve değerini ekrana bassın.
//    - Program.cs'te hem bir sayı (int) hem de bir yazı (string) ile test et.

//2:  "Generic Veri Deposu"(Generic Repository - Mini):
//    -"KayitSistemi<T>" isminde bir class oluştur.
//    -İçinde private bir "List<T> _veriler" olsun.
//    - Metodlar: 
//        -"Ekle(T veri)"->Listeye eklesin.
//        - "Listele()"->Tüm listeyi ekrana yazdırsın.
//    - Test: Hem "string" isim listesi için, hem de dünkü "Personel" nesneleri için kullanmayı dene!

//3:  "Generic Constraints"(Kısıtlamalar) - Üst Seviye!:
//    -Bazen `< T >`'nin her şey olmasını istemeyiz. Mesela "Sadece sınıflar (class) gelsin" diyebiliriz.
//    - "SadeceNesneDeposu<T> where T : class" şeklinde bir sınıf oluştur.
//    - İçine bir int (değer tipi) atmaya çalış, hata verdiğini gör!

using Day01_Generics.Generics.Classes;

Kutu<int> numberBox = new Kutu<int>(123);
numberBox.IcerigiYazdir();
Kutu<string> wordBox = new Kutu<string>("Merhaba Generics!");
wordBox.IcerigiYazdir();