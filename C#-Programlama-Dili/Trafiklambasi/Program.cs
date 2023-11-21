namespace Trafiklambasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bir renk seçin (Kırmızı, Sarı, Yeşil) veya çıkmak için 'çıkış' yazın:");
                string secim = Console.ReadLine().ToLower();

                switch (secim)
                {
                    case "kırmızı":
                        Console.WriteLine("Lütfen Bekleyin");
                        break;
                    case "sarı":
                        Console.WriteLine("Hazırlanın");
                        break;
                    case "yeşil":
                        Console.WriteLine("Geçebilirsiniz");
                        break;
                    case "çıkış":
                        Console.WriteLine("Programdan çıkılıyor...");
                        return; 
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız, tekrar deneyin.");
                        break;
                }
            }
        }
    }
}