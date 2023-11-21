namespace Notodevi
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            {
                int not1, not2, not3;
                double ortalama;

               
                while (true)
                {
                    try
                    {
                        Console.Write("Birinci sınav notunu girin: ");
                        not1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("İkinci sınav notunu girin: ");
                        not2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Üçüncü sınav notunu girin: ");
                        not3 = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş! Lütfen sınav notlarını tam sayı olarak girin.");
                    }
                }

               
                ortalama = (not1 + not2 + not3) / 3.0;

                
                string harfNotu;
                if (ortalama < 45)
                    harfNotu = "FF";
                else if (ortalama < 65)
                    harfNotu = "DD";
                else if (ortalama < 75)
                    harfNotu = "CC";
                else if (ortalama < 85)
                    harfNotu = "BB";
                else
                    harfNotu = "AA";

               
                Console.WriteLine($"Ortalama: {ortalama:N2}");
                Console.WriteLine($"Harf Notu: {harfNotu}");
            }
        }

    }
}
