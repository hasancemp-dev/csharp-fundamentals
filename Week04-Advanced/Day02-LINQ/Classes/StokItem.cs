namespace Day02_LINQ.Classes
{
    public class StokItem
    {
        private int _id;
        private string _ad;
        private int _miktar;
        private int _fiyat;

        public int Id { get => _id; set => _id = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public int Miktar { get => _miktar; set => _miktar = value; }
        public int Fiyat { get => _fiyat; set => _fiyat = value; }

        public StokItem(int id, string ad, int miktar, int fiyat)
        {
            Id = id;
            Ad = ad ?? throw new ArgumentNullException(nameof(ad));
            Miktar = miktar;
            Fiyat = fiyat;
        }
        public StokItem()
        {
        }
    }
}
