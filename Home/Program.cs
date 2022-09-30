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
            zad11();
            static void zad1()
            {
                Console.WriteLine("1 Задание.\nВведите n, m, diam через энтер");
                try
                {
                    double n = double.Parse(Console.ReadLine());
                    double m = double.Parse(Console.ReadLine());
                    double diam = double.Parse(Console.ReadLine());
                    if (n >= diam + 1 && m >= diam + 1)
                    {
                        Console.WriteLine($"Вася сможет пролезть");
                    }
                    else
                    {
                        Console.WriteLine($"Вася не сможет пролезть в дырку. Она слишком узкая(");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void zad2()
            {
                Console.WriteLine("2 ZADANIE");
                Console.Write("Введите число от 1 до 9 включительно ");
                if (int.TryParse(Console.ReadLine(), out int res) && res <= 9 && res >= 1)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        Console.WriteLine($"{res}*{i} = {res * i}");
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод.Читать научись!");
                }
            }
            static void zad3()
            {
                Console.Write("3 Задание.\nВведите целое число(Делится на 3 на 5 на 15) ");
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
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
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
                        if (!char.IsUpper(c))
                            flag = false;
                    }
                    Console.WriteLine(flag ? "True" : "False");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
                }

            }
            static void zad5()
            {
                Console.Write("5 Задание.\nВведите положительное целое число ");
                try
                {
                    uint num = uint.Parse(Console.ReadLine());
                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write($"{i} овца...");
                    }
                    Console.WriteLine();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            static void zad6()
            {
                Console.WriteLine("6 Задание.");
                int[] list = new int[] { 1, 2, 4, 5, 6 };
                double k = list.Sum() - list[list.Length - 1];
                Console.WriteLine(k / (list.Length - 1));
            }
            static void zad7()
            {
                Console.WriteLine("7 Задание.");
                try
                {
                    Console.Write("Введите номер карты от 6 до 15: ");
                    int k = int.Parse(Console.ReadLine());
                    if ((k < 6) || (k > 15))
                    {
                        Console.WriteLine("Нужно было ввести число от 6 до 15");
                    }
                    else
                    {
                        Console.WriteLine($"Достоинство соответствующей карты: {(libro.Карты)k}");

                    }

                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            static void zad8()
            {
                Console.WriteLine("8 Задание.");
                string[] str = new string[] { "Hello Kitty", "It's not fair, I found love\r\nIt made me say that get back\r\nYou'll never see daylight\r\nIf I'm not strong, it just might\r\nIt's not fair, I found love\r\nIt made me say that get back\r\nYou'll never see daylight\r\nIf I'm not strong, it just might", "А правда что каждый боится я бы ответил что нет ведь я не боюсь темноты высота смысл жизни для многих и призраков для меня нет...", "Hello Kitty", "Barbie doll" };
                int count = 0;
                foreach (string elem in str)
                {

                    if ((elem == "Hello Kitty") || (elem == "Barbie doll"))
                        count++;
                }
                Console.WriteLine($"Кукол в сумке: {count}");
            }
            static void zad9()
            {
                Console.Write("9 Задание.\nВведите номер дня недели: ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"День недели: {(libro.days)k}");
            }
            static void zad10()
            {

            }
            static void zad11()
            {
                Console.WriteLine("11 Задание. Массив по возврастанию. Введите 10 числе через энтер");
                int mn = 10;
                int[] a = new int[mn];
                int numberelem = 0;
                bool flag = true;
                for (int i = 0; i < mn; i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
                for (int j = 0; j < a.Length - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        flag = false;
                        numberelem = j;
                        break;
                    }
                }
                if (flag)
                {
                    Console.WriteLine("Все элементы стоят по возрастанию");
                }
                else
                {
                    Console.WriteLine($"Элементы массива возрастают до элемента с индексом {numberelem}");
                }
            }
        }
    }
}