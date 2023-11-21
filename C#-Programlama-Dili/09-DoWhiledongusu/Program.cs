namespace _09_DoWhiledongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            do
            {

                // calıstırılması gereken kodlar bu bloga yazılır
                // arttırma işlemi manual yapılır

            } while (true);

            */
            /*

            int i  = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 1);

            i = 1;
            while (i < 1);
            {
                Console.WriteLine(i);
                i++;
            }
            */
            /*

            int sayi = 0;
            do
            {
                Console.WriteLine("Pozitif bir sayı girin...");
                try
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                }
                catch {; } // "noktalı virgül sebebi hata verse bile kodun devam etmesini sağlıyor"
               
            } while (sayi <= 0);
            // dogru bir değer girene kadar programı çalıştırır

            */


            while (true)
            {
                Console.Clear(); // Ekranı temizle
                Console.WriteLine("Hesap Makinesi Uygulaması");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1 - Toplama İşlemi Yap");
                Console.WriteLine("2 - Çıkarma İşlemi Yap");
                Console.WriteLine("3 - Çarpma İşlemi Yap");
                Console.WriteLine("4 - Bölme İşlemi Yap");
                Console.WriteLine("0 - Uygulamayı Kapat");
                Console.Write("\nHangi işlemi yapmak istiyorsunuz? ");

                if (!int.TryParse(Console.ReadLine(), out int secim))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
                    Console.ReadKey();
                    continue;
                }

                if (secim == 0) break; // Eğer seçim 0 ise uygulamayı kapat

                Console.Clear(); // İşlem seçiminden sonra ekranı tekrar temizle

                double sonuc;
                double sayi1, sayi2;

                Console.WriteLine("İlk sayıyı giriniz:");
                sayi1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı giriniz:");
                sayi2 = Convert.ToDouble(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        sonuc = sayi1 + sayi2;
                        break;
                    case 2:
                        sonuc = sayi1 - sayi2;
                        break;
                    case 3:
                        sonuc = sayi1 * sayi2;
                        break;
                    case 4:
                        if (sayi2 == 0)
                        {
                            Console.WriteLine("Bir sayı sıfıra bölünemez!");
                            Console.ReadKey();
                            continue;
                        }
                        sonuc = sayi1 / sayi2;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir işlem seçin.");
                        Console.ReadKey();
                        continue;
                }

                Console.WriteLine("Sonuç: " + sonuc);
                Console.WriteLine("\nHerhangi bir tuşa basarak ana menüye dönün.");
                Console.ReadKey();
            }
        }
    }
}