using static _08_InterfaceClass.Koordinatör;

namespace _08_InterfaceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            personel.Adi = " Can";
            personel.Soyadi = "Yakar";
            personel.GorevAtama();
            personel.GorevTamamla();

            Koordinator koordinatör = new Koordinator();
            koordinatör.Adi = "Hasan";
            koordinatör.Soyadi = "Can";
            koordinatör.GorevAtama();
            koordinatör.GorevTamamla();
            koordinatör.ToplantiPlanla();
            koordinatör.ToplantiYap();

            Mudur mudur = new Mudur();  
            mudur.Adi = "Hasan";
            mudur.Soyadi = "Can";
            mudur.ToplantiYap();


            Asistan asistan = new Asistan ();
            asistan.Adi = "Emel";
            asistan.Soyadi = "Sayin";
            asistan.ToplantiPlanla();
        }
    }
}
