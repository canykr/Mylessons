using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_VirtualMethods
{

    public class Cihaz
    {
        // 'override' anahtar sözcüğü, türetilmiş bir sınıfta, temel sınıftan miras alınan ve 'virtual' ya da 'abstract' olarak işaretlenmiş bir metodun yeni bir implementasyonunu sağlamak için kullanılır.
        // 'abstract' metotlar, bir temel sınıfta tanımlanır ve gövdesizdir; türetilen sınıfların bu metotları kesinlikle uygulamasını zorunlu kılar.
        // 'virtual' metotlar, bir temel sınıfta tanımlanır ve varsayılan bir gövdeye sahiptir; türetilen sınıflar bu metotları gerektiğinde 'override' edebilir.

        public string Barkod { get; set; }

        public string BarkodGetir()
        {
            return "Barkod=" + this.Barkod;
        }

        // Kod bloğu olan fakat istenirse miras alınan sınıflar üzerinden override komutu ile yeniden kod bloğu oluşturulabilir
        // Miras alınan sınıfta override edilme zorunluluğu yoktur
        public virtual void BarkodYaz()
        {
            Console.WriteLine("base sınıftan geldi = " + BarkodGetir());
        }

        public virtual string Birlestir(string deger1, string deger2)
        {
            return "base sınıftan geldi = " + deger1 + deger2;
        }
    }

    public class Elektronik : Cihaz
    {
        public string CPU { get; set; }
        public string RAM { get; set; }

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