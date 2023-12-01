﻿namespace _15_StringMethodlari
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


        }
    }
}