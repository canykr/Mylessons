namespace _03_ClassLibrary1
{
    public class Kare
    {
        public double KenarUzunlugu { get; set; }
        public Kare(double kenarUzunlugu)
        {
            KenarUzunlugu = kenarUzunlugu;
        }

        public double AlanHesapla()
        {
            return KenarUzunlugu * KenarUzunlugu;
        }












    }
}
