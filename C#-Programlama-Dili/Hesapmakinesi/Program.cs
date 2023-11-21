namespace Hesapmakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            {
                while (true)
                {
                    Console.Clear(); 
                    Console.WriteLine("Hesap Makinesi Uygulaması");
                    Console.WriteLine("*************************:");
                    Console.WriteLine("\n");
                    Console.WriteLine("1 - Toplama İşlemi Yap");
                    Console.WriteLine("2 - Çıkarma İşlemi Yap");
                    Console.WriteLine("3 - Çarpma İşlemi Yap");
                    Console.WriteLine("4 - Bölme İşlemi Yap");
                    Console.WriteLine("0 - Uygulamayı Kapat");
                    Console.Write("Hangi işlemi yapmak istiyorsunuz? ");

                    int secim;
                    try
                    {
                        secim = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir işlem numarası girin.");
                        Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
                        Console.ReadKey();
                        continue;
                    }

                    if (secim == 0)
                    {
                        Console.WriteLine("Uygulama kapatılıyor...");
                        break;
                    }

                    double sayi1; 
                    double sayi2;
                    Console.Clear();  

                    try
                    {
                        Console.WriteLine("İlk sayıyı giriniz:");
                        sayi1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("İkinci sayıyı giriniz:");
                        sayi2 = Convert.ToDouble(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Geçersiz sayı. Lütfen geçerli bir sayı girin.");
                        Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
                        Console.ReadKey();
                        continue;
                    }

                    double sonuc;
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
                                Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
                                Console.ReadKey();
                                continue;
                            }
                            sonuc = sayi1 / sayi2;
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçim. Lütfen geçerli bir işlem seçin.");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
                            Console.ReadKey();
                            continue;
                    }

                    Console.WriteLine("Sonuç: " + sonuc);
                    Console.WriteLine("Devam etmek için herhangi bir tuşa basın...");
                    Console.ReadKey();
                }
            }
        }

    }
}
