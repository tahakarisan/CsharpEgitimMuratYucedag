using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // foreach(1,2,3,4)
            /*
            1 : değişken türü;
            2 : değişken adı;
            3 : in;
            4 : liste,koleksiyon 
            */

            //string[] cities = { "Ankara", "İstanbul" };
            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 10, 29, 23, 28, 30 };
            //foreach (int number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            //int[] numbers = { 10, 29, 23, 28, 30 };
            //int sum = 0;
            //foreach (int number in numbers)
            //{
            //    sum += number;  
            //}

            //Console.WriteLine(sum);

            //string word = "Taha";
            //foreach (char x in word)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            #region Örnek sınav sistemi uygulaması
            Console.WriteLine("---------Sınav sistemi uygulaması--------");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Sınıfınızda kaç öğrenci var: ");

            int studentCount = int.Parse(Console.ReadLine());

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i+1}. öğrencinin ismini giriniz ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} adlı öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;

                }
                studentExamAvg[i] = totalExamResult / 3;
                
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("*************************************");

                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");

                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine("Geçtiniz");
                }
                else
                {
                    Console.WriteLine("Kaldınız");
                }
            }
            #endregion
            Console.ReadLine();
        }
    }
}
