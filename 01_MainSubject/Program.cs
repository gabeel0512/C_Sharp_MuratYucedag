using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Yazdirma

            //Console.WriteLine("Merhaba Dünya!");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("3- Salatalar");
            //Console.WriteLine("3- Ara Sicaklar");
            //Console.WriteLine("3- Tatlilar");

            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region StringDegiskenlar

            //string customerName, customerSurname, customerPhone, customerEmail, district, city;


            //customerName = "Omer";
            //customerSurname = "Ensari";
            //customerPhone = "+90 551 112 11 22";
            //customerEmail = "omerensari51@gmail.com";
            //district = "Beylikdüzü";
            //city = "Istanbul";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("-----------------------------------");

            #endregion

            #region IntagersDegiskenler

            int hamburgerPrice = 300;
            int cokePrice = 50;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 400;
            int lemonadePrice = 50;

            Console.WriteLine("***** Restoran Menü Fiyatları *****");
            Console.WriteLine();
            Console.WriteLine("---- Hamburger : " + hamburgerPrice + "TL");
            Console.WriteLine("---- Kola : " + cokePrice + "TL");
            Console.WriteLine("---- Su : " + waterPrice + "TL");
            Console.WriteLine("---- Kızartma : " + friesPrice + "TL");
            Console.WriteLine("---- Pizza : " + pizzaPrice + "TL");
            Console.WriteLine("---- Limonata : " + lemonadePrice + "TL");
            Console.WriteLine();

            int totalPrice = 0;

            int hamburgerCount = 2
                , cokeCount = 3
                , waterCount = 1
                , friesCount = 2
                , pizzaCount = 1,
                lemonadeCount = 0;

            totalPrice = (hamburgerPrice * hamburgerCount)
                         + (cokeCount * cokePrice)
                         + (waterCount * waterPrice)
                         + (friesCount * friesPrice)
                         + (pizzaCount * pizzaPrice)
                         + (lemonadeCount * lemonadePrice);

            Console.WriteLine("-------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + (hamburgerPrice * hamburgerCount) + " TL");
            Console.WriteLine("Kola Tutarı: " + (cokeCount * cokePrice) + " TL");
            Console.WriteLine("Su Tutarı: " + (waterCount * waterPrice) + " TL");
            Console.WriteLine("Kızartma Tutarı: " + (friesCount * friesPrice) + " TL");
            Console.WriteLine("Pizza Tutarı: " + (pizzaCount * pizzaPrice) + " TL");
            Console.WriteLine("Limonata Tutarı: " + (lemonadeCount * lemonadePrice) + " TL");
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");



            #endregion



            Console.Read();
        }
    }
}
