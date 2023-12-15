using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikOrnegi
{

    public enum KartTuru
    {
        Visa,
        Master
    }

    public enum HesapTuru
    {
        TL,
        USD,
        EURO,
        AUX
    }

    public interface IKartIslemleri
    {
        void ParaCek(decimal tutar);
        void ParaYatirma(decimal tutar);
    }

    public abstract class Kart : IKartIslemleri
    {
        public string BankaAdi { get; set; }
        public string KartAdi { get; set; }
        public KartTuru KartTuru { get; set; }
        public string CVVKodu { get; set; }

        public abstract void ParaCek(decimal tutar);
        public abstract void ParaYatirma(decimal tutar);
    }

    public sealed class BankamatikKart : Kart
    {
        public HesapTuru HesapTuru { get; set; }
        public decimal Bakiye { get; private set; }

        public override void ParaCek(decimal tutar)
        {
            Console.WriteLine($"{tutar} tutarında para çekildi. Kalan bakiye: {Bakiye - tutar}");
        }

        public override void ParaYatirma(decimal tutar)
        {
            Console.WriteLine($"{tutar} tutarında para yatırıldı. Yeni bakiye: {Bakiye + tutar}");
        }
    }

    public class KrediKarti : Kart
    {
        public decimal Borc { get; private set; }

        public override void ParaCek(decimal tutar)
        {
            Console.WriteLine($"Kredi kartından {tutar} tutarında para çekildi. Borç: {Borc + tutar}");
        }

        public override void ParaYatirma(decimal tutar)
        {
            Console.WriteLine($"Kredi kartına {tutar} tutarında para yatırıldı. Borç: {Borc - tutar}");
        }

        public void BorcOde(decimal tutar)
        {
            Borc -= tutar;
            Console.WriteLine($"Borç ödendi. Kalan borç: {Borc}");
        }
    }

    public class PlatinumKart : KrediKarti
    {
        public bool ClubUyeligiVarMi { get; set; }
        public DateTime UyelikBaslangicTarihi { get; set; }
        public DateTime UyelikBitisTarihi { get; set; }
        public int KazanilanPuan { get; set; }

        public void UyeligiYenile()
        {
            
        }

        public void UyeligiBitir()
        {
            
        }
       
    }

    public sealed class GoldKart : KrediKarti
    {
        public bool IndirimOzelligiVarMi { get; set; }
        public DateTime KampanyaBaslangicTarihi { get; set; }
        public DateTime KampanyaBitisTarihi { get; set; }

        public void KampanyaTanımla()
        {
            
        }
    }

    public sealed class SilverKart : KrediKarti
    {
        public bool KisitlamaVarMi { get; set; }
        public DateTime SonKullanımTarihi { get; set; }

        public void KisitlamaTanımla()
        {
            
        }
    }
}
