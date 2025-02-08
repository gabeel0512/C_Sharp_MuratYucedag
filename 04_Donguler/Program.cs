using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ForLoop

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("i'nin değeri: " + i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine("i'nin değeri: " + i);
            //}

            //Console.WriteLine("Lütfen ekrana yazilmasini istediginiz adeedi yaziniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= sayi; i++)
            //{
            //    Console.WriteLine("Merhaba Dunya");
            //}

            #endregion

            #region For Dongüsü ile Karar Yapilari

            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int totalvalue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        totalvalue += i;
            //    }
            //}

            //Console.WriteLine(totalvalue);

            //int TotalValue = 0;

            //for (int i = 1; i < 50; i++)
            //{
            //    if (i%7 ==0)
            //    {
            //        TotalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("--------------");
            //Console.WriteLine(TotalValue);

            //int bakteriSayisi = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bakteriSayisi *= 2;
            //    Console.WriteLine(i + ". saatteki bakteri sayisi: " + bakteriSayisi);
            //}
            #endregion

            #region While

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Dunya");
            //    i++;
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10) {
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine("Toplam: " + sum);

            #endregion

            #region Ornek Sinav Sorusu

            Console.WriteLine("Lütfen 3 basamakli sayi giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int ones, tens, hundreds;

            ones = sayi % 10;
            tens = (sayi / 10) % 10;
            hundreds = sayi / 100;
            Console.WriteLine("Sayilerin toplami: " + (ones + tens + hundreds));

            #endregion

            Console.Read();
        }
    }
}
