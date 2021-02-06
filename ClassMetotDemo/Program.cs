using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Tansu";
            musteri1.Soyad = "Tekin";
            musteri1.Yas = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Nehir";
            musteri2.Soyad = "Tekin";
            musteri2.Yas = 16;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Hande";
            musteri3.Soyad = "Yılmaz";
            musteri3.Yas = 23;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Nesrin";
            musteri4.Soyad = "Civelek";
            musteri4.Yas = 23;

            MusteriManager musteriManager = new MusteriManager();
            
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
           
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}
