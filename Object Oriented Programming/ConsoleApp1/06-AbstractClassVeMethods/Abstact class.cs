using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_AbstractClassVeMethods
{
    // abstact class kullanımı;

    // 'Cihaz' isimli abstract bir sınıf tanımlanmış. Abstract sınıflar, örnekleri doğrudan oluşturulamayan temel sınıflardır.
    // Bu sınıfta 'Barkod' isimli bir public property (özellik) ve 'BarkodGetir' isimli bir metot bulunuyor.
    // Ayrıca 'BarkodYaz' isimli abstract bir metot tanımlanmış. Abstract metodlar, türetilen sınıflar tarafından kesinlikle tanımlanmalıdır.

    abstract class Cihaz
    {
        public string Barkod { get; set; }

        public string BarkodGetir()
        {
            return "Barkod" + this.Barkod;
        }
        public abstract void BarkodYaz();
        public abstract  string Birlestir(string deger1, string deger2);
    }


    // 'Elektronik' sınıfı, 'Cihaz' sınıfından türetilmiştir ve bu sınıf 'Cihaz' sınıfının tüm özelliklerini ve metodlarını miras alır.
    // 'Elektronik' sınıfı ayrıca 'RAM' ve 'CPU' gibi kendine özgü özellikleri tanımlar.
    // 'BarkodYaz' metodu 'Cihaz' sınıfından override edilmiş (üzerine yazılmış) ve bu metod, 'BarkodGetir' metodunu kullanarak barkodu yazdırır.

    class Elektronik : Cihaz
    {
        public string RAM { get; set; }
        public string CPU { get; set; }

        public override void BarkodYaz()
        {
            Console.WriteLine(BarkodGetir());
        }

        public override string Birlestir(string deger1, string deger2)
        {
            return deger1 + deger2;
        }
    }
}


