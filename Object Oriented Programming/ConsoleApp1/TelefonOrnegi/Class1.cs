using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonOrnegi
{
    // Inheritance (Kalıtım) = Miras alma işlemi
    // bir class sadece bir tane class'ı miras alabilir. 

    // Cihaz isimli bir temel sınıf tanımlanmıştır.
    public class Cihaz
    {
        // Her cihazın ortak özelliği olan Barkod tanımlanmıştır.
        public string Barkod { get; set; }

        // Barkod bilgisini string olarak döndüren BarkodYaz metodudur.
        public string BarkodYaz()
        {
            return "Barkod =" + Barkod;
        }

        //PROTECTEC METODU
        //bu metoda sadece miras alan class üzerinden erişilebilir. protected veya protected internal olarak kullanılabilir. 
        // 'protected' erişim belirleyicisi, bir üyenin yalnızca tanımlandığı sınıf içinde ve o sınıftan türeyen sınıflar içinde erişilebilir olduğunu belirtir.
        // 'protected internal' erişim belirleyicisi, üyenin tanımlandığı projenin içinde ve ayrıca türetilmiş sınıflarda (farklı projelerde bile) erişilebilir olduğunu belirtir.

        protected void Yaz(string mesaj)
        {
            Console.WriteLine(mesaj);
        }

        public Cihaz (string barkod,string SeriNo)
        {
            this.Barkod= barkod;
        }

        // Elektronik, Cihaz sınıfından türemiştir ve Cihaz'ın özelliklerini miras alır.
        // Elektronik cihazlar için CPU ve RAM gibi özellikler eklenmiştir.
        public class Elektronik : Cihaz
        {
            public Elektronik (string barkod, string SeriNo) : base(barkod, SeriNo)
            {
            }
         
            public string CPU { get; set; }
            public string RAM { get; set; }

            //protected kısmına baglı
            public void SatinAl()
            {
                base.Yaz("asdkaskd");
            }
        }

        // Telefon sınıfı Elektronik sınıfından türemiştir, dolayısıyla Cihaz sınıfının
        // özelliklerini de miras alır ve ek olarak Renk özelliği ile Aramayap metodunu içerir.
        public class Telefon : Elektronik
        {
            public Telefon(string barkod, string SeriNo) : base(barkod, SeriNo)
            {
            }

            public string Renk { get; set; }

            // Telefonun arama yapmasını sağlayan metod.
            public void Aramayap()
            {
                Console.WriteLine("Arama Yapıldı");
            }
        }

        // Monitor sınıfı da Cihaz sınıfından türemiştir fakat şu an için ekstra bir özellik
        // veya metod tanımlamamıştır. Bu sınıf Cihaz'ın özelliklerini kullanabilir.
        public class Monitor : Cihaz
        {

            // Şu anda Monitor sınıfına özgü ekstra bir özellik veya metod tanımlanmamıştır.
            public Monitor(string barkod, string SeriNo) : base(barkod, SeriNo)
            {
            }
        }
    }
}
