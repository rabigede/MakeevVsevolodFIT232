using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //дана посл. эл. колво н  5) сформулировать массив, который содержит суммы пар элементов исходного массива

            Console.Write("Количество элементов массива n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");
            int[] array = new int[n];
            int a = 0;

            int[] sumpairs = new int[n-1];

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());
                array[i] = a;
            }



            for (int i = 0; i < n-1; i++)
            {
                sumpairs[i] = array[i]+ array[i+1];


            }

            Console.WriteLine("массив");
            for (int i = 0; i < n-1; i++)
            {
                Console.Write($"{sumpairs[i]} ");
            }
            

        }
    }
 
}
