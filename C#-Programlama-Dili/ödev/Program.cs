namespace ödev
{
    internal class Program
    {
     using System;

class HesapMakinesi
    {
        static void Main()
        {
            bool uygulamaCalisiyor = true;
            while (uygulamaCalisiyor)
            {
               
                Console.WriteLine("Hesap Makinesi Uygulaması");
                Console.WriteLine("Menü:");
                Console.WriteLine("1 - Toplama İşlemi Yap");
                Console.WriteLine("2 - Çıkarma İşlemi Yap");
                Console.WriteLine("3 - Çarpma İşlemi Yap");
                Console.WriteLine("4 - Bölme İşlemi Yap");
                Console.WriteLine("0 - Uygulamayı Kapat");
                Console.Write("Hangi işlemi yapmak istiyorsunuz? ");

                int secim;
                if (int.TryParse(Console.ReadLine(), out secim))
                {
                    switch (secim)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            IslemYap(secim);
                            break;
                        case 0:
                            uygulamaCalisiyor = false;
                            Console.WriteLine("Uygulama kapatılıyor...");
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir işlem seçin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen bir sayı giriniz.");
                }

                
                if (uygulamaCalisiyor)
                {
                    Console.WriteLine("Ana menüye dönmek için herhangi bir tuşa basın...");
                    Console.ReadKey();
                }
            }
        }

        static void IslemYap(int secim)
        {
            Console.WriteLine("İlk sayıyı giriniz:");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            double sonuc = 0;
            bool gecerliIslem = true;

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
                    if (sayi2 != 0)
                    {
                        sonuc = sayi1 / sayi2;
                    }
                    else
                    {
                        Console.WriteLine("Bir sayı sıfıra bölünemez!");
                        gecerliIslem = false;
                    }
                    break;
            }

            if (gecerliIslem)
            {
                Console.WriteLine("Sonuç: " + sonuc);
            }
        }
    }

}
}