using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5*. Вывести и посчитать количество трехзначных чисел, сумма цифр которых равна 20.

            //int num = 0;
            //for (int i = 100; i < 1000; i++)
            //{
            //    if (i % 10 + i / 10 % 10 + i / 100 == 20)
            //    {
            //        Console.WriteLine(i);
            //        num++;
            //    }
            //}
            //Console.WriteLine(num);


            //6*. За каждый месяц банк начисляет к сумме вклада 7% от суммы. Напишите консольную программу,
            //в которую пользователь вводит сумму вклада и количество месяцев.
            //А банк вычисляет конечную сумму вклада с учетом начисления процентов за каждый месяц.

            //int price = int.Parse(Console.ReadLine());
            //int month = int.Parse(Console.ReadLine());
            //double sum = price;
            //double pro = 0.07;

            //for (int i = 0; i < month; i++)
            //{
            // sum = sum + sum * pro;
            //}
            //Console.WriteLine($"{sum:f1}");



            //7*. Рост стоимости акций. Выпустив акции предприятие, оценило их в 100 руб. за штуку в первоначальный момент.
            //Каждый следующий месяц акции вырастали в цене на 10% от стоимости предыдущего месяца. Определить:

            //double action = 100;
            //double pro = 0.1;
            //double seven = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            // Console.WriteLine($"{i} месяц = {action:f1} руб");
            // if (i == 7)
            // {
            // seven = action * 1000;
            // }
            // action = action + action * pro;
            //}
            //Console.WriteLine($"Стоимость 1000 акций на 7 месяц = {seven:f1} руб");







            //int width = 25;
            //int height = 7;
            //for (int i = 0; i < height; i++)
            //{
            // for(int j = 0; j < width; j++)
            // {
            // if(i == 0 || i == height - 1)
            // {
            // Console.Write('*');
            // }
            // else if (j == 0 || j == width - 1)
            // {
            // Console.Write('*');
            // }
            // else
            // Console.Write(' ');
            // }
            // Console.WriteLine();
            //}

            //int num = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (num > 0)
            //{
            // num /= 10;
            // count++;
            //}
            //Console.WriteLine(count);

            int num = int.Parse(Console.ReadLine());

            while (num > 0)
            {
                Console.Write(num % 10);
                num /= 10;
            }

            Console.ReadKey();

        }
    }
}
