namespace _17_MathMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enBuyuk = Math.Max(5, 10);
            int enBuyuk2 = Math.Max(18, Math.Max(5, 10));
            Console.WriteLine("Büyük Sayi = " + enBuyuk);
            Console.WriteLine("Büyük Sayı = " + enBuyuk2);

            // Math.Min() En küçük değeri bulmak için kullanılır
            int enKucuk = Math.Min(5, 10);
            int enKucuk2 = Math.Min(18, Math.Min(5, 10));
            Console.WriteLine("Küçük Sayı = " + enKucuk);
            Console.WriteLine("Küçük Sayı = " + enKucuk2);

            // Math.Sqrt(x) parametre olarak verilen x sayısının karekökünü hesaplayarak geriye döner
            double kareKok = Math.Sqrt(64);
            Console.WriteLine("64'ün kare kökü = " + kareKok);

            //Math.Abs(x) parametre olarak verilen x degerinin mutlak ( pozitif ) karsılıgını geriye döndürüyor
            int mutlakDeger = Math.Abs(-14);
            double mutlakDeger2 = Math.Abs(-14.5);
            Console.WriteLine("-14'ün mutlak degeri =" +mutlakDeger);
            Console.WriteLine("-14.5'in mutlak degeri =" +mutlakDeger2);

            //Math.Round(x) kendisine en yakın TAM SAYIYA yuvarlar
            double yuvarla1 = Math.Round(7.99);
            double yuvarla2 = Math.Round(7.19);

            double yuvarla3 = Math.Round(4.1245,2); // Virgulden sonra 2 digit kadar alır
            double yuvarla4 = Math.Round(4.1245, 1); 
            double yuvarla5 = Math.Round(4.1245, 0); // tamsayıya yuvarlar

            //Math.Floor(x) parametre olarak verilen sayıyı bir alt TAM SAYIYA yuvarlar. Yani virgülü atıyor diyebiliriz normalde 8'e yuvarlaması gerekirken alt sayı 7 ye yuvarlar
            double asagiYuvarla = Math.Floor(7.99);

            //Math.Ceiling(x) parametre olarak verilen sayıyı bir üst TAM SAYIYA yuvarlar. Yani virgülü atıyor diyebiliriz normalde 'e yuvarlaması gerekirken alt sayı 8 ye yuvarlar
            double yukariYuvarla = Math.Ceiling(7.12);

            //Pi sayisi
            double piSayisi = Math.PI;
            Console.WriteLine("Pi Sayısı = " + piSayisi);


        }
    }
}
