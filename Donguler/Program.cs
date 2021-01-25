using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs", "Java" };

            for (int i = 0; i < kurslar.Length; i++)  //i < 3 de olur diğeri daha dinamik
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar) //dizilere uygulanır
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");


            for (int i = 1; i <= 10; i=i+2) //i=i+2 veya i+=2 //i=i+1 veya i++
            {
                Console.WriteLine(i);
            }
        }
    }
}
