using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* для n эликов 4) определить минимальный размер под последовательности из отрицательных, 
             * если не одной под последовательности - выдать сообщение*/

            Console.Write("Количество элементов n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");

            int a = 0;
            int negative = 0;
            int check = 0;

            int minnegative = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a<0)
                {
                    negative = negative+1;
                    check = 1;
                }
                else
                {
                    if ((negative < minnegative) && (negative != 0))
                    {
                        minnegative = negative;
                    }
                    negative = 0;
                }

                if (i==n-1)
                {
                    if (negative < minnegative)
                    {
                        minnegative = negative;
                    }
                    negative = 0;
                }

            }

            if (check==0)
            {
                Console.WriteLine("ашибачка отрицательных нет(((");
            }
            else
            {
                Console.WriteLine($"минимальный ряд отрицательных: {minnegative}");
            }

        }
    }
}
