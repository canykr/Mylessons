using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders08122023
{
    internal class Sirket
    {

        public string Adi { get; set; } = "canykr";
        public string Adres { get; set; }


        private int _PostaKodu;

        public int PostaKodu
        {
            get { return _PostaKodu; }
            set { _PostaKodu = value; }
        }

        //public int GetPostaKodu()
        //{
        //    return _PostaKodu;
        //}

        //public void SetPostaKodu(int value)
        //{
        //    _PostaKodu = value;
        //}


        //encapsulation

        class Kare
        {
            private int _KenarUzunlugu;

            public int KenarUzunlugu
            {
                get
                {
                    return _KenarUzunlugu;
                }
                set
                {
                    if (value > 100)
                        value = 100;
                    _KenarUzunlugu = value;
                }

                //encapsulation
                //    Console.WriteLine("Encapsulation, nesne yönelimli programlamanın temel prensiplerinden biridir ve veri saklama (data hiding) olarak da bilinir. Encapsulation, bir nesnenin iç detaylarını, yani veri üyelerini (fields) ve bazı metodları dış dünyadan saklamak anlamına gelir. Bunun yerine, nesnenin dışarıya sadece belirli işlevsellikleri ve veri erişim yöntemlerini sunarak, nesnenin geri kalan kısmını gizler. Bu, nesnenin nasıl kullanılacağına dair bir arayüz sağlarken, uygulamanın iç işleyiş detaylarını korur.\r\n\r\nEncapsulation'ın avantajları şunlardır:\r\n\r\nGüvenlik: Sınıfın iç verileri doğrudan erişime kapalıdır, bu nedenle yanlış kullanımı veya dış müdahaleyi önler.\r\nEsneklik ve Sürdürülebilirlik: Sınıfın iç yapısını değiştirmek, dış arayüzü etkilemeden yapılabilir, bu da kodun bakımını ve güncellenmesini kolaylaştırır.\r\nKontrol: Bir sınıfın geliştiricisi, verilere erişimi ve değiştirilmesini kontrol edebilir. Örneğin, bir özelliğin (property) set metodunu kullanarak, atanan değerin belirli bir aralıkta olmasını sağlayabilirsiniz.\r\nBasitleştirme: Kullanıcılar yalnızca bir nesnenin dış arayüzünü bilmek zorundadır, bu da nesneyle etkileşim kurmayı basitleştirir.\r\nEncapsulation genellikle özellikler (properties) ve erişim belirleyicileri (access modifiers) kullanılarak uygulanır. Örneğin, public, private, protected ve internal C#'ta kullanılan erişim belirleyicileridir. Aşağıda basit bir encapsulation örneği verilmiştir:");

                //    public class Ogrenci
                //{
                //    private int yas; // Private field, dışarıdan erişilemez

                //    public int Yas // Public property, dışarıya açık
                //    {
                //        get { return yas; }
                //        set
                //        {
                //            if (value >= 0) // Yas değeri sıfır veya daha büyük olmalı
                //            {
                //                yas = value;
                //            }
                //        }


                //        Console.WriteLine("Bu örnekte, yas alanı private olarak tanımlanmış ve doğrudan dışarıdan erişime kapalıdır. Ancak Yas özelliği üzerinden kontrollü bir şekilde erişim sağlanabilir. Bu, Ogrenci nesnesinin yas alanının yanlış değerlere ayarlanmasını önler ve nesnenin durumunu korur.");
                //    }
                //}










            }

        }
    }
}
