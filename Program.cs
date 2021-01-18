using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("------------------");
            }

            Console.WriteLine("-----------Metotlar----------");
            
            // instance - örnek
            // encapsulation - kapsülleme - ayrı ayrı yazacağımız ve düzensiz olacak yapıyı, düzene sokmuş oluyoruz.

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            Console.WriteLine("------- Ekle2------");

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Armut", 15, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80, 7);

            Console.ReadLine();
        }
    }
}
