namespace Day03._1_DelegatesPractice.Services
{
    public class BildirimServisi
    {
        public static void SmsGonder(string mesaj)
        {
            Console.WriteLine($"SMS: " + mesaj);
        }

        public static void EmailGonder(string mesaj)
        {
            Console.WriteLine($"Email: " + mesaj);
        }

        public static void LogYaz(string mesaj)
        {
            Console.WriteLine($"Log: " + mesaj);
        }
    }
}
