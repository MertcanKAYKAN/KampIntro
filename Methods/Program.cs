using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Karpuz";
            urun1.Fiyati = 80;
            urun1.Aciklama = "Diyarbakır Karpuzu";
            urun1.stokAdedi = 900;
            urun1.ithalYeri = "Diyarbakır";

            Urun urun2 = new Urun();
            urun2.Adi = "Elma";
            urun2.Fiyati = 15;
            urun2.Aciklama = "Amasya elması";
            urun2.stokAdedi = 500;
            urun2.ithalYeri = "Amasya";

            Urun[] urunler = new Urun[] {urun1,urun2 };
            //type-safe - - tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine(urun.ithalYeri);
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("---------Metodlar----------");
            
            //örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 500);
        }
    }
}
    
//Don't repeat yourself - DRY - Clean Code - Best Practice
