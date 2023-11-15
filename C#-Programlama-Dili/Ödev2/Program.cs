namespace Ödev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Müşteri Bilgileri

            string musteriAdiSoyadi = "Can Yakar";
            string musteriTelefon = "05447778899";
            string musteriAdres = "Karabağlar İzmir";
            decimal musteriToplamBorc = 320.30m;
            decimal musteriToplamAlacak = 110.00m;

            // Ürün Bilgileri 

            string urunAdi = "Süt";
            string urunKodu = "ST001";
            decimal urunBirimFiyati = 4.50m;
            int urunStokMiktari = 50;
            string urunOlcuBirimi = "litre";

            // Müşteri Hareketleri

            DateTime hareketIslemTarihi = new DateTime(2023, 11, 15);
            string hareketUrunAdi = "Süt";
            decimal hareketBirimFiyati = 4.50m;
            int hareketMiktari = 5;
            decimal hareketTutari = hareketMiktari * hareketBirimFiyati;
            decimal hareketKalanAlacakTutari = musteriToplamBorc - hareketTutari;

            Console.WriteLine("Müşteri Bilgileri:");
            Console.WriteLine($"Adı Soyadı: {musteriAdiSoyadi}");
            Console.WriteLine($"Telefon: {musteriTelefon}");
            Console.WriteLine($"Adres: {musteriAdres}");
            Console.WriteLine($"Toplam Borç: {musteriToplamBorc}"); 
            Console.WriteLine($"Toplam Alacak: {musteriToplamAlacak}\n"); 

            Console.WriteLine("Ürün Bilgileri:");
            Console.WriteLine($"Ürün Adı: {urunAdi}");
            Console.WriteLine($"Ürün Kodu: {urunKodu}");
            Console.WriteLine($"Birim Fiyatı: {urunBirimFiyati}"); 
            Console.WriteLine($"Stok Miktarı: {urunStokMiktari}");
            Console.WriteLine($"Ölçü Birimi: {urunOlcuBirimi}\n");

            Console.WriteLine("Müşteri Hareketleri:");
            Console.WriteLine($"İşlem Tarihi: {hareketIslemTarihi:dd/MM/yyyy}");
            Console.WriteLine($"Ürün Adı: {hareketUrunAdi}");
            Console.WriteLine($"Birim Fiyatı: {hareketBirimFiyati}"); 
            Console.WriteLine($"Miktarı: {hareketMiktari}");
            Console.WriteLine($"Tutarı: {hareketTutari}"); 
            Console.WriteLine($"Kalan Alacak Tutarı: {hareketKalanAlacakTutari}");

            Console.ReadKey();




        }
    }
}