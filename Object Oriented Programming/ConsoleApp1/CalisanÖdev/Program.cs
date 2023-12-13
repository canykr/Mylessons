namespace CalisanÖdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yazilimci yazilimci = new Yazilimci();
            yazilimci.KimlikNo = 1;
            yazilimci.AdiSoyadi = "Can Yakar";
            yazilimci.Maas = 5000;
            yazilimci.Meslek = "Yazılımcı";
            yazilimci.BackEndMi = true;
            yazilimci.FrontEndMi = false;
            yazilimci.Seviyesi = "Mid";

            TakimLideri takimLideri = new TakimLideri();
            takimLideri.KimlikNo = 2;
            takimLideri.AdiSoyadi = "Ayşe Yılmaz";
            takimLideri.Maas = 7000;
            takimLideri.Meslek = "Takım Lideri";
            takimLideri.EkibindekiYazilimciSayisi = 5;

            ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi();
            projeYoneticisi.KimlikNo = 3;
            projeYoneticisi.AdiSoyadi = "Mehmet Öz";
            projeYoneticisi.Maas = 9000;
            projeYoneticisi.Meslek = "Proje Yöneticisi";

            yazilimci.IseGit();
            yazilimci.KodYaz();
            yazilimci.TestEt();

            takimLideri.IseGit();
            takimLideri.Denetle();
            takimLideri.IzinleriOnayla();

            projeYoneticisi.IseGit();
            projeYoneticisi.MusteriIleGorus();
        }

    }
}

