using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* НОРМ МАССИВЫ

            дана посл. эл. колво н 
           
            4) определить все ли эл массива кратны номеру под которым они стоят 
                (нумирация эл массива с точки зрения пользователя (с первого элемента)) 
 
            */

            //  #4  //

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
            bool check = false;



            for (int i = 0; i < n; i++)
            {
                if ((array[i]%(i+1)==0) || (array[i]==0))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
               

            }

            Console.WriteLine($"все ли кратны своему номеру??: {check}");

        }
    }
    
}
