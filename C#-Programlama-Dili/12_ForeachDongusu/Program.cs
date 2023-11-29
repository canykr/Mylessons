namespace _12_ForeachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] takimlar = { "Beşiktaş", "Fenerbahçe", "Galatasaray", "Trabzonspor" };
            /*
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(takimlar[i]);
            }
           
            foreach (var item in takimlar) 
            { 
                Console.WriteLine(item);
            }


            // ÖRNEK
            // Meyveler dizimiz olsun, eleman sayısını kullanıcı belirlesin. Saıyı belirledikten sonra her bir elemanın değerlerini tek tek doldursun. Son olarak elemanın tüm değerlerini ekrana alt alta yazdıran kod bloğu.

            Console.Write("Kaç adet meyve gireceksiniz? ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());

            string[] meyveler = new string[elemanSayisi];

            for (int i = 0; i < meyveler.Length; i++)
            {
                Console.Write($"{i+1}. meyvenin adını giriniz: ");
                meyveler[i] = Console.ReadLine();
            }

            Console.Clear();
            Console.WriteLine("Girdiğiniz Meyveler:");

            int index = 1;
            foreach (var meyve in meyveler)
            {
                Console.WriteLine($"{index}. Meyve = {meyve}");
                index++;
            }
            */

            // Kullanıcıdan sayılar girmesini isteyelim. Dizimizin eleman sayısı 3 olsun. Doğru Değer girip girmediğini kontrol edelim. girilen sayıların toplamını ekrana yazdıralım. Girilen sayılarıda kontrol edelim.

            Console.Write("Kaç sayı gireceksiniz? ");
            int eleman = 0;
            while (int.TryParse(Console.ReadLine(), out eleman) !=true)
            //while (int.TryParse(Console.ReadLine(),out eleman) ==false)
            //while (!int.TryParse(Console.ReadLine(),out eleman))
            {
                Console.Write("Geçersiz giriş, lütfen pozitif bir tam sayı giriniz: ");
            }

            int[] sayilar = new int[eleman];
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write($"{i + 1}. sayıyı giriniz: ");
                while (!int.TryParse(Console.ReadLine(), out sayilar[i]))
                {
                    Console.Clear();
                    Console.WriteLine("Geçersiz giriş, lütfen bir sayı giriniz:");
                }
            }

            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }

            Console.WriteLine("\nGirilen Sayılar:");
            foreach (int sayi in sayilar)

            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine($"Sayıların Toplamı: {toplam}");
        }
    }
}
