using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Ürün ürün1 = new Ürün();
            ürün1.ÜrünAdi = "Etek";
            ürün1.Aciklama = "Mini etek";
            ürün1.Fiyati = 25;

            Ürün ürün2 = new Ürün();
            ürün2.ÜrünAdi = "Pantolon";
            ürün2.Aciklama = "İspanyol paça";
            ürün2.Fiyati = 35;

            Ürün ürün3 = new Ürün();
            ürün3.ÜrünAdi = "Elbise";
            ürün3.Aciklama = "Puantiyeli";
            ürün3.Fiyati = 45;

            Ürün[] ürünler = new Ürün[] { ürün1, ürün2, ürün3 };

            for (int i = 0; i < ürünler.Length; i++)
            {
                Console.WriteLine(ürünler[i].ÜrünAdi + " Açıklama: " + ürünler[i].Aciklama + " Fiyatı: " + ürünler[i].Fiyati);
            }

            Console.WriteLine("-------------BİTTİ-------------");

            foreach (Ürün ürün in ürünler)
            {
                Console.WriteLine(ürün.ÜrünAdi + " Açıklama: " + ürün.Aciklama + " Fiyatı: " + ürün.Fiyati);
            }

            Console.WriteLine("-------------BİTTİ-------------");

            int s = 0;
            while (s < ürünler.Length)
            {
                Console.WriteLine(ürünler[s].ÜrünAdi + " Açıklama: " + ürünler[s].Aciklama + " Fiyatı: " + ürünler[s].Fiyati);
                s++;
            }

            Console.WriteLine("-------------BİTTİ-------------");
        }
    }

    class Ürün
    {
        public string ÜrünAdi { get; set; }
        public string Aciklama { get; set; }
        public int Fiyati { get; set; }
    }
}
