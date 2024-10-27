using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[5];
            //colors[0] = "siyah";
            //colors[1] = "beyaz";
            //colors[2] = "sarı";
            //colors[3] = "mor";
            //colors[4] = "kırmızı";
            //Console.WriteLine(colors[0]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme
            //int[] numbers = new int[5];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //Console.WriteLine(numbers[0]);

            //string[] cities = new string[2]
            //{
            //    "istanbul",
            //     "ankara"
            //};
            //int[] numbers = new int[5];
            //numbers[0] = 12;
            //numbers[1] = 3;
            //numbers[2] = 5;
            //numbers[3] = 18;
            //numbers[4] = 27;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            ////}
            //Console.WriteLine(numbers[0]);
            #endregion

            #region Dizi Metotlar
            //int[] numbers = { 45, 25, 26, 5, 10, 11, 12, 13, };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers = { 45, 25, 26, 5, 10, 11, 12, 13, };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine("-----------------------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, };
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion

            Console.Read();
        }
    }
}
