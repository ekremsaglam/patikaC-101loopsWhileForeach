using System;

namespace loopsWhileForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı girin : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;

            }
            Console.WriteLine("Ortalama : " + toplam / sayac);


            string[] arabalar = { "BMW", "Ford", "Renault", "Toyota", "Nissan" };

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


            
        }


    }
}
