using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* НОРМ МАССИВЫ

            дана посл. эл. колво н 
            2) определить положение последнего нулевого эл массива 
            */

            Console.Write("Количество элементов массива n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");

            int a = 0;
            int maxnull = int.MinValue;
            int number0 = 0;

            int[] array = new int[n];


            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                array[i] = a;
                if (array[i] == 0)
                {
                    number0 = i;
                    if (number0 > maxnull)
                    {
                        maxnull = number0;
                    }
                }
            }

            if (maxnull > -1)
            {
                Console.WriteLine($"последний нулевой элемент положение в массиве: {maxnull}");
            }
            else
            {
                Console.WriteLine("нулей нету :( ");
            }
            


        }
    }
}
