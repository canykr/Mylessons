using _02_ClassLibrary;
using static _02_ClassLibrary.Araba;

namespace ConsoleApp2
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            
            Araba nesne = new Araba();
            nesne.Marka = "Opel";
            nesne.Model = "Corsa";
            nesne.MaksimumHiz = 180;
            // nesne._suankiYolcuSayisi değer ataması burada yapılmalı.
            Console.WriteLine("Arabanın Markası: " + nesne.Marka);
            Console.WriteLine(nesne.Marka + " aracındaki Yolcu Sayısı : " + nesne._suankiYolcuSayisi);

            Araba nesne2 = new Araba();
            nesne2.Marka = "Fiat";
            nesne2.Model = "Linea";
            nesne2.MaksimumHiz = 180;
            // nesne2._suankiYolcuSayisi değer ataması burada yapılmalı.
            nesne2.Ilerle();
            nesne2.KapilariKilitle();
            Console.WriteLine(nesne2.Marka + " aracındaki Yolcu Sayısı : " + nesne2._suankiYolcuSayisi);


            Kisi kisi1 = new Kisi("4533523556");
            kisi1.Adi = "Can";
            kisi1.Soyadi = "Yakar";
            kisi1.DogumTarihi = new DateTime(1997, 1, 14);


            Console.WriteLine("Kişi Bilgileri");
            Console.WriteLine("Kimlik Numarası =" + kisi1.TcNo);
            Console.WriteLine("Adı : " + kisi1.Adi);
            Console.WriteLine("Soyadı : " + kisi1.Soyadi);
            Console.WriteLine("Doğum Tarihi : " + kisi1.DogumTarihi);
            Console.WriteLine("Adı Soyadı : " + kisi1.AdiSoyadiGetir);


            Console.Clear();
            Personel.Adi = "Aykut";
            Personel.Soyadi = "Soyadı";

            Console.WriteLine("Personel Bilgileri = " + Personel.Adi + " " + Personel.Soyadi);

            Console.Clear();
            Personel.Adi = "Aykut";
            Personel.Soyadi = "Soyadı";

            Console.WriteLine("Personel Bilgileri = " + Personel.Adi + " " + Personel.Soyadi);

            Ogretmen ogretmen = new Ogretmen();
            ogretmen.Adi = "Aykut"; // non static
            Ogretmen.Soyadi = "BAŞTUĞ";

            // Descructor YOK EDİCİ METOT
        }
    }

    }


