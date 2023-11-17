namespace _05_SwitchCaseKullanımı
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*
            int sayi1 = 5;

            switch(sayi1)
            {
                case 1:
                    Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                 case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                 case 7:
                    Console.WriteLine("Pazar");
                    break;
                default:
                    Console.WriteLine("Hatalı bir değer girdiniz..");
                    break;

            }
            */
            // ay giriniz.. 
            // çıktı olarak aralık ayı kış mevsimindedir gibi çıktı almak istiyoruz. her ay için düzenlenmeli
            // switch case kullanılacak.

            Console.WriteLine("Bir ay giriniz: ");
            string ay = Console.ReadLine();

            switch (ay)
            {
                case "aralık":
                        break;
                case "ocak":
                case "şubat":
                    Console.WriteLine(ay + " ayı kış mevsimindedir.");
                    break;
                case "mart":
                case "nisan":
                case "mayıs":
                    Console.WriteLine(ay + " ayı ilkbahar mevsimindedir.");
                    break;
                case "haziran":
                              case "temmuz":
                               case "ağustos":
                    Console.WriteLine(ay + " ayı yaz mevsimindedir.");
                    break;
                
                case "eylül":
                
                case "ekim":
                
                case "kasım":
                    Console.WriteLine(ay + " ayı sonbahar mevsimindedir.");
                    break;
                default:
                    Console.WriteLine("Geçersiz bir ay girdiniz.");
                    break;
            }



        }
    }
}