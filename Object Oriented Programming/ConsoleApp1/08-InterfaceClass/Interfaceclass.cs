using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace _08_InterfaceClass
{
    public abstract class Calisan
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }

    public interface IGorev
    {
        void GorevAtama();
        void GorevTamamla();
    }

    public interface IToplanti
    {
        void ToplantiYap();
    }

    public interface IPlanlama
    {
        void ToplantiPlanla();
    }

    public class Personel : Calisan, IGorev
    {
        public void GorevAtama()
        {
            Console.WriteLine($"Personel Görev Ata ={Adi} {Soyadi}");
        }

        public void GorevTamamla()
        {
            Console.WriteLine($"Personel Görev Tamamla ={Adi} {Soyadi}");
        }
    }

    public class Koordinator : Calisan, IGorev, IToplanti
    {
        public void GorevAtama()
        {
            Console.WriteLine($"Koordinator Görev Ata ={Adi} {Soyadi}");
        }

        public void GorevTamamla()
        {
            Console.WriteLine($"Koordinator Görev Tamamla ={Adi} {Soyadi}");
        }
        public void ToplantiPlanla()
        {
            Console.WriteLine($"Koordinator Toplanti Planla ={Adi} {Soyadi}");
        }
        public void ToplantiYap()
        {
            Console.WriteLine($"Koordinator Toplanti Yap ={Adi} {Soyadi}");
        }
    }

    public class Mudur : Calisan, IToplanti
    {
        public void ToplantiYap()
        {
            Console.WriteLine($"Mudur Toplanti Yap ={Adi} {Soyadi}");
        }
    }

    public class Asistan : Calisan, IPlanlama
    {
        public void ToplantiPlanla()
        {
            Console.WriteLine($"Asistan Toplanti Planla = {Adi} {Soyadi}");
        }

    }
}