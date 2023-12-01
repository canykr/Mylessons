namespace _14_MethodKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İlk Satır");
            MethodIsmi();
            Console.WriteLine("Son Satır");

            Merhaba("Can");
            //Merhaba2(27);
            Yasiniz("Can Yakar", 27);
            //bu şekilde kullanımı mevcuttur.
            Yasiniz(yas: 27, adiSoyadi: "Can Yakar");
            Yasiniz2("Can Yakar");
            Yasiniz3("Can Yakar", null);
            int toplam = Topla(55, 38);
            //Geriye değer döndüren methodlar
            Console.WriteLine("Toplam = " + toplam);
            // farklı şekilde kullanımları
            Console.WriteLine("Toplam = " + Topla(25, 5));

            Console.WriteLine("İşlem Sonucu =" + IslemYap(40, 20, "topla"));


            //string sonuc = "";
            //OndanBuyukMu(9, out sonuc);

            Console.Clear();
            string result = "";
            if (OndanBuyukMu(9, out result) == true)
            {
                Console.WriteLine("Sayı 10'dan büyüktür");
            }
            else
            {
                Console.WriteLine("Sayı 10'dan küçüktür");
            }
            Console.WriteLine("-------------------");
            Console.WriteLine(result);

            Console.Clear();
            string sonuc = "";
            if (OndanBuyukMu(9, out result) == true)
            {
                Console.WriteLine("Sayı 10'dan büyüktür");
            }
            else
            {
                Console.WriteLine("Sayı 10'dan küçüktür");
            }
            Console.WriteLine("-----------------");
            Console.WriteLine(result);

            Console.Clear();

            int sayiDegeri = 0;
            if (SayiMi("123", out sayiDegeri))
            {
                Console.WriteLine("Girilen değer sayıdır = " + sayiDegeri);
            }
            else
            {
                Console.WriteLine("Girilen değer sayı değildir.");
            }


        }

        //static keyword(anahtar sözcüğü) = erşimi belirleyici
        //Geriye değer döndürmeyen, parametre almayan sadece kod bloğu içindeki satırları çalıştıran method.
        static void MethodIsmi()
        {
            // Kod blogu iki süslü parantez arası
            Console.WriteLine("Hello World!");
        }

        //geriye değer döndürmeyen, tek parametre alan method
        static void Merhaba(string adiSoyadi)
        {
            Console.WriteLine("Merhaba " + adiSoyadi);
            Merhaba2(27);
        }

        static void Merhaba2(int yas)
        {
            Console.WriteLine(yas);
        }

        // geriye değer döndürmeyen, 2 parametre alan method
        static void Yasiniz(string adiSoyadi, int yas)
        {
            Console.WriteLine(adiSoyadi + " " + yas + " yaşındadır.");
        }

        //geriye değer döndürmeyen, default değerlere sahip parametre tanımı olan method
        static void Yasiniz2(string adiSoyyadi, int yas = 18)
        {
            Console.WriteLine(adiSoyyadi + " " + yas + " yaşındadır.");
        }

        //geriye değer döndürmeyen, nullable parametre barındıran method   -- sorun işareti nullable hale getiriyor
        static void Yasiniz3(string adiSoyyadi, int? yas)
        {
            Console.WriteLine(adiSoyyadi + " " + yas + " yaşındadır.");
        }


        // GERİYE DÖNDÜREN METHODLAR

        //return komutu çalıştığı anda methodun içerisinde işlem bitmiş geri döndür anlamına gelir return sonrasında yazılan kodlar çalışmaz.

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            // Console.WriteLine("Sayı1 : " + sayi1 + " " + "Sayı2 :  " + sayi2 + " " + "Sonuç :  " + sonuc);  // bunu ben deniyorum. ders notu değil
            // Console.WriteLine($"Sayi1:{sayi1}" + $"Sayi2 ={sayi2}"
            return sonuc;
            return sayi1 + sayi2;
        }


        // İf içerisindeki return methodu çalıştırmaz, farklı yönlerden geri dönüş alamama şansı var. sonuna mutlaka eklememiz gerekiyor. veya else kullanıp sonuna return eklemeliyiz. Görmek için elseyi sil.
        static double IslemYap(double sayi1, double sayi2, string islemTipi)
        {
            //if (islemTipi == "topla")
            //{
            //    return sayi1 + sayi2;
            //}

            // return 0;

            //else if (islemTipi == "cikar")
            //{
            //    return sayi1 - sayi2;
            //}

            //else
            //    return sayi1 * sayi2;

            double sonuc = 0;
            if (islemTipi == "topla")
            {
                return sayi1 + sayi2;
            }

            else if (islemTipi == "cikar")
            {
                sonuc = sayi1 - sayi2;
            }
            return sonuc;


        }


        //out keyword'ü kullanarak parametre tanımlanan, geriye bool değer döndüren method
        static bool OndanBuyukMu(int sayi, out string sonuc)
        {
            if (sayi > 10)
            {
                sonuc = "Sayı 10'dan büyüktür";
                return true;
            }
            else
            {
                sonuc = "Sayı 10'dan küçüktür";
                return false;
            }

        }

        //Merhod Overload
        // Diğer method ile ismi aynı olamaz bu yüzden overload yani aynı isimde birden fazla method yazılabilmesine Method Overload Denmektedir.
        // Parametreleri farklı olursa sorun yok fakat aynı olursa sorun oluşturmaktadır.
        // Yukarıda değer verirken farklı parametre olursa fark edilir ve sorun çıkmaz fakat birebir aynı olursa çakışmaktadır.
        //imza(signature) = methodun parametreleridir. Methodun geriye dönüş tipi imzasına dahil değildir.
        
        /*
        static int Topla(int sayi1,)
        {
            return 0;
        }
        */

        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            return 0;
        }
        static int Topla(decimal sayi1)
        {
            return 0;
        }

        // Tryparse methodunu manuel olarak yazma örneği
      static bool SayiMi(string deger, out int sonuc)
        {
            try
            {
                sonuc = Convert.ToInt32(deger);
                return true;
            }
            catch (Exception ex)
            {
                sonuc = 0;
                return false;
            }
        }





    }

}
