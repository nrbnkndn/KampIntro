using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void SecimEkraniGoster()
        {
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz:" +
                "\n 1)Müşteri Ekle" +
                "\n 2)Müşterileri Listele" +
                "\n 3)MüşteriSil" +
                "\n 4)Çıkış Yap");

        }
        public  void MusteriEkle(Musteri musteriX, List<Musteri> musteriler)
        {
            MusteriListele(musteriler);
            musteriler.Add(musteriX);
            MusteriListele(musteriler);
        }
        public  void MusteriListele(List<Musteri> musteriler)
        {
            Console.WriteLine("Güncel Müşteri Listesi: ");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.musteriAdi
                    + " " + musteri.musteriSoyadi);
            }
        }
        public  void MusteriSil(int Id, List<Musteri> musteriler)
        {
            musteriler.RemoveAt(Id -1);
            Console.WriteLine("Müşteri Silindi. Güncel müşteri listesi: ");
            MusteriListele( musteriler);
        }

    }
}
