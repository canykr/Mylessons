namespace _10_Enc_Ihn_Poly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Kare
    {
        //Bu kelimelerin anlamları önemli mülakatlarda karşımıza çıkabilir.
         
        //encapsulation (kapsülleme)
        // 'Encapsulation' veya kapsülleme, bir nesnenin iç durumunu (fields) ve uygulama detaylarını gizleyerek ve dış erişime yalnızca kontrollü bir arayüz (methods ve properties) sunarak veri güvenliğini ve nesne bütünlüğünü sağlar.
        // Bu, nesneler arası etkileşimi sınırlandırır ve kodun modülerliğini, esnekliğini ve bakım kolaylığını artırır.

        // 'Inheritance' (Kalıtım veya Miras Alma), bir sınıfın (alt sınıf) başka bir sınıfın (üst sınıf) özelliklerini ve metodlarını devralmasını sağlar.
        // Bu, kodun tekrar kullanılabilirliğini artırır ve ilişkili sınıflar arasında bir hiyerarşi oluşturarak nesne yönelimli programlamada düzen ve hiyerarşi sağlar.

        // 'Polymorphism' (Çok biçimlilik), nesnelerin farklı sınıf türlerine ait olmalarına rağmen aynı arayüzü kullanmalarına olanak tanıyan bir OOP prensibidir.
        // Bu, metodların override edilmesi veya interfaceler aracılığıyla farklı şekillerde uygulanabilmesini sağlar ve kodun daha genel ve esnek olmasına katkıda bulunur.


        private int _KenarA;
        public int KenarA
        {
            get { return _KenarA; }
            set { _KenarA = value; }
        }

        //public int GetKenarA()
        //{
        //    return _KenarA;
        //}
    }

}
