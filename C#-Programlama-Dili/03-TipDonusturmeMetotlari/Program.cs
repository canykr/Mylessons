namespace _03_TipDonusturmeMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Convert sınıfı ile tip değiştirme

            string sayi1 = "5";
            string sayi2 = "6";

            int toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);

            Console.WriteLine($"Sonuc = {toplam}");
            Console.WriteLine($"Sonuc = {sayi1 + sayi2}");

            int birinciSayi = 8;
            int ikinciSayi = 9;
            // double sonuc= birinciSayi / ikinciSayi; // int tipinde değerler olduğu için sonuç virgüllü olarak bize dönmez
            double sonuc = Convert.ToDouble(birinciSayi) / Convert.ToDouble(ikinciSayi);

            Console.WriteLine($"Sonuc={sonuc}");


            int a = 0;
            int b = 1;
            bool c = Convert.ToBoolean(a);
            bool d = Convert.ToBoolean(b);


            #endregion

            #region Parse Metodu ile tip değiştirme
            toplam = int.Parse(sayi1) + int.Parse(sayi2);
            Console.WriteLine("Sonuc = " + toplam);

            decimal virgulluSonuc = decimal.Parse(sayi1) / decimal.Parse(sayi2);
            Console.WriteLine("Sonuc = " + virgulluSonuc);



            // ArgumentNullException = Değer null olduğu için hata fırlatır.
            //string? deger1 = null;
            //Convert.ToInt32(deger1);
            //int.Parse(deger1);

            // FormatException = değer uygun formatta olmadığı zaman bu hata fırlatılır. 
            //Convert.ToInt32("5p");

            // OverflowException = değer dönüştürelecek hedef türün sınırları dışında ise bu hata fırlatırlır
            //Convert.ToInt16(9999999);

            // 1. Fark
            // Convert sınıfı sadece belirli tiplere dönüştürebiliriz.(int, decimal, datetime, double, bool, chat, byte)
            // Parse sınıfı ise tüm türlere  dönüştürebilir. TryParse ise dönüştürmenin mümkün olup olmadığını kontrol eder.

            // 2. Fark
            // Convert sınıfında değerin null olması durumunda ArgumentNullException hatasına düşmez, fakat parse metodunda hataya düşer.

            #endregion

            #region ToString metodu ile string tipine dönüştürme

            decimal x = 5;
            decimal y = 7;

            Console.WriteLine(x.ToString());
            Console.WriteLine(x.ToString() + y.ToString());

            decimal sonuc1 = x / y;
            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc1.ToString("n2"));
            Console.WriteLine(123143.ToString("c2"));


            #endregion

            #region Implicit(Üstü kapalı) ve Explicit (Belirgin) Dönüşümler  

            // üstü kapalı
            int t = 135;
            long u = t;

            // belirgin
            long i = 123;
            int i2 = (int)i;

            Console.WriteLine("Lütfen adınızı giriniz...");
            string adi = Console.ReadLine();
            Console.WriteLine("Adınız : " + adi);

            // Birinci sayıyı giriniz...
            // İkinci sayıyı giriniz...
            // İki sayının toplamını ekrana yazdırsın.
            
            Console.WriteLine("Birinci Sayıyı giriniz...");
            int sayix = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İkinci Sayıyı giriniz...");
            int sayiy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Toplam =" + (sayix + sayiy));

            // Kullanıcıdan iki tane tam sayı formatında değer girmesini isteyelim.
            // Bu iki sayının ortalamasını hesaplayıp virgülden sonrar 2 hane olacak şekilde ekrana yazdıralım. 

            Console.Write("Lütfen birinci tam sayıyı girin: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci tam sayıyı girin: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            double ortalama = (number1 + number2) / 2.0;
            Console.WriteLine($"Girilen sayıların ortalaması: {ortalama.ToString("n2")}");

            #endregion

            Console.ReadKey();
        }
    }
}