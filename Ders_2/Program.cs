using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DoubleDegiskenler

            //double applePrice = 14.85,
            //    orangePrice = 20.95,
            //    strawberryPrice = 45,
            //    potatoPrice = 9.74,
            //    tomatoPrice = 6.88;

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice);
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice);
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice);
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice);
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice);


            //double appleGram = 1.245,
            //    orangeGram = 2.650,
            //    strawGram = 0.750, 
            //    potatoGram = 4.859,
            //    tomatoGram = 3.745,
            //    totalPrice = 0;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün: ELma, Birim Fiyatı: " + applePrice + ", Gramaj: " + appleGram + ", Toplam Tutar: " + appleGram * applePrice);
            //Console.WriteLine("Alınan Ürün: Portakal, Birim Fiyatı: " + orangePrice + ", Gramaj: " + orangeGram + ", Toplam Tutar: " + orangeGram * orangePrice);
            //Console.WriteLine("Alınan Ürün: Çilek, Birim Fiyatı: " + strawberryPrice + ", Gramaj: " + strawGram + ", Toplam Tutar: " + strawGram * strawberryPrice);
            //Console.WriteLine("Alınan Ürün: Patates, Birim Fiyatı: " + potatoPrice + ", Gramaj: " + potatoGram + ", Toplam Tutar: " + potatoGram * potatoPrice);
            //Console.WriteLine("Alınan Ürün: Domates, Birim Fiyatı: " + tomatoPrice + ", Gramaj: " + tomatoGram + ", Toplam Tutar: " + tomatoGram * tomatoPrice);

            //Console.WriteLine();

            //totalPrice = (appleGram * applePrice) + (orangeGram * orangePrice) + (strawGram * strawberryPrice) + (potatoGram * potatoPrice) + (tomatoGram * tomatoPrice);

            //Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            #endregion

            #region CharDegiskenler

            //char symbol = 'A';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girisi

            //Console.WriteLine("**** C Sharp Deniz Yollari Yolcu Bilgisi");
            //Console.WriteLine();

            //String passengerName, passengerSurname, passengerDistrict, passengerCity, passangerAge;

            //Console.Write("Adınız: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Soyadınız: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("Yaşınız: ");
            //passangerAge = Console.ReadLine();
            //Console.Write("İlçeniz: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname +
            //                  " -- Yolcu Yaşı: " + passangerAge +
            //                  " -- Adres Bilgisi: " + passengerDistrict + "/" + passengerCity);

            #endregion

            #region Klavyeden Tam Sayi Giris

            //int shoesPrice = 1000,
            //    computerPrice = 60000,
            //    chairPrice = 5000,
            //    tvPrice = 12000,
            //    shoesCount = 0,
            //    computerCount = 0,
            //    chairCount = 0,
            //    tvCount = 0;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoesCount * shoesPrice + computerCount * computerPrice) + (chairCount * chairPrice + tvPrice * tvCount);

            //Console.WriteLine("Toplam Ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Klavyeden ondalikli sayi islemleri

            //double exem1 = 0, exem2 = 0, result = 0;

            //Console.Write("Vize Notunuzu Giriniz: ");
            //exem1 = double.Parse(Console.ReadLine());

            //Console.Write("Final Notunuzu Giriniz: ");
            //exem2 = double.Parse(Console.ReadLine());

            //result = (exem1 * 0.4) + (exem2 * 0.6);

            //Console.WriteLine();
            //Console.WriteLine("Ortalamanız: " + result);

            #endregion

            #region Cinsiyet

            char cinsyet;

            Console.Write("Lütfen cinsiyet seçiniz: ");
            cinsyet = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet: " + cinsyet);

            #endregion

            Console.Read();
        }
    }
}
