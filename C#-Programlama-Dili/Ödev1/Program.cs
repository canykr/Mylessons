namespace Ödev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci Bilgileri

            string ogrenciAdSoyad = "Can Yakar";
            DateTime ogrenciKayitTarihi = new DateTime(2023, 10, 1);
            string ogrenciSinif = "12-A";
            double ogrenciNotOrtalamasi = 92.3;

            // Veli Bilgileri

            string veliAdSoyad = "Hicran Yakar";
            string veliTelefon = "05331112233";
            string veliEvAdresi = "Esenlik Mah. Mızraklı Caddesi ";
            string veliIsAdresi = "Karabağlar İzmir";
            bool veliAnnesiMi = true; // Anne

            // Ders Bilgileri 

            string dersAdi = "Bilişim Teknolojileri";
            bool dersSayisalMi = false;

            // Ders Notları 

            string dersNotlariOgrenciAdi = "Can Yakar";
            string dersNotlariDersAdi = "Bilişim Teknolojileri";
            int dersNotlariSinavNotu1 = 94;
            int dersNotlariSinavNotu2 = 89;
            double dersNotlariNotOrtalamasi = (dersNotlariSinavNotu1 + dersNotlariSinavNotu2) / 2.0;



            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine($"Adı Soyadı: {ogrenciAdSoyad}");
            Console.WriteLine($"Kayıt Tarihi: {ogrenciKayitTarihi:dd/MM/yyyy}");
            Console.WriteLine($"Sınıf: {ogrenciSinif}");
            Console.WriteLine($"Not Ortalaması: {ogrenciNotOrtalamasi}"); 

            Console.WriteLine("\nVeli Bilgileri:");
            Console.WriteLine($"Adı Soyadı: {veliAdSoyad}");
            Console.WriteLine($"Telefon: {veliTelefon}");
            Console.WriteLine($"Ev Adresi: {veliEvAdresi}");
            Console.WriteLine($"İş Adresi: {veliIsAdresi}");
            Console.WriteLine($"Anne mi: {(veliAnnesiMi ? "Evet" : "Hayır")}");

            Console.WriteLine("\nDers Bilgileri:");
            Console.WriteLine($"Ders Adı: {dersAdi}");
            Console.WriteLine($"Sayısal mı: {(dersSayisalMi ? "Evet" : "Hayır")}");

            Console.WriteLine("\nDers Notları:");
            Console.WriteLine($"Öğrenci Adı: {dersNotlariOgrenciAdi}");
            Console.WriteLine($"Ders Adı: {dersNotlariDersAdi}");
            Console.WriteLine($"1. Sınav Notu: {dersNotlariSinavNotu1}");
            Console.WriteLine($"2. Sınav Notu: {dersNotlariSinavNotu2}");
            Console.WriteLine($"Not Ortalaması: {dersNotlariNotOrtalamasi}"); 

            Console.ReadKey();


        }
    }
}