namespace Day01_Generics.Generics.Repositories
{
    internal class KayitSistemi<T>
    {
        private List<T> _veriler;
        public KayitSistemi()
        {
            _veriler = new List<T>();
        }
        public void Ekle(T veri)
        {
            _veriler.Add(veri);
        }
        public void Listele()
        {
            Console.WriteLine($"Kayıt Sistemi ({typeof(T)}):");
            foreach (var veri in _veriler)
            {
                Console.WriteLine(veri);
            }
        }
    }
}
