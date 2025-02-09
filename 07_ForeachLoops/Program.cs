using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] colors = { "Red", "Green", "Blue", "Yellow", "Pink" };

            //foreach (string color in colors)
            //{
            //    Console.WriteLine(color);
            //}

            //int[] numbers = { 4, 67, 844, 4345, 6555, 7523, 7863, 2211 };

            //foreach (int number in numbers)
            //{
            //        Console.WriteLine(number);
            //}

            //int[] numbers = { 4, 67, 844, 4345, 6555, 7523, 7863, 2211 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 4, 67, 844, 4345, 6555, 7523, 7863, 2211 };

            //int Total = 0;

            //foreach (int number in numbers)
            //{
            //    Total += number;
            //}
            //Console.WriteLine(Total);

            //List<int> numbers = new List<int> {1,2,3,4,5,8};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Hello World";

            //foreach (char character in word)
            //{
            //    Console.WriteLine(character);
            //}








            #endregion

            #region Proje

            Console.WriteLine("Lütfen Ögrenci Sayisini Giriniz  :  ");
            int studentCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

            double[] studentExamAvg = new double[studentCount];
            string[] students = new string[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Lütfen {0}. ögrencinin adini giriniz : ", i + 1);
                students[i] = Console.ReadLine();

                Console.WriteLine("Lütfen 1. notu giriniz  :  ");
                double exam1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lütfen 2. notu giriniz  :  ");
                double exam2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Lütfen 3. notu giriniz  :  ");
                double exam3 = Convert.ToDouble(Console.ReadLine());

                studentExamAvg[i] = (exam1 + exam2 + exam3) / 3;

                Console.WriteLine("------------------------------");

                Console.WriteLine("");
                Console.WriteLine("");

            }

            foreach (var student in students)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Ögrenci Adi : {0}", student);
                Console.WriteLine("Ortalama : {0}", studentExamAvg[Array.IndexOf(students, student)]);
                if (studentExamAvg[Array.IndexOf(students, student)] >= 50)
                {
                    Console.WriteLine("Durum : Geçti");
                }
                else
                {
                    Console.WriteLine("Durum : Kaldı");
                }
            }




            #endregion

            Console.ReadLine();
        }
    }
}
