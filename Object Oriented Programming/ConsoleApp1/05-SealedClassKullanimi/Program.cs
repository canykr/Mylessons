using _05_SealedClassKullanimi.Models;
using static _05_SealedClassKullanimi.Yonetici;

namespace _05_SealedClassKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Cihaz cihaz = new Cihaz();
            ////cihaz.Barkod = "123132";



            ////// 'sealed' anahtar sözcüğü, bir sınıfın başka sınıflar tarafından miras alınmasını engellemek için kullanılır.
            ////// Bu, sınıf hiyerarşisinin bu noktada sonlandığını ve 'sealed' olarak işaretlenmiş sınıftan türetilmiş sınıfların oluşturulamayacağını belirtir.
            ///Sealed class miras alınamaz class'lardır.
            // public sealed class Cihaz
            // {
            //public string Barkod { get; set; }
            // }

            //public class Elektronik  
            //{ 

            //Öğretmen nesnesi oluşturuluyor ve özelliklere değer atanıyor.
            Ogretmen ogretmen = new Ogretmen
            {
                Adi = "Ahmet",
                Soyadi = "Yılmaz",
                DogumTarihi = new DateTime(1980, 5, 12),
                Maas = 4000M,
                Meslek = "Matematik Öğretmeni"
            };
            ogretmen.DerseHazirlan();
            ogretmen.DersAnlat();

            // Yönetici nesnesi oluşturuluyor ve özelliklere değer atanıyor.
            Yonetici yonetici = new Yonetici
            {
                Adi = "Ayşe",
                Soyadi = "Kara",
                DogumTarihi = new DateTime(1975, 8, 21),
                Maas = 6000M,
                Meslek = "Okul Müdürü"
            };
            yonetici.MaasOde();

            // Öğrenci nesnesi oluşturuluyor ve özelliklere değer atanıyor.
            Ogrenci ogrenci = new Ogrenci
            {
                Adi = "Mehmet",
                Soyadi = "Çelik",
                DogumTarihi = new DateTime(2005, 3, 15),
                NotOrtalamasi = 85.7
            };
            ogrenci.DersCalis();
            ogrenci.TekrarEt();
            ogrenci.OdevYap();

            Console.WriteLine("Öğretmen Bilgileri: " + ogretmen.Adi + " " + ogretmen.Soyadi + ", " + ogretmen.Meslek);
            Console.WriteLine("Yönetici Bilgileri: " + yonetici.Adi + " " + yonetici.Soyadi + ", " + yonetici.Meslek);
            Console.WriteLine("Öğrenci Bilgileri: " + ogrenci.Adi + " " + ogrenci.Soyadi + ", Not Ortalaması: " + ogrenci.NotOrtalamasi);
        }

    }
}


//öğrenci, öğretmen,yönetici class alınacak 

//tümünde adı, soyadı , doğumtarihi
//öğretmen ve yönetici maaş,mesleği özelliklerine sahip
//öğretmen DerseHazırlan(),DersAnlat() işlerini yapabilir (metot)
//yönetici MaaşÖdeme işini yapabilir.
//öğrenci de DersÇalış(),TekrarEt(),ÖdevYap() işlerini yerine getirebilir. ve NotOrtalaması özelliği olabilir.

