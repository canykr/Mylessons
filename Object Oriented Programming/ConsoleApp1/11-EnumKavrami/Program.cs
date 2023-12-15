namespace _11_EnumKavrami
{
    internal class Program
    {


        // 'enum' (enumeration), ilgili sabit değerler kümesini bir araya getiren ve bunlara anlamlı isimler atayan bir veri tipidir.
        // Kodun okunabilirliğini artırır ve sayısal değerler yerine sembolik isimler kullanarak hataları azaltmaya yardımcı olur.

        //Roller.
        static void Main(string[] args)
        {
            Console.WriteLine(Roller.Yonetici.ToString());
            Console.WriteLine((int)RollerYeni2.SonKullanici);

            Roller rol = Roller.Satici;
            if (rol == Roller.SonKullanici)
            {
                Console.WriteLine("Son kullanıcı");
            }
            else if (rol == Roller.Satici)
            {
                Console.WriteLine("Satıcı");
            }

            int[] degerler = (int[])Enum.GetValues(typeof(Roller));
            foreach (var item in degerler)
            {
                //Console.WriteLine(item);
                Console.WriteLine($"{Enum.GetName(typeof(Roller),item)} - {item}"); 
            }

            Console.WriteLine("-----------------------------------------");

            string[] isimler = Enum.GetNames(typeof(Roller));
            foreach(var item in isimler)
            {
                //Console.WriteLine(item);
             
            }

            Console.WriteLine("-----------------------------------------");

        }
    }

    enum Roller
    {
        Yonetici,
        SonKullanici,
        Satici
    }

    enum RollerYeni
    {
        Yonetici = 10,
        SonKullanici = 5,
        Satici = 30
    }

    enum RollerYeni2
    {
        Yonetici = 10,
        SonKullanici = 15,
        Satici,
        Alici
    }
}