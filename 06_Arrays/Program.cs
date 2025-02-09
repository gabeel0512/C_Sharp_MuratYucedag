using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[3];
            //colors[0] = "Red";
            //colors[1] = "Green";
            //colors[2] = "Blue";

            //Console.WriteLine(colors[0]);

            //string[] cities = new string[4];
            //cities[0] = "Ankara";
            //cities[1] = "İstanbul";
            //cities[2] = "İzmir";
            //cities[3] = "Adana";

            //int[] numbers = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine(numbers[9]);

            #endregion

            #region Dizideki tüm elemanlari listeleme

            //string[] colors = { "Red", "Green", "Blue", "Yellow", "Pink" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 67, 844, 4345, 6555, 7523,7863, 2211 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }   
            //}

            //int[] myArray= { 4, 67, 844, 4345, 6555, 7523, 7863, 2211 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //int[] numbers = { 4, 67, 844, 4345, 6555, 7523, 7863, 2211 };
            //Array.Sort(numbers);
            //foreach (var number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Dizi Metotlari

            //string[] customers = { "Ali", "Veli", "Ayse", "Mehmet", "Ahmet" };

            //int index = Array.IndexOf(customers, "Ayse");

            //Console.WriteLine(index);

            //int[] numbers = { 4, 67, 844, 4345, 6555, 7523, 7863, 2211 };

            //Console.WriteLine("Dizinin En büyük elemani  :" + numbers.Max() + "  En küçük degeri  :" + numbers.Min());



            #endregion

            #region Kullanicidan deger alarak dizi olusturma

            //string[] students = new string[4];

            //for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine("Öğrenci ismi giriniz :");
            //    students[i] = Console.ReadLine();
            //}

            //foreach (string student in students)
            //{
            //    Console.WriteLine(student);
            //}


            //int[] numbers = {10,20,30,40,50};

            //int sum = 0;

            //foreach (var number in numbers)
            //{
            //    sum += number;
            //}

            //Console.WriteLine(sum);

            //int[] numbers = { 12,24,65,41,586,124,35,564,121, 11 };

            //Console.WriteLine("Çift sayilar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("Tek sayilar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
