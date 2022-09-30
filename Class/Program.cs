using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1,2 задания\nВведите номер дня ");
            DateTime dt = Convert.ToDateTime("01.01.1900");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 365)
                Console.WriteLine("Столько дней не бывает!");
            else
            {
                dt = dt.AddDays(num - 1);
                Console.WriteLine(dt.ToString("d MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
            }

            Console.Write("3 задание\nВведите номер года ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер дня ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime newdate = Convert.ToDateTime("01.01.1904");
            if(year%4==0 && year%100!=0 || year%400==0)
            {
                if (day < 1 || day > 366)
                    Console.WriteLine("Столько дней не бывает!");
                else
                {
                    newdate = newdate.AddDays(day - 1);
                    Console.WriteLine(newdate.ToString("d MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
                }
            }
            else
            {
                if (day < 1 || day > 365)
                    Console.WriteLine("Столько дней не бывает!");
                else
                {
                    newdate = newdate.AddDays(day - 1);
                    Console.WriteLine(newdate.ToString("d MMMM", CultureInfo.CreateSpecificCulture("ru-RU")));
                }
            }
        }
    }
}