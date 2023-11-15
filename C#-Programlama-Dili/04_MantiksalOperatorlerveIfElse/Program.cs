namespace _04_MantiksalOperatorlerveIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kullanıcı Adınızı Giriniz:");
            string kullaniciAdi= Console.ReadLine();
            Console.WriteLine("Şifrenizi Giriniz:");
            string sifre= Console.ReadLine();

            /*
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
            */
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










        }
    }
}