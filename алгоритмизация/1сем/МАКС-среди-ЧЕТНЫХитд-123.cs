using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  массив или без ввод данных для n элементов: 
                1) максимальный среди чётных 
                2) количество элементов, у которых в записи числа есть цифра 5 
                3) элемент с наименьшей суммой цифр(отрицательные и положительные)  */

            Console.Write("Количество элементов n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");

            int a = 0;
            int d = 0;
            int figs = 0;
            int sumfigs = 0;
            int check5 = 0;

            int globalcount5 = 0;
            int minsumfigs = int.MaxValue;
            int maxeven = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                d = Math.Abs(a);

                if (a%2==0)
                {
                    if (a>maxeven)
                    {
                        maxeven = a;
                    }
                }

                while(d>0)
                {
                    figs = d % 10;
                    d = (d-figs)/10;
                    sumfigs = sumfigs + figs;

                    if (figs == 5)
                    {
                        check5 = 1;
                    }
                }

                if (check5 == 1)
                {
                    globalcount5++;
                    check5 = 0;
                }

                if (sumfigs < minsumfigs)
                {
                    minsumfigs = sumfigs;
                }

                sumfigs = 0;

            }

            
            Console.WriteLine($"максимальный среди четных: {maxeven} " +
                $"\nэлементов с цифрой 5: {globalcount5}" +
                $"\nнаименьшая сумма цифр: {minsumfigs}");

        }
    }
}
