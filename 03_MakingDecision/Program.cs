using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen sifreyi giriniz: ");
            //string sifre = Console.ReadLine();
            //if (sifre == "1234")
            //{
            //    Console.WriteLine("Sifre Dogru");
            //}
            //else
            //{
            //    Console.WriteLine("Sifre Yanlis");
            //}


            //string capital, country;
            //Console.Write("Başkenti  giriniz: ");
            //country = Console.ReadLine();
            //Console.Write("Ülkeyi giriniz: ");
            //capital = Console.ReadLine();
            //if (country == "Türkiye" && capital == "Ankara")
            //{
            //    Console.WriteLine("Doğru bildiniz");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış bildiniz");
            //}


            //int sayi;
            //Console.Write("Bir sayi giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Sayi cifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi tektir");
            //}


            //int exam1, exam2, exam3, Avarage;
            //string result = "Hata";

            //Console.Write("1. Sınavı giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sınavı giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3. Sınavı giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //Avarage = (exam1 + exam2 + exam3) / 3;

            //if (Avarage >= 85)
            //{
            //    result ="Dersi geçtiniz  -- Yüksek Basari";
            //}
            //else if (Avarage >= 70)
            //{
            //    result = "Dersi geçtiniz  -- Orta Basari";
            //}

            //else if (Avarage >= 50)
            //{
            //    result = "Dersi geçtiniz  -- Düsük Basari";
            //}
            //else
            //{
            //    result = "Dersten kaldınız";
            //}

            //Console.Write(result);

            //string city;
            //Console.Write("Bir sehir giriniz: ");
            //city = Console.ReadLine();

            //if (city == "Adana" | city == "Ankara" | city == "İstanbul" | city == "İzmir")
            //{
            //    Console.WriteLine("sehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Bu sehir mevcut değildir");
            //}

            //Console.Write("Kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();

            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı adı yanlış");
            //}
            //else
            //{
            //    Console.Write("Hos Geldiniz");

            //}

            #endregion

            #region Mod Islemleri


            //Console.WriteLine("Lütfen 1. Sayiyi Giriniz");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Sayiyi Giriniz");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int result = sayi1 % sayi2;

            //Console.WriteLine(result);

            //char team;
            //Console.Write("Bir takım Sembolü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g'| team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' | team 'F')
            //{
            //    Console.WriteLine("Fenerbahce");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Besiktas");
            //}

            #endregion

            #region Ornek Proje Uygulamasi

            //int secim = 0;
            //Console.WriteLine("*******  C# Eğitim Kampı Restoran  ******\n" +
            //                  "\n" +
            //                  "1- Ana Yemekler\n" +
            //                  "2- Çorbalar\n" +
            //                  "3- Pizzalar\n" +
            //                  "4- İçecekler\n" +
            //                  "5- Tatlılar\n" +
            //                  "---------------------------------------\n");
            //secim = Convert.ToInt32(Console.ReadLine());
            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine("Ana Yemekler -- Tükendi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Çorbalar -- Tükendi ");
            //        break;
            //    case 3:
            //        Console.WriteLine("Pizzalar -- 800 TL");
            //        break;
            //    case 4:
            //        Console.WriteLine("İçecekler -- 60 TL");
            //        break;
            //    case 5:
            //        Console.WriteLine("Tatlıar -- Tükendi TL");
            //        break;
            //    default:
            //        Console.WriteLine("Yanlış İşlem.");
            //        break;
            //}

            #endregion

            #region Hesap Makinesi

            Console.WriteLine("------------- Hesap Makinesi Uygulaması -----------");

            Console.Write("1.Sayi  :  ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayi  :  ");
            int sayi2 = int.Parse(Console.ReadLine());

            Console.WriteLine("1-Toplama\n" +
                              "2-Çıkarma\n" +
                              "3-Çarpma\n" +
                              "4-Bölme\n");
            string islem =Console.ReadLine();

            switch (islem)
            {
                case "1":
                    Console.WriteLine("Toplama Sonucu: " + (sayi1 + sayi2));
                    break;
                case "2":
                    Console.WriteLine("Çıkarma Sonucu: " + (sayi1 - sayi2));
                    break;
                case "3":
                    Console.WriteLine("Çarpma Sonucu: " + (sayi1 * sayi2));
                    break;
                case "4":
                    Console.WriteLine("Bölme Sonucu: " + (sayi1 / sayi2));
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem");
                    break;
            }


            #endregion
            Console.Read();
        }
    }
}
