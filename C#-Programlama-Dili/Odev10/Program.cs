using System.Collections;
using System.Text.RegularExpressions;

namespace Odev10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // 7. Ödevin içeriği metod kısmında

                #region Soru1
                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 1: ");
                Console.Write("Bir sayı giriniz: ");
                int girilenSayi = int.Parse(Console.ReadLine());

                TekVeCiftSayilariBulVeYazdir(girilenSayi);


                #endregion
                #region Soru2
                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 2: ");
                //string[] dizi = new string[5];

                //for (int i = 0; i < dizi.Length; i++)
                //{
                //    Console.Write($"{i + 1}. elemanı giriniz: ");
                //    dizi[i] = Console.ReadLine();
                //}

                //EnUzunElemaniBulVeYazdir(dizi);

                #endregion
                #region Soru3

                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 3: ");             
                //Console.Write("Bir kelime giriniz: ");
                //string girilenKelime = Console.ReadLine();

                //string tersKelime = KelimeyiTersCevir(girilenKelime);
                //Console.WriteLine("Ters Kelime: " + tersKelime);

                #endregion
                #region Soru4

                Console.WriteLine("***************************************");
                Console.WriteLine("Soru 4: ");
                Console.Write("Girdi : ");
                string metin = Console.ReadLine();

                string harfSonuc = AyirHarfVeSayi(metin, true);
                string sayiSonuc = AyirHarfVeSayi(metin, false);

                Console.WriteLine("Çıktı = Harfler = " + harfSonuc);
                Console.WriteLine("Çıktı = Sayılar = " + sayiSonuc);
                #endregion
                #region Soru5
                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 5: ");
                //Console.Write("Birinci sayıyı girin: ");
                //decimal sayi1 = decimal.Parse(Console.ReadLine());

                //Console.Write("İkinci sayıyı girin: ");
                //decimal sayi2 = decimal.Parse(Console.ReadLine());

                //Console.Write("Üçüncü sayıyı girin: ");
                //decimal sayi3 = decimal.Parse(Console.ReadLine());

                //decimal enBuyukSayi = EnBuyukSayiyiBul(sayi1, sayi2, sayi3);

                //Console.WriteLine("En büyük sayı: " + enBuyukSayi);

                #endregion
                #region Soru6
                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 6: ");
                //Console.WriteLine("İki integer sayı için 1, üç decimal sayı için 2 tuşlayın:");
                //int secim = int.Parse(Console.ReadLine());

                //if (secim == 1)
                //{
                //    Console.Write("Birinci integer sayıyı giriniz: ");
                //    int number1 = int.Parse(Console.ReadLine());
                //    Console.Write("İkinci integer sayıyı giriniz: ");
                //    int number2 = int.Parse(Console.ReadLine());

                //    int toplamInt;
                //    Topla(number1, number2, out toplamInt);
                //    Console.WriteLine("İki integer'ın toplamı: " + toplamInt);
                //}
                //else if (secim == 2)
                //{
                //    Console.Write("Birinci decimal sayıyı giriniz: ");
                //    decimal number1 = decimal.Parse(Console.ReadLine());
                //    Console.Write("İkinci decimal sayıyı giriniz: ");
                //    decimal number2 = decimal.Parse(Console.ReadLine());
                //    Console.Write("Üçüncü decimal sayıyı giriniz: ");
                //    decimal number3 = decimal.Parse(Console.ReadLine());

                //    decimal toplamDecimal;
                //    Topla(number1, number2, number3, out toplamDecimal);
                //    Console.WriteLine("Üç decimal'ın toplamı: " + toplamDecimal);
                //}
                //else
                //{
                //    Console.WriteLine("Geçersiz seçim.");
                //}

                #endregion
                #region Soru7
                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 7: ");
                //sorularım5();

                #endregion
                #region Soru8
                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 8: ");
                //Console.Write("Bir kelime veya cümle giriniz: ");
                //string girilenMetin = Console.ReadLine();

                //string duzeltilmisMetin = TurkceKarakterleriDuzelt(girilenMetin);
                //Console.WriteLine("Düzeltilmiş Metin: " + duzeltilmisMetin);
                #endregion
                #region Soru9
                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 9: ");
                //Console.Write("Bir cümle giriniz: ");
                //string girilenCumle = Console.ReadLine();

                //string slug = CumleyiSlugYap(girilenCumle);
                //Console.WriteLine("Slug: " + slug);
                #endregion
                #region Soru10
                //Console.WriteLine("***************************************");
                //Console.WriteLine("Soru 10: ");
                //Console.Write("Adınızı ve Soyadınızı Giriniz: ");
                //string adSoyad = Console.ReadLine();

                //Console.Write("Sipariş Tarihinizi Giriniz (gg.aa.yyyy): ");
                //string siparisTarihi = Console.ReadLine();

                //Console.Write("Sipariş Numaranızı Giriniz: ");
                //string siparisNumarasi = Console.ReadLine();

                //string emailIcerik = EmailIcerigiOlustur(adSoyad, siparisTarihi, siparisNumarasi);
                //Console.WriteLine("\nE-posta İçeriği:\n" + emailIcerik);
                #endregion
                Console.ReadKey();
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

        static void sorularım5()
        {
            // Soru 1: Dizi Elemanlarını Tersine Çevirme
            int[] orijinalDizi = { 1, 2, 3, 4, 5 };
            for (int i = orijinalDizi.Length - 1; i >= 0; i--)
            {
                Console.Write(orijinalDizi[i] + " ");
            }
            Console.WriteLine();

            // Soru 2: En Küçük ve En Büyük Sayıyı Bulma
            int enKucuk = orijinalDizi[0], enBuyuk = orijinalDizi[0];
            foreach (int sayi in orijinalDizi)
            {
                if (sayi < enKucuk) enKucuk = sayi;
                if (sayi > enBuyuk) enBuyuk = sayi;
            }
            Console.WriteLine("En Küçük: " + enKucuk + ", En Büyük: " + enBuyuk);

            // Soru 3: Çift Sayıları Filtreleme
            foreach (int sayi in orijinalDizi)
            {
                if (sayi % 2 == 0)
                {
                    Console.Write(sayi + " ");
                }
            }
            Console.WriteLine();

            // Soru 5: Sayıları Sıralama
            ArrayList sayilar = new ArrayList() { 5, 3, 8, 1, 2 };
            sayilar.Sort();
            foreach (int sayi in sayilar)
            {
                Console.Write(sayi + " ");
            }
            Console.WriteLine();
        }

        static string TurkceKarakterleriDuzelt(string metin)
        {
            metin = metin.Replace('ç', 'c').Replace('Ç', 'C')
                        .Replace('ğ', 'g').Replace('Ğ', 'G')
                        .Replace('ı', 'i').Replace('İ', 'I')
                        .Replace('ö', 'o').Replace('Ö', 'O')
                        .Replace('ş', 's').Replace('Ş', 'S')
                        .Replace('ü', 'u').Replace('Ü', 'U');
            return metin;
        }
        static string CumleyiSlugYap(string cumle)
        {

            string slug = cumle.ToLower();

            slug = slug.Replace('ç', 'c').Replace('ö', 'o')
                       .Replace('ş', 's').Replace('ğ', 'g')
                       .Replace('ü', 'u').Replace('ı', 'i');

            slug = slug.Replace(" ", "-");
            return slug;
        }

        static string EmailIcerigiOlustur(string adSoyad, string siparisTarihi, string siparisNumarasi)
        {
            return $"Sayın {adSoyad}, {siparisTarihi} tarihinde almış olduğunuz ürünlere ait sipariş numaranız {siparisNumarasi} şeklindedir. Bu numara ile siparişinizi web sitemiz üzerinden takip edebilirsiniz.";
        }


    }

}