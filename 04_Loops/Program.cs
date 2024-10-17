using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For döngüleri
            //for (int i = 1; i <=5 ; i++)
            //{
            //    Console.WriteLine("C#");
            //}
            #endregion
            #region For Döngüsü ile karar yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalValue = 0;
            //for (int i = 0; i <= 20; i++)
            //{
            //    totalValue = i + totalValue;
            //}
            //Console.WriteLine(totalValue);

            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //int bakteri = 1;
            //for (int t = 0; t <= 10; t++)
            //{
            //    bakteri = 2 * bakteri;

            //}
            //Console.WriteLine(bakteri);
            #endregion
            #region While Döngüsü
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("merhaba"); 
            //    i++;
            //}
            #endregion

            #region Basamak toplama
            Console.WriteLine("Sayıyı gir");
            int number = int.Parse(Console.ReadLine());
            int hunder, ten, one;
            int total;
            one = number % 10;
            ten = number % 100 /10 ;
            hunder = number / 100 ;
            total = one+ ten+ hunder ;
            Console.WriteLine(total);
            #endregion
            Console.Read();
        }
    }
}
