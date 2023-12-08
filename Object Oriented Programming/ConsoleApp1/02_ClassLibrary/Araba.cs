using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ClassLibrary
{
    // Private Sadece bu sınıfın içerisinden erişilebilir.
    // Diğer sınıflar veya isim alanlarından erişilemez.
    // Genellikle sınıfın içindeki yardımcı fonksiyonlar veya değişkenler için kullanılır.
    //private class ArabaOzel1
    //{
    // Bu sınıf yalnızca tanımlandığı sınıf içerisinde görülebilir ve kullanılabilir.
    //}

    // Internal Varsayılan erişim belirleyicidir - bu proje içerisinden erişilebilir,
    // fakat referans verilse dahi başka projelerden erişilemez.
    // Genellikle, sınıfın yalnızca kendi bulunduğu proje içinde kullanılmasını istediğinizde kullanılır.
    //internal class ArabaOzel2
    //{
    // Bu sınıf mevcut projede herhangi bir yerden erişilebilir ama başka projelerden erişilemez.
    // Farklı bir projeden bu sınıfa erişmek için bu sınıfı 'public' olarak işaretlemek gerekir.
    //}

    // Public Bu projenin içerisindeki tüm diğer sınıflar ve isim alanları bu sınıfa erişebilir.
    // Ayrıca bu sınıfa diğer projelerden de referans verilerek erişilebilir.
    // Genellikle, API'lerde veya kütüphanelerdeki sınıflar için kullanılır.
    public class Araba
    {
        // Bu sınıf, tanımlandığı projede ve referans verilen diğer projelerde erişilebilir.
        // Erişim kısıtlaması olmaksızın genel kullanım için uygundur.

        //Fields (Değişkenler)
        private int _suankiHizi;
        public int _suankiYolcuSayisi;

        //Properties(Özellikler)
        public string Marka { get; set; }
        public string Model { get; set; }
        public int MaksimumHiz { get; set; }

        //Events (Olaylar)  // Arabayı çalıştırmak gibi altına araba çalıştıkça benzin harca gibi komutlar.
        public event EventHandler Calistirildi;

        //Constructors (Temel yapı oluşturucusu)   // ctor + TAB hızlıca yapı oluşturur. - Class ismi ile adı aynı olmak zorunda.
        public Araba()
        {

        }
        public Araba(int yolcuSayisi)
        {
            _suankiYolcuSayisi = yolcuSayisi;
        }
        //public Arabaa)
        //{


        //}

        //Methods ( Metotlar) -- Overload edilebilirler.
        public void KapilariKilitle()
        {

        }

        public void KapilariKilitle(bool anahtarKontaktami)
        {

        }

        public void Ilerle()
        {

        }


        public class Kisi
        {

            public string Adi { get; set; }
            public string Soyadi { get; set; }
            public DateTime DogumTarihi { get; set; }
            public string TcNo { get; set; }

            public Kisi(string TcNo2)
            {
                TcNo = TcNo2;
            }

            public string AdiSoyadiGetir()
            {
                return this.Adi + "" + this.Soyadi;
            }

        }

        // Personel isimli bir static sınıf tanımlanıyor. Static sınıf, sınıfın kendisine özgü olup
        // nesne örneği oluşturulmadan erişilebilen üyeler içerir.
        public static class Personel
        {
            // Adi ve Soyadi özellikleri static tanımlanmış.
            // Bu özellikler, Personel sınıfının tüm örnekleri arasında paylaşılan değerlere sahip olacak.
            public static string Adi { get; set; }
            public static string Soyadi { get; set; }
        }

        // Burada Personel isimli başka bir sınıf tanımlanıyor ancak bu geçerli bir kullanım değildir
        // çünkü C# dilinde aynı isim alanında aynı isimde iki sınıf olamaz.
        // Ancak eğer bu ikinci sınıfın ismi farklı olsaydı, bu sefer non-static bir sınıf tanımı olurdu.
        //public class Personel
        //{
        //    // Static sınıfların aksine, non-static sınıflarda hem static hem de non-static üyeler bulunabilir.
        //    // Buradaki Adi ve Soyadi static olarak tanımlanmış, yani bu özellikler sınıfın tüm örnekleri için ortak.
        //    public static string Adi { get; set; }
        //    public static string Soyadi { get; set; }
        //}

        public class Ogretmen
        {
            public  string Adi { get; set; }  // non static 
            public static string Soyadi {get ; set; }
           
        }


    }
}