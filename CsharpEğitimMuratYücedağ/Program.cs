using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //charın formatı '' tek tırnaktır
            //bu kodla bazı karakterlerin kullanımını sağlıyor
            Console.OutputEncoding = Encoding.UTF8;
            double number;
            number = 4.05;
            Console.WriteLine(number);
            Console.WriteLine($"{number}");

            double applePrice, bananaPrice, orangePrice;
            orangePrice = 46.90;
            bananaPrice = 36.90;
            applePrice = 20.14;
            double appleGram,bananaGram,orangeGram;
            appleGram = 1.300;
            bananaGram = 2.450;
            orangeGram = 1.562;
            double appleTotalPrice, bananaTotalPrice, orangeTotalPrice;
            appleTotalPrice = applePrice * appleGram;
            bananaTotalPrice = bananaPrice*bananaGram;
            orangeTotalPrice = orangePrice*orangeGram;
            double totalPrice;
            totalPrice = appleTotalPrice + orangeTotalPrice + bananaTotalPrice;
            Console.WriteLine(totalPrice);

            char symbol;
            symbol = 'A';
            Console.WriteLine(symbol);
            //taha
            #region Tam sayı girişleri ve dönüşümler
            int shoePrice, computerPrice, chairPrice, tvPrice;
            shoePrice = 1000;
            computerPrice = 30000;
            chairPrice = 3500;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            int productsTotalPrice = shoesCount * shoePrice;
            Console.WriteLine($"Toplam Tutar : {productsTotalPrice}");
            #endregion

            #region Klavyeli ondalıklı sayı işlemleri

            double exam1,exam2,exam3,result;
            Console.Write("Lütfen 1.sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 2.sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 3.sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3)/3;
            Console.WriteLine($"Öğrencinin sınav ortalaması : {result}");
            
            #endregion

            Console.ReadLine();
        }
    }
}
