using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            Console.WriteLine("Lütfen şifreyi giriniz: ");
            string password;
            password = Console.ReadLine();
            if (password=="a")
            {
                Console.WriteLine("Şifre doğru");
            }
            else
            {
                Console.WriteLine("Şifre yanlış");
            }
            string capital, country;
            Console.Write("Başkenti Giriniz: ");
            capital = Console.ReadLine();
            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine();
            if (capital=="İstanbul" && country=="Türkiye")
            {
                Console.WriteLine("Veriler doğru");
            }

            int exam1,exam2,exam3,average;
            string result;
            Console.Write("Sınav 1: ");
            exam1= int.Parse(Console.ReadLine());
            Console.Write("Sınav 2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav 3: ");
            exam3 = int.Parse(Console.ReadLine());
            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınavların Ortalaması:{0} ",average);
            if (average>0 && average<50)
            {
            }
            if (average>50 && average<=70)
            {
            }
            if(average>70 && average <= 84)
            {
            }
            Console.Read();
            #endregion
            #region Mod Operations

            Console.Write("Sayıyı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number%2==0)
            {
                Console.WriteLine("Bu bir çift sayıdır");
            }

            char team;
            Console.Write("Takım giriniz: ");
            team = char.Parse(Console.ReadLine());
            if (team=='g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fener");
            }
            if (team == 'b' | team == 'B')
            {
                Console.WriteLine("Beşiktaş");
            }

            #endregion
            #region Switch Case
            Console.Write("Lütfen ay girişi yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1: Console.Write("Ocak");break;
                case 2: Console.Write("Şubat");break;
                case 3: Console.Write("Mart");break;
                case 4: Console.Write("Nisan");break;
                case 5: Console.Write("Mayıs");break;
                case 6: Console.Write("Haziran");break;
                case 7: Console.Write("Temmuz");break;
                case 8: Console.Write("Ağustos");break;
                case 9: Console.Write("Eylül");break;
                case 10: Console.Write("Ekim");break;
                case 11: Console.Write("Kasım");break;
                case 12: Console.Write("Aralık");break;
                default: Console.WriteLine("Hatalı giriş"); break;
            }
            #endregion
            #region Hesap Makinesi
            int number1,number2,operationResult;
            char symbol;
            Console.Write("1.sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2.sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemin sembolünü giriniz : ");
            symbol = char.Parse(Console.ReadLine());
            switch (symbol)
            {
                case '*': Console.WriteLine(number1*number2); break;
            }
            #endregion
        }
    }
}
