using System.Collections;

namespace _13_DiziMetotlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Building metotları

            //GetValue() metodu ile dizinin içindeki değerini almak istediğimiz index verisi ile elemana erişmek için kullanırız. 

            string[] aylar = { "Ocak", "Şubat", "Mart", "Nisan", "Mayıs" };

            string ay1 = aylar[0];
            string ay2 = aylar.GetValue(0).ToString();
            object ay3 = aylar.GetValue(1);

            int[] intDizisi = { 40, 50, 60, 70 };
            int deger1 = Convert.ToInt32(intDizisi.GetValue(2));
            string deger2 = intDizisi.GetValue(2).ToString();

            //SetValue() Elimizdeki bir indexe istinaden, dizinin elemanına değer ataması yapmak için kullanılır.

            aylar.SetValue("Aralık", 4);

            //Array.IndexOf() metodu dizinin içindeki bir elemanın index numarasını almak için kullanırız.
            //ÖNEMLİ NOT : Aramak istediğimiz değer, dizinin içerisinde birden fazla ise ilk elemanın indexini döner..

            int indexNo = Array.IndexOf(aylar, "Mart");

            //Dizinin içerisinde kaç tane eleman olduğunu bize döner
            int elemanSayisi = aylar.Length;

            //Sort() metodu ile dizinin içindeki elemanları sıralayabiliriz.
            //eğer elemanlar sayısal bir değere sahipse küçükten büyüğe doğru sıralama yapar.
            //eğer string bir değer ise A'dan Z'ye doğru sıralama yapar.
            Console.WriteLine("Normal hali");

            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }
            Array.Sort(aylar);
            Console.WriteLine("Sort metodu ile sıralanmıs hali");
            foreach (string ay in aylar)
            {
                Console.WriteLine(ay);
            }

            int[] sayilar = { 1, 6, 4, 3, 9, 0 };
            Array.Sort(sayilar);
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi);


            //Array.Reverse() metodu ile dizinin içindeki elemanları tersten sıralayabiliriz. büyükten küçüğe ya da Z'den A'ya. (Reverse Sort kullanmadan çalışmaz.)
            Array.Sort(sayilar);
            Array.Reverse(sayilar);

            int[] sayilar2 = { 1, 6, 4, 3, 9, 0 };
            Array.Sort(sayilar2);
            Array.Reverse(sayilar2);

            //Array.Clear() metodu ile dizi içindeki elemanları silebiliriz.
            // ÖNEMLİ NOT : Silmek eleman sayısını silmek değil, silme yaptığımızda eleman sayısı aynı şekilde kalır sadece değerleri silinir.

            //Array.Clear(sayilar2);
            //Array.Clear(aylar);
            //Array.Clear(sayilar2, 2, 2);

            //Clone() metodu bir dizinin kopyasını oluşturur.
            string[] renkler = { "Kırmızı", "Beyaz", "Yeşil", "Mor" };
            string[] renklerClone = (string[])renkler.Clone();
            foreach (var renk in renklerClone)
                Console.WriteLine(renk);

            Array.Clear(renkler);

            Console.Clear();
            //Array.Copy()
            string[] renklerYeni = new string[4];
            Array.Copy(renkler, 1, renklerYeni, 0, 2);

            foreach (var item in renkler)
            { 
                int index=Array.IndexOf(renkler, item);
                Console.WriteLine(index +". Eleman=" + item);
            }

            Console.WriteLine("-------------");
            foreach (var item in renklerYeni)
            {
                int index = Array.IndexOf(renklerYeni, item);
                Console.WriteLine(index + ". Eleman=" + item);
            }

            Console.Clear();
            // Array.Resize() metodu ile dizinin eleman sayısını değiştirebiliriz.
            string[] gunler = { "Pazartesi", "Salı", "Çarşamba" };
            foreach (var gun in gunler)
            {
                Console.WriteLine(gun);
            }

            Console.WriteLine("-----------------");
            Array.Resize(ref gunler, 5);
            gunler[4] = "Cuma";
            foreach (var gun in gunler)
            {
                Console.WriteLine(gun);
            }

            Console.Clear();
            // ArrayList dinamik olarak büyüyüp küçülebilen, farklı değişken tiplerinde değerleri saklayabilen koleksiyon tabanlı bir sınıftır.
            //diziler ve arraylist arasındaki farklar 
            // 1- Dizilerin boyutunu oluştururken belirtmek zorundayız, Arraylist sınıfında belirtmeden oluşturup istediğimiz kadar ekleme çıkartma yaparak boyutunu değiştirebiliriz.
            // 2- Dizilerin tipi baştan belirlenir  ve sadece o tipte değer alır, Arraylist sınıfında istediğimiz tipte değer ataması yapabiliriz.

            ArrayList arrayList = new ArrayList();
            arrayList.Add(6);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(2);
            //arrayList.Add("elma");
            arrayList[2]= 1;
            //arrayList[1] = "ahmet";
            arrayList.Sort();//a'dan z'ye sıralama yapar, kücükten büyüge sıralama yapar
            arrayList.Reverse();// sıralamayı tersine çevirir öncesinde sort metodu kullanılmak zorunda
            arrayList.Remove(2); // belirtilen elemanı kaldırır ve eleman sayısıda düşer.
            arrayList.RemoveAt(0);// index numarası ile eleman siler

            Console.WriteLine("Eleman sayısı=" + arrayList.Count);
            arrayList.Clear();
            Console.WriteLine("Eleman sayısı=" + arrayList.Count);

            foreach (var array in arrayList)
            {
                Console.WriteLine(array);
            }

            // en az 5 tane bugüne kadar işlediğimiz konularla ilgili örnekler bulup yapıp göndersin
        }
    }
}
