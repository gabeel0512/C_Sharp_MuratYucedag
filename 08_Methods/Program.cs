using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar

            //void CustomerAdd()
            //{
            //    Console.WriteLine("Ali Yildiz Added!");
            //    Console.WriteLine("Selim Isik Added!");
            //    Console.WriteLine("Mustafa Ceceli Added!");
            //}

            //CustomerAdd();

            //void Sum()
            //{
            //    int a = 5;
            //    int b = 10;
            //    int c = a + b;
            //    Console.WriteLine("Sum: " + c);
            //}

            //Sum();


            #endregion

            #region non-Return String Metodlar

            //void CustomerCard(string customerName, string customerSurname )
            //{
            //    Console.WriteLine("Customer Name: " + customerName + " " + customerSurname);
            //}

            //CustomerCard("Ali", "Yildiz");

            #endregion

            #region Non-Return Int Metodlar

            //void Sum(int a, int b)
            //{
            //    int result = a + b;
            //    Console.WriteLine("Sum: " + result);
            //}



            #endregion

            #region Return Metodlar

            //string CustomerName()
            //{
            //    return "Ali Yildiz";
            //}

            //string name = CustomerName();
            //Console.WriteLine(name);

            //string SutudentCart(string studentName, string studentSurname)
            //{
            //    return studentName + " " + studentSurname;
            //}

            //string student = SutudentCart("Ali", "Yildiz");

            //Console.WriteLine(student);

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z; 

            //Console.Write("Ülke adını giriniz: "); x = Console.ReadLine();
            //Console.Write("Başkenti giriniz: "); y = Console.ReadLine();
            //Console.Write("Bayrak Rengini Giriniz: "); z = Console.ReadLine();
            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));
            //Console.WriteLine();

            //int Sum(int a, int b)
            //{
            //    return a + b;
            //}

            //Console.WriteLine(Sum(5, 10));

           
            string Examresult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi. Ortalama: " + result;
                }
            }

            Console.WriteLine(Examresult("Ali", 50, 60, 70));


            #endregion



        }
    }
}
