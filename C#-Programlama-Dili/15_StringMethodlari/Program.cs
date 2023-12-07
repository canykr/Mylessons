using System.Net.Http.Headers;

namespace _15_StringMethodlari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string _adiSoyadi = " Aykut Baştuğ ";
            string adiSoyadi1 = _adiSoyadi.Trim();
            string adiSoyadi2 = _adiSoyadi.TrimEnd(); // Sadece sondaki boşlukları siler
            string adiSoyadi3 = _adiSoyadi.TrimStart(); // Sadece baştaki boşlukları siler

            // ToLower() tüm harfleri küçük harfe dönüştürür
            string _isim = "AYKut BAŞTUĞ";
            string isim1 = _isim.ToLower();

            // ToUpper() tüm harfleri büyük harfe dönüştürür
            string isim2 = _isim.ToUpper();

            // Replace() metnin içindeki herhangi bir değeri farklı bir değer ile değiştirmek için kullanılır
            string _aciklama = "metnin içindeki herhangi bir değeri farklı bir değer";
            string aciklama1 = _aciklama.Replace('i', 'İ');
            string aciklama2 = _aciklama.Replace(' ', '-');
            string aciklama3 = _aciklama.Replace(" ", "");
            string aciklama4 = _aciklama.Replace("a", "u");
            string aciklama5 = _aciklama.Replace("bir", "iki");

            // ToCharArray() metnin içindeki tüm karakterleri char dizisine dönüştürerek geriye döner
            string ilce = "Ümraniye";
            char[] karakterler1 = ilce.ToCharArray();
            char[] karakterler2 = ilce.ToCharArray(3, 2);

            // PadLeft() metnin istediğimiz karakter sayısına ulaşana kadar sol tarafına değer ekliyor.
            string _faturaNo = "41";
            string faturaNo1 = _faturaNo.PadLeft(5, '0');

            // PadRight() metnin istediğimiz karakter sayısına ulaşana kadar sağ tarafına değer ekliyor.
            string faturaNo2 = _faturaNo.PadRight(4, '0');

            //Equals() parametre olarak verilen deger ile degiskenin8 degeri aynı mı degil mi diye kontrol eder. (eşit mi değil mi kontrolünü yapıyor) örnekteki if elsenin işini yapıyor.
            string _metin = "kıyaslamak icin kullanılır";
            bool esitMi = _metin.Equals("icin");
            bool esitMi1 = _metin.Equals("kıyaslamak icin kullanılır");

            if (_metin == "kıyaslamak icin kullanılır")
                esitMi1 = true;
            else
                esitMi1 = false;


            //SubString() metodu string bir deger icerisinden parca almak icin kullanılır.
            string _ornek = "Örnek metni buraya giriyorum.";
            string ornek1 = _ornek.Substring(5); //sadece index konumundan itibaren alır.
            string ornek2 = _ornek.Substring(5, 4); // 5. indexten sonra 4 karakter alır.

            //Reverse() metodu metnin icindeki karakterleri bir dizi haline getirerek tersten sıralar.
            string _terstenMetin = "Aykut BAŞTUĞ";
            char[] metinDizi = _terstenMetin.Reverse().ToArray();
            string terstenMetin = "";
            foreach (var item in metinDizi)
            {
                terstenMetin += item.ToString();
                Console.WriteLine(_terstenMetin);
            }

            //IndexOf() metodu metnin icindeki bir karakterin ya da kelimenin kacıncı indexte oldugunu bize döner int olarak.
            string notebook = "Asus Zenbook";
            int index1 = notebook.IndexOf('o');
            int index2 = notebook.IndexOf("Zen");
            int index3 = notebook.IndexOf("zen"); // karsılıgını bulamadıgı için -1 olarak döner.

            //Remove() metodu metnin icindeki herhangi bir indexten itibaren karakterleri silmek icin kullanılır.
            string _mevsim = "Ağustos";
            string mevsim1 = _mevsim.Remove(3);
            string mevsim2 = _mevsim.Remove(3, 2);
            // string mevsim3 =_mevsim.Remove(13,1); // eger olmayan bir index numarası verilirse kod satırı hata verir.

            //Contains() metodu metinin içinde bir karakter ya da kelimeyi içeriyor mu diye kontrol etmek için kullanılır.
            string marka = "philips";
            marka.Contains('i');
            bool iceriyorMu = marka.Contains("i");
            bool iceriyorMu2 = marka.Contains("lip");
            bool iceriyorMu3 = marka.Contains("olip");
            bool iceriyorMu4 = marka.Contains("o");
            bool iceriyorMu5 = marka.Contains("İ");  // büyük kücük harf duyarlılıgı var.

            // StartsWith() metodu metnin herhangi bir karakter yada kelime ile başlayıp başlamadığını kontrol ediyor.
            string meyve = "Portakal";
            bool il_eBasliyorMu1 = meyve.StartsWith('p');
            bool il_eBasliyorMu2 = meyve.StartsWith('P');
            bool il_eBasliyorMu3 = meyve.StartsWith('x');
            bool il_eBasliyorMu4 = meyve.StartsWith("Por");
            bool il_eBasliyorMu5 = meyve.StartsWith("por");


            // EndsWith() metodu metnin herhangi bir karakter yada kelime ile bitip bitmediğini kontrol ediyor.
            bool il_eBitiyorMu1 = meyve.EndsWith('l');
            bool il_eBitiyorMu2 = meyve.EndsWith('L');
            bool il_eBitiyorMu3 = meyve.EndsWith('x');
            bool il_eBitiyorMu4 = meyve.EndsWith("kal");
            bool il_eBitiyorMu5 = meyve.EndsWith("Kal");

            //IsNullOrEmpty() metodu metnin NULL veya bos olup olmadıgını kontrol eder. NULL veya bos degil ise False degeri döndürür.
            //string isim = "";
            string? isim = null;
            isim = "Aykut";

            if (string.IsNullOrEmpty(isim) == true)
                Console.WriteLine("İsim girilmedi!");
            else
                Console.WriteLine("Merhaba " + isim);

            // kullanıcıdan 3 tane isim istesin isim girilmediyse isim girilmediğiniz uyarısını versin tekrar girmesini sağlasın, 3 ismi girdikten sonra M harfi ile başlayanları alt alta ekrana yazdırsın.
            string[] isimler = new string[3];

            for (int i = 0; i < isimler.Length; i++)
            {
                string isim_;
                do
                {
                    Console.Write($"Lütfen {i + 1}. ismi giriniz (sadece harfler olmalı): ");
                    isim_ = Console.ReadLine();

                    // Boş kontrolü ve sadece harflerden oluşup oluşmadığının kontrolü
                    if (string.IsNullOrEmpty(isim_) || !IsAllLetters(isim_))
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen boş bırakmayın ve sadece harf giriniz.");
                    }
                }
                while (string.IsNullOrEmpty(isim_) || !IsAllLetters(isim_));

                isimler[i] = isim_;
            }

            Console.WriteLine("\n'M' harfi ile başlayan isimler:");
            foreach (var isim_ in isimler)
            {
                if (isim.ToUpper().StartsWith("M"))
                {
                    Console.WriteLine(isim_);
                }
            }
        }
    }
}