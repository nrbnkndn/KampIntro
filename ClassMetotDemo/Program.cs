using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.musteriAdi = "hüsamettin";
            musteri1.musteriSoyadi = "cindoruk";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.musteriAdi = "abdülrezzak";
            musteri2.musteriSoyadi = "yerebatan";

            List<Musteri> musteriler = new List<Musteri> { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.SecimEkraniGoster();
            int secimId = Convert.ToInt32(Console.ReadLine());
            while (secimId < 4) 
            {
                if (secimId == 1)
                {
                    Musteri musteriX = new Musteri();
                    Console.WriteLine("Eklemek istediğiniz müşterinin IDsini giriniz:");
                    musteriX.Id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Eklemek istediğiniz müşterinin adını giriniz:");
                    musteriX.musteriAdi = Console.ReadLine();

                    Console.WriteLine("Eklemek istediğiniz müşterinin soyadını giriniz:");
                    musteriX.musteriSoyadi = Console.ReadLine();

                    musteriManager.MusteriEkle(musteriX, musteriler);

                    musteriManager.SecimEkraniGoster();
                    secimId = Convert.ToInt32(Console.ReadLine());

                    musteriManager.SecimEkraniGoster();
                    secimId = Convert.ToInt32(Console.ReadLine());
                }
                if (secimId == 2)
                {
                    musteriManager.MusteriListele(musteriler);

                    musteriManager.SecimEkraniGoster();
                    secimId = Convert.ToInt32(Console.ReadLine());

                    
                }
                if (secimId == 3)
                {
                    musteriManager.MusteriListele(musteriler);
                    Console.WriteLine("Silinecek müşteri idsi: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    musteriManager.MusteriSil(id, musteriler);
                    musteriManager.SecimEkraniGoster();
                    secimId = Convert.ToInt32(Console.ReadLine());

                }
                else
                {
                    break;
                }

            }

        }
    }
}
