namespace BankamatikOrnegi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankamatikKart bankamatikKart = new BankamatikKart();

            bankamatikKart.BankaAdi = "İng";
            bankamatikKart.KartAdi = "Bankamatik Kartı";
            bankamatikKart.KartTuru = KartTuru.Master;
            bankamatikKart.ParaCek(100);

            PlatinumKart platinumKart = new PlatinumKart();

            platinumKart.BankaAdi = "Banka A";
            platinumKart.KartAdi = "Platinum Kart";
            platinumKart.KartTuru = KartTuru.Visa;
            platinumKart.ClubUyeligiVarMi = true;
            platinumKart.UyelikBaslangicTarihi = DateTime.Now;
            platinumKart.UyelikBitisTarihi = DateTime.Now.AddYears(1);
            platinumKart.BorcOde(200);



            GoldKart goldKart = new GoldKart();

            goldKart.BankaAdi = "Banka B";
            goldKart.KartAdi = "Gold Kart";
            goldKart.KartTuru = KartTuru.Master;
            goldKart.IndirimOzelligiVarMi = true;
            goldKart.KampanyaTanımla();

            SilverKart silverKart = new SilverKart();

            silverKart.BankaAdi = "Banka C";
            silverKart.KartAdi = "Silver Kart";
            silverKart.KartTuru = KartTuru.Visa;
            silverKart.KisitlamaVarMi = false;
            silverKart.KisitlamaTanımla();


        }
    }
}
