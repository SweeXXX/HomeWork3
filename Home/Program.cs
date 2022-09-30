using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1();
            //zad2();
            //zad3();
            //zad4();
            //zad5();
            //zad6();
            //zad7();
            //zad8();
            //zad9();
            //zad10();
            //zad11();
            static void zad1()
            {
                try
                {
                    double n = double.Parse(Console.ReadLine());
                    double m = double.Parse(Console.ReadLine());
                    double diam = double.Parse(Console.ReadLine());
                    if(n >= diam+1 && m >= diam+1)
                    {
                        Console.WriteLine($"Вася сможет пролезть");
                    }
                    else
                    {
                        Console.WriteLine($"Вася не смодет пролезть в дырку. Она слишком узкая(");
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void zad2()
            {
                Console.WriteLine("2 ZADANIE");
                Console.Write("Введите число от 1 до 9 включительно ");
                if(int.TryParse(Console.ReadLine(), out int res) && res <=9 && res >=1)
                {
                    for(int i = 1; i < 10; i++)
                    {
                        Console.WriteLine($"{res}*{i} = {res*i}");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод.Читать научись!");
                }
            }
            static void zad3()
            {
                Console.Write("3 Задание.\nВведите целое число ");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    if (num % 3 == 0 && num % 5 == 0)
                        Console.WriteLine("БэнгБум");
                    else if (num % 3 == 0 && num % 5 != 0)
                        Console.WriteLine("Бэнг");
                    else if (num % 3 != 0 && num % 5 == 0)
                        Console.WriteLine("Бум");
                    else
                        Console.WriteLine("Мимо");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Ты всё сломал, поздравляю!(нет)");
                }
            }
            static void zad4()
            {
                Console.Write("4 Задание.Введите строку ");
                try
                {
                    string stroka = Console.ReadLine();
                    bool flag = true;
                    foreach (char c in stroka)
                    {
                        if (char.IsUpper(c) == false)
                            flag = false;
                    }
                    Console.WriteLine(flag ? "True" : "False");
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex);
                }

            }
            static void zad5()
            {
                Console.Write("5Задание.\nВведите положительное целое число ");
                try
                {
                    uint num = uint.Parse(Console.ReadLine());
                    for(int i = 1; i <= num; i++)
                    {
                        Console.Write($"{i} овца...");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            
            }
            static void zad6()
            {
                int[] list = new int[] {1,2,4,5,6 };
                double k = list.Sum() - list[list.Length-1];
                Console.WriteLine(k/(list.Length-1));
            }

        }
    }
}