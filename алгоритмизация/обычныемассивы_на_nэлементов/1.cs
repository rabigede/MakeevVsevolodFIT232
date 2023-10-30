using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* НОРМ МАССИВЫ

            дана посл. эл. колво н 
            1) определить положение 1 эл, значение которого кратна мин эл массива 
            
            */

            Console.Write("Количество элементов массива n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");

            int a = 0;
            int min = 0;


            int[] array = new int[n];

            int[] array_copy = array;

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                array[i] = a;

            }
            
            Array.Sort(array_copy); //определение минимального исключая 0
            for (int i = 0; i < array_copy.Length; i++)
            {
                min = array_copy[i];
                if (min != 0)
                {
                    break;
                }
            }
            

            
            for (int i = 0; i < array.Length; i++) 
            {
                // #1#
                
                if ((array[i] % min == 0) && (array[i] != min))
                {
                    Console.WriteLine($"положение первого кратного минимальному: {i}");
                    break;
                }

            }
        }
    }
}
