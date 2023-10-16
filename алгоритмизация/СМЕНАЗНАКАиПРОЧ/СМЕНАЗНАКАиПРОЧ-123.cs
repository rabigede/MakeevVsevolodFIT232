using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            задачи: для n вводимых элементов 
            1) определить количество смены знака, без 0 
            2) определить количество элементов, значение которых меньше соседа слева и справа 
            3) определить максимальный размер под последовательности, состоящей из одинаковых элементов 

            ( в файле СМЕНАЗНАКАиПРОЧ-4) 4) определить минимальный размер под последовательности из отрицательных, если не одной под последовательности - выдать сообщение
            */

            Console.Write("Количество элементов n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");

            int a = 0;
            int b = 0;
            int c = 0;
            int similar = 1;

            int maxsim = 0;
            int changing = 0;
            int neighbours = 0;

            for (int i = 0; i < n; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());

                if (i == 0)
                {
                    b = a;
                }
                if (i==1)
                {   
                    if (b==a)
                    {
                        similar--;
                    }
                    if (b<a)
                    {
                        neighbours++;
                    }
                    if (((b<0) && (a>0)) || ((a < 0) && (b > 0)))
                    {
                        changing++;
                    }
                }
                else
                {
                    
                    if (((a>0) && (b<0)) || ((b > 0) && (a < 0)))
                    {
                        changing++;
                    }

                    if ((b<a) && (b<c))
                    {
                        neighbours++;
                    }

                    if (i == n-1)
                    {
                        if (b > a)
                        {
                            neighbours++;
                        }
                    }
                }

                if (a==b)
                {
                    similar++;
                    if (similar>maxsim)
                    {
                        maxsim = similar;
                    }
                }
                else
                {
                    similar = 1;
                }

                if (i > 0)
                {
                    c = b;
                }

                b = a;
                
            }

            Console.WriteLine($"Количество смены знака: {changing}");
            Console.WriteLine($"Меньше обоих соседей: {neighbours}");
            Console.WriteLine($"Макс ряд одинаковых: {maxsim}");
        }
    }
}
