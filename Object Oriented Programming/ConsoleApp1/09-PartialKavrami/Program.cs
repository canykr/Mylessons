namespace _09_PartialKavrami
{
    internal class Program
    {
        // 'partial' anahtar sözcüğü, bir sınıfın, struct'ın veya interfacenin tanımının birden fazla dosyada bölünmesine olanak tanır.
        // Bu, büyük ve karmaşık sınıfları yönetmek, kod organizasyonunu iyileştirmek ve birden fazla geliştiricinin aynı sınıf üzerinde eş zamanlı çalışabilmesi için kullanışlıdır.
        // Tüm 'partial' tanımları aynı isim alanı (namespace) ve derleme ünitesinde (assembly) bulunmalıdır ve birleştirildiğinde tam bir sınıf tanımını oluşturur.

        static void Main(string[] args)
        {
            Koordinat koordinat = new Koordinat();  
            koordinat.X = 12;
            koordinat.Y = 50;
            koordinat.KoordinatYaz();
        }
    }

    partial class Koordinat
    {
        public int X { get; set; }
        public int Y { get; set; }
    }


    partial class Koordinat
    {
        public void KoordinatYaz()
        {
            Console.WriteLine($"x={this.X};Y={Y}");
        }
    }

    partial interface IKoordinat
    {
        void KoordinatOku(int x, int y);
    }

    partial interface IKoordinat
    {
        void KoordinatYaz();
    }

    //************************************************************************************
     // '{ get; set; }' ifadeleri, C# programlamada özellikler (properties) için kullanılır ve kapsülleme (encapsulation) sağlar.
    // 'get' aksesi özelliğin değerini okumak için, 'set' aksesi ise özelliğin değerini atamak için kullanılır.
    // Bu yöntem, bir sınıfın iç durumunu (fields) doğrudan erişimden korurken, dışarıya güvenli bir erişim noktası sunar.



}
