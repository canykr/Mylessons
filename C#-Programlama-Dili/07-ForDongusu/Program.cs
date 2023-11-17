namespace _07_ForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             for (int i = 1; i <= 15; i++) 
             {  
                 Console.WriteLine(i);
             }

             // sonsuz döngü için
             for (int i = 1; i>0 ; i++)
             {  
                 Console.WriteLine(i);
             }
            
            // çift çift arttırmak
            for (int i = 0;  i<20; i+=2) 
            {
                Console.WriteLine(i);
            }
            

            // eskiltme
            for (int i = 20; i >=0; i--) 
            {
                Console.WriteLine(i);
            }
             
            // char kullanarak harfleri döngüye alma
            for (char i ='a' ; i<='z' ; i++) 
            {
                Console.WriteLine(i);
            }
            */


            // 1 ile 50 arasındaki çift sayıları ekrana yazdıran kod blogu

            //Console.WriteLine("Bir başlangıç sayısı giriniz:");
            //int sayi1=Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bir bitiş sayısı giriniz:");
            //int sayi2=Convert.ToInt32(Console.ReadLine());


            /*
            for (int i = sayi1; i <= sayi2 ; i++)
            
            {
              if (i % 2==0)
               {
                    Console.WriteLine(i);
                }
            }

            
            if (sayi1 % 2 != 0)
                sayi1++;

            for (int i = sayi1;i <= sayi2 ; i+=2)
            {
                Console.WriteLine(i);
            }
            */

            // kullanıcıdan bir metin isteyelim
            // kaç sefer ekrana yazdırmak istiyorsun? sorusunu soralım ona göre yazdıralım

            /*

            Console.WriteLine("Lütfen bir metin giriniz : ");
            string metin1 = Console.ReadLine();

            Console.WriteLine("Ekrana kaç kere yazdırmak istiyorsunuz?");
            int tekrar=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tekrar; i++)
            {
                Console.WriteLine(metin1);
            }

            */
            /*
            for (int sayi = 1; sayi < 15; sayi++)
            {
                for (char harf= 'A' ; harf < 'K' ; harf++)
                {
                    Console.WriteLine($"Sayı = {sayi}-Harf = {harf}");
                }
            }
            */
            /*
            for (int i = 1; i <= 10; i++) 
            {
                for (int j = 1; j <= 10; j++) 
                {
                    Console.WriteLine($"{i} * {j} = {i * j}"); 
                }
            }

            */
            /*
            int sayi = 10;

            while (sayi >= 0)
            {
                Console.Write(sayi + " ");
                sayi--;

            }
            */













        }


    }
}