//// GÖREVLER (Day03 projesinde yapabilirsin):

//1: "BildirimDelege" adında bir delege tanımla. 
//   - İmza: string(mesaj) alacak, void (bir şey dönmeyecek).


//2: "BildirimServisi" adında bir class oluştur. İçinde şu metodlar olsun:
//   -"SmsGonder(string mesaj)"->Ekrana "SMS: " + mesaj yazsın.
//   - "EmailGonder(string mesaj)"->Ekrana "Email: " + mesaj yazsın.
//   - "LogYaz(string mesaj)"->Ekrana "LOG: " + mesaj yazsın.
//   (Bunları ister static yap, ister normal; farkı gör!)

//3: Program.cs içinde:
//   -BildirimDelege tipinde bir elçi oluştur.
//   - Bu elçiye "+" (artı) operatörü ile üç metodu da bağla! 
//     (Örn: elci = SmsGonder; elci += EmailGonder; elci += LogYaz;)

//4: Sadece TEK BİR KEZ elçiyi çağır: elci("Sipariş No 101 Hazır!");
//-Bak bakalım üçü birden ekrana yazılacak mı?
using Day03._1_DelegatesPractice.Services;

BildirimDelege elci;

elci = BildirimServisi.SmsGonder;  elci += BildirimServisi.EmailGonder; elci += BildirimServisi.LogYaz;

elci("Sipariş No 101 Hazır!");


public delegate void BildirimDelege(string mesaj);