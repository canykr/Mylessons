namespace _02_AritmetikselOperatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (+)Operatörü
            int toplam = 10 + 10 * (8 - 4);
            Console.WriteLine("Sonuç = " + toplam);

            decimal fiyat1 = 125.55m;
            decimal fiyat2 = 25.21m;

            decimal toplamFiyat = fiyat1 + fiyat2;
            Console.WriteLine("Toplam Ücret = " + toplamFiyat + " TL");

            Console.WriteLine("Toplam Ücret = " + (fiyat1 + fiyat2) + " TL");

            Console.WriteLine("Toplam Ücret = " + fiyat1 + fiyat2 + " TL");
            Console.WriteLine("Toplam Ücret = " + toplamFiyat + " TL");

            Console.WriteLine(fiyat1 + " + " + fiyat2 + " = " + toplamFiyat);
            Console.WriteLine(fiyat1 + fiyat2);
            Console.WriteLine(fiyat1 + fiyat2 + 10);

            string adi = "Aykut";
            string soyadi = "BASTUG";
          
            Console.WriteLine(adi + " " + soyadi);
            #endregion


            #region (%) Operatörü
            /*
          //Sayısal değerler arasında mod alma işlemi yapmak için kullanılır, metinsel değerlerde kullanılmaz.
          //İki sayının bölümünden kalan değeri

          sayi1 = 5;
          sayi2 = 3;
          Console.WriteLine("Sonuç = " + (sayi1 % sayi2));
             */
            #endregion



            #region İkili Operatör Kullanımı
            int yas = 35;
            yas++;
            yas--;

            Console.WriteLine("Sonuç = " + yas);

            int sayi5 = 65;
            --sayi5;
            sayi5++;

            Console.WriteLine("Sonuç = " + sayi5);

            int sayi6 = 36;
            sayi6 += 10; //sayi6 = sayi6 + 10;
            Console.WriteLine("Sonuç = " + sayi6);

            sayi6 -= 10; //sayi6 = sayi6 - 10;
            Console.WriteLine("Sonuç = " + sayi6);

            sayi6 *= 10; //sayi6 = sayi6 * 10;
            Console.WriteLine("Sonuç = " + sayi6);

            sayi6 /= 10; //sayi6 = sayi6 / 10;
            Console.WriteLine("Sonuç = " + sayi6);

            #endregion

















            //Herhangi bir tuşa basıldığında konsol ekranı açık kalması için aşağıdaki kod satırı kullanılır
            Console.ReadKey();





        }
    }
}

