namespace _04_MantiksalOperatorlerveIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
           Console.WriteLine("Kullanıcı Adınızı Giriniz:");
           string kullaniciAdi= Console.ReadLine();
           Console.WriteLine("Şifrenizi Giriniz:");
           string sifre= Console.ReadLine();


           if (kullaniciAdi=="canykr")
           { 
               Console.WriteLine("Kullanıcı adı doğru!");
           }
           else
           {
               Console.WriteLine("Kullanıcı adı hatalı!");
           }

           if (kullaniciAdi != "canykr")
           {
               Console.WriteLine("Kullanıcı adı hatalı");
           }

           if (kullaniciAdi== "canykr")
               Console.WriteLine("Kullanıcı adı doğru");
           else
               Console.WriteLine("Kullanıcı adı hatalı");

           if (sifre == "123")
               Console.WriteLine("Şifre Doru");
           else
               Console.WriteLine("Şifre Hatalı!");



           if (kullaniciAdi == "canykr")
           {
               Console.WriteLine("Kullanıcı adı doğru!");
               if (sifre =="123")
                   Console.WriteLine("Şifre Doru");
               else
                   Console.WriteLine("Şifre Hatalı!");
           }
           else
           {
               Console.WriteLine("Kullanıcı adı hatalı!");
           }

           if (kullaniciAdi != "canykr" || sifre != "123")
               Console.WriteLine("Kullanıcı adı veya şifresi hatalı");
           else
               Console.WriteLine("Giriş yaptınız");

           Console.WriteLine("Devam etmek istiyor musunuz? (E/H)");
           string degisken1 = Console.ReadLine();
           if (degisken1 == "E" || degisken1 == "e")
               Console.WriteLine("Evet");
           else
               Console.WriteLine("Hayır");

             */
            // ==
            // !=
            // >
            // <
            // >=
            // <=
            // %2 --Mod alma
            /*
            int sayi1 = 10;
            int sayi2 = 20;

            /*
            if (sayi1 > sayi2)
            {
                Console.WriteLine("Sayı1 büyüktür");
            }
            else if (sayi1 == sayi2) 
            {
                Console.WriteLine("Sayılar eşit");
            }
            else 
            {
                Console.WriteLine("Sayı2 büyüktür");
            }
          

            if (sayi1 > sayi2 && sayi1 >0)
                Console.WriteLine("Sayı1 büyüktür");
            else if (sayi1 == sayi2)
                Console.WriteLine("Sayılar eşit");
            else 
                Console.WriteLine("Sayı2 büyüktür");
            */


            // kullanıcının bir sayi girmesini isteyelim.
            //negatif bir sayı girdi ise uyarı verip uygulamayı durduralım.
            // eğer sayı pozitif ise , ikinci sayıyı girmesini isteyelim. 
            //2. sayı negatif ise uygulamayı durduralım. Pozitif sayı ise bu iki sayının çarpımını yazdıralım.



            /*

            Console.WriteLine("Bir sayı giriniz: "); 
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 <= 0)
            {
                Console.WriteLine("Negatif sayı girdiniz.");
            }
            else
            {
                Console.WriteLine("İkinci bir sayı giriniz: "); 
                int sayi2 = Convert.ToInt32(Console.ReadLine());

                if (sayi2 < 0)
                {
                    Console.WriteLine("Negatif sayı girdiniz.");
                }
                else
                {
                    int carpim = sayi1 * sayi2;
                    Console.WriteLine("Sayıların çarpımı: " + carpim);
                }
           
            }
             */
            // kişiden 4 tane değer girmesini isteyelim
            // girilen sayılardan çift olanları bulup yan yana yazdıralım.

            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;


            Console.WriteLine("1. sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3. sayıyı giriniz: ");
            sayi3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("4. sayıyı giriniz: ");
            sayi4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Çift sayılar: ");
            if (sayi1 % 2 == 0)
            {
                Console.Write(sayi1 + ",");
            }

            if (sayi2 % 2 == 0)
            {
                Console.Write(sayi2 + ",");
            }

            if (sayi3 % 2 == 0)
            {
                Console.Write(sayi3 + ",");
            }

            if (sayi4 % 2 == 0)
            {
                Console.Write(sayi4);
            }
        }
    }
}