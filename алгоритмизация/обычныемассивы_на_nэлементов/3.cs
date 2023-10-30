using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* НОРМ МАССИВЫ

            дана посл. эл. колво н 
            3) определить образуют ли эл, расположенные между мин и макс эл масива убывающую последовательность (макс и мин - единственные предусмотреть отсутствие) 
 
            */

            //  #3  //

            Console.Write("Количество элементов массива n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");
            int[] array = new int[n];
            int a = 0;

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                array[i] = a;
            }
           

            int indexmin = Array.IndexOf(array, array.Min());
            int indexmax = Array.IndexOf(array, array.Max());
            bool check = false;
 


            for (int i = 0; i < n; i++)
            {

                Console.WriteLine(array[i]);

                if (indexmin<indexmax)
                {
                    if ((indexmin < i) && (i < indexmax))
                    {
                        if ((check is true) && (i == indexmax-1))
                        {
                            
                        }
                        Console.WriteLine($"{check}");
                        if (array[i] > array[i+1])
                        {
                            check = true;
                        }
                    }
                }
                
                
            }

            Console.WriteLine($"образуют ли последовательность???: {check}");

        }
    }
}
