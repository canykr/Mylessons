namespace _06_AbstractClassVeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AbstractClass Mülakatlarda sorulur sealed class'ın tersidir.Newlenemez.
            // 'abstract' sınıf, başka sınıfların türetilebileceği bir temel sınıf tanımlar fakat kendisi örneklendirilemez.
            // İçinde tamamlanmamış (abstract) metodlar barındırabilir ve bu metodlar türetilen sınıflarca tanımlanmalıdır.
            // Böylece, belirli bir temel işlevsellik seti sağlarken, detayların alt sınıflar tarafından belirlenmesini zorunlu kılar.
            // Geri değer döndüren ve döndürmeyen kısmını çalıi.
            //Cihaz cihaz = new Cihaz();
            Elektronik elektronik = new Elektronik();
            elektronik.Barkod = "123456789";
            elektronik.RAM = "16GB";
            elektronik.CPU = "Intel i7";

            Console.WriteLine(elektronik.BarkodGetir());
            Console.WriteLine("RAM: " + elektronik.RAM);
            Console.WriteLine("CPU: " + elektronik.CPU);

            elektronik.BarkodYaz();
        }
    }
}
