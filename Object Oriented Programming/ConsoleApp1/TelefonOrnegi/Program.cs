using System.Linq.Expressions;
using static TelefonOrnegi.Cihaz;

namespace TelefonOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Cihaz cihaz = new Cihaz("deneme","12345");

            cihaz.Barkod = "123456789";
            Console.WriteLine(cihaz.BarkodYaz());

            Elektronik elektronik = new Elektronik("deneme", "12345");
            elektronik.Barkod = "987654321";
            elektronik.CPU = "Intel i7";
            elektronik.RAM = "16GB";
            Console.WriteLine(elektronik.BarkodYaz());
            Console.WriteLine("CPU: " + elektronik.CPU + ", RAM: " + elektronik.RAM);

            Telefon telefon = new Telefon("deneme", "12345");
            telefon.Barkod = "192837465";
            telefon.CPU = "Snapdragon 888";
            telefon.RAM = "8GB";
            telefon.Renk = "Siyah";
            telefon.Aramayap();
            Console.WriteLine(telefon.BarkodYaz());
            Console.WriteLine("CPU: " + telefon.CPU + ", RAM: " + telefon.RAM + ", Renk: " + telefon.Renk);


            
        }
    }

}
    