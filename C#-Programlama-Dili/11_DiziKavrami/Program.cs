namespace _11_DiziKavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizinin elemen sayısını belirterek içi boş olacak şekilde oluşturmak için kullanılır.
            int[] rakamlar = new int[5];
            string[] isimler = new string[6];

            //Dizinin bir elemanına değer atama
            rakamlar[0] = 5;
            rakamlar[3] = 10;

            //Dizinin x indekxine sahip elemanın değerini verir
            // isimler[0]
            Console.WriteLine(rakamlar[0]);
            Console.WriteLine(rakamlar[1]);

            isimler[0] = "Aykut";
            isimler[1] = "Savaş";

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[4]);
            // debug moddayken f10

            // dizinin hem eleman sayısını, hem de elemanlarına değer ataması yaparak dizi oluşturma

            string[] arabalar = new string[3] {"Volvo","BMW","Ford"};
            Console.WriteLine(arabalar[1]);

            // dizinin eleman sayısını belirtmeden eleman ataması yaparak eleman sayısını belirleyerek oluşturma
            string[] renkler = new string[] { "Kırmızı", "Beyaz" };
            string[] renkler2 = new string[] { "Kırmızı", "Beyaz" };
            /*
            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i]);
            }
             */

            // hata verir 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arabalar[i]);
            }
           



        }

    }
}
