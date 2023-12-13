using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanÖdev
{
    public class Calisan
    {
        public int KimlikNo { get; set; }
        public string AdiSoyadi { get; set; }
        public double Maas { get; set; }
        public string Meslek { get; set; }

        public void IseGit()
        {
            
        }

        public void MolaYap()
        {
            
        }
    }

    public class Yazilimci : Calisan
    {
        public bool BackEndMi { get; set; }
        public bool FrontEndMi { get; set; }
        public string Seviyesi { get; set; } 

        public void KodYaz()
        {
            
        }

        public void TestEt()
        {
            
        }
    }

   
    public class TakimLideri : Calisan
    {
        public int EkibindekiYazilimciSayisi { get; set; }

        public void TestEt()
        {
            
        }

        public void Denetle()
        {
            
        }

        public void IzinleriOnayla()
        {
            
        }
    }

    public class ProjeYoneticisi : Calisan
    {
        public void Denetle()
        {
            
        }

        public void IzinleriOnayla()
        {
            
        }

        public void MusteriIleGorus()
        {
           
        }
    }
}
