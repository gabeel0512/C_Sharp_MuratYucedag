using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5 tane yildiz olusturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Alt alta 10 tane yildiz olusturma, her satirda 10 tane yildiz

            //for (int i = 0; i < 11; i++)
            //{
            //    for (int j = 0; j < 11; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Alt alta 10 tane yildiz olusturma, her satirda satir numarasi kadar yildiz

            //for (int i = 0; i < 11; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Ters Dik Üçgen

            //for (int i = 10; i > 0; i--)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            #endregion

            #region Elmas Uygulamasi

            //for (int i = 0; i < 11; i++)
            //{
            //    if (i < 5)
            //    {
            //        for (int j = 0; j <= i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    else
            //    {
            //        for (int j = 0; j < 11 - i; j++)
            //        {
            //            Console.Write("*");
            //        }
            //    }

            //    Console.WriteLine("");
            //}

            #endregion

            #region Baklava dilimi

            int n = 5;

            // Üst Kýsým
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // Alt Kýsým
            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Ters pramit

            //int n = 5;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k < 2 * (n - i) - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}


            #endregion


            Console.Read();
        }
    }
}
