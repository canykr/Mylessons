namespace Trafiklambasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bir renk seçin (Kırmızı, Sarı, Yeşil):");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "kırmızı":
                        Console.WriteLine("Lütfen Bekleyin");
                        return;
                    case "sarı":
                        Console.WriteLine("Hazırlanın");
                        return;
                    case "yeşil":
                        Console.WriteLine("Geçebilirsiniz");
                        return;
                    default:
                        Console.WriteLine("Hatalı seçim yaptınız tekrar deneyin.");
                        break;

                      
                }
            }
        }
    }
}