namespace Odev10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {


                #region Soru1
                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 1: ");
                Console.WriteLine("***************************************");
                Console.Write("Bir sayı giriniz: ");
                int girilenSayi = int.Parse(Console.ReadLine());

                TekVeCiftSayilariBulVeYazdir(girilenSayi);


                #endregion
                #region Soru2
                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 2: ");
                Console.WriteLine("***************************************");

                string[] dizi = new string[5];

                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write($"{i + 1}. elemanı giriniz: ");
                    dizi[i] = Console.ReadLine();
                }

                EnUzunElemaniBulVeYazdir(dizi);

                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 3: ");
                Console.WriteLine("***************************************");
                Console.Write("Bir kelime giriniz: ");
                string girilenKelime = Console.ReadLine();

                string tersKelime = KelimeyiTersCevir(girilenKelime);
                Console.WriteLine("Ters Kelime: " + tersKelime);
                Console.Clear();

                #endregion
                #region Soru4

                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 4: ");
                Console.WriteLine("***************************************");
                Console.Write("Girdi : ");
                string metin = Console.ReadLine();

                string harfSonuc = AyirHarfVeSayi(metin, true);
                string sayiSonuc = AyirHarfVeSayi(metin, false);

                Console.WriteLine("Çıktı = Harfler = " + harfSonuc);
                Console.WriteLine("Çıktı = Sayılar = " + sayiSonuc); 
                #endregion
                #region Soru5
                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 5: ");
                Console.WriteLine("***************************************");
                Console.Write("Birinci sayıyı girin: ");
                decimal sayi1 = decimal.Parse(Console.ReadLine());

                Console.Write("İkinci sayıyı girin: ");
                decimal sayi2 = decimal.Parse(Console.ReadLine());

                Console.Write("Üçüncü sayıyı girin: ");
                decimal sayi3 = decimal.Parse(Console.ReadLine());

                decimal enBuyukSayi = EnBuyukSayiyiBul(sayi1, sayi2, sayi3);

                Console.WriteLine("En büyük sayı: " + enBuyukSayi);

                #endregion
                #region Soru6
                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 6: ");
                Console.WriteLine("***************************************");
                Console.WriteLine("İki integer sayı için 1, üç decimal sayı için 2 tuşlayın:");
                int secim = int.Parse(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Birinci integer sayıyı giriniz: ");
                    int number1 = int.Parse(Console.ReadLine());
                    Console.Write("İkinci integer sayıyı giriniz: ");
                    int number2 = int.Parse(Console.ReadLine());

                    int toplamInt;
                    Topla(number1, number2, out toplamInt);
                    Console.WriteLine("İki integer'ın toplamı: " + toplamInt);
                }
                else if (secim == 2)
                {
                    Console.Write("Birinci decimal sayıyı giriniz: ");
                    decimal number1 = decimal.Parse(Console.ReadLine());
                    Console.Write("İkinci decimal sayıyı giriniz: ");
                    decimal number2 = decimal.Parse(Console.ReadLine());
                    Console.Write("Üçüncü decimal sayıyı giriniz: ");
                    decimal number3 = decimal.Parse(Console.ReadLine());

                    decimal toplamDecimal;
                    Topla(number1, number2, number3, out toplamDecimal);
                    Console.WriteLine("Üç decimal'ın toplamı: " + toplamDecimal);
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim.");
                }

                #endregion
             

            }


        }

        static void TekVeCiftSayilariBulVeYazdir(int sayi)
        {
            string tekSayilar = "";
            string ciftSayilar = "";

            for (int i = sayi; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    ciftSayilar += i + " ";
                }
                else
                {
                    tekSayilar += i + " ";
                }
            }

            Console.WriteLine("Tek Sayılar: " + tekSayilar.Trim());
            Console.WriteLine("Çift Sayılar: " + ciftSayilar.Trim());
        }

        static void EnUzunElemaniBulVeYazdir(string[] dizi)
        {
            string enUzunEleman = "";
            int enUzunUzunluk = 0;
            int index = -1;

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].Length > enUzunUzunluk)
                {
                    enUzunEleman = dizi[i];
                    enUzunUzunluk = dizi[i].Length;
                    index = i;
                }
            }

            Console.WriteLine($"En uzun eleman = {enUzunEleman}");
            Console.WriteLine($"En uzun elemanın uzunluğu = {enUzunUzunluk}");
            Console.WriteLine($"En uzun elemanın indexi = {index}");
        }

        static string KelimeyiTersCevir(string kelime)
        {
            char[] karakterler = kelime.ToCharArray();
            Array.Reverse(karakterler);
            return new string(karakterler);
        }

        static string AyirHarfVeSayi(string metin, bool harfMi)
        {
            string sonuc = "";
            for (int i = 0; i < metin.Length; i++)
            {
                char karakter = metin[i];
                bool karakterHarf = (karakter >= 'a' && karakter <= 'z') || (karakter >= 'A' && karakter <= 'Z');
                bool karakterSayi = karakter >= '0' && karakter <= '9';

                if ((harfMi && karakterHarf) || (!harfMi && karakterSayi))
                {
                    bool tekrarVar = false;
                    for (int j = 0; j < sonuc.Length; j++)
                    {
                        if (sonuc[j] == karakter)
                        {
                            tekrarVar = true;
                            break;
                        }
                    }

                    if (!tekrarVar)
                    {
                        sonuc += karakter;
                    }
                }
            }

            char[] sonucDizi = sonuc.ToCharArray();
            Sirala(sonucDizi);
            return new string(sonucDizi);
        }

        static void Sirala(char[] dizi)
        {
            for (int i = 0; i < dizi.Length - 1; i++)
            {
                for (int j = i + 1; j < dizi.Length; j++)
                {
                    if (dizi[i] > dizi[j])
                    {
                        char temp = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = temp;
                    }
                }
            }
        }

        static decimal EnBuyukSayiyiBul(decimal sayi1, decimal sayi2, decimal sayi3)
        {
            decimal enBuyuk = sayi1;

            if (sayi2 > enBuyuk)
            {
                enBuyuk = sayi2;
            }

            if (sayi3 > enBuyuk)
            {
                enBuyuk = sayi3;
            }

            return enBuyuk;
        }

        static void Topla(int number1, int number2, out int toplam)
        {
            toplam = number1 + number2;
        }

        static void Topla(decimal number1, decimal number2, decimal number3, out decimal toplam)
        {
            toplam = number1 + number2 + number3;
        }

        
    }

}



