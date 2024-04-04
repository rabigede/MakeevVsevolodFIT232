using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=0;
            int count=0;
            int countless = 0;
            int countTHREE = 0;

            Console.Write("Кол - во элементов(n): ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("элементы через enter: ");

            for (int i = 0; i<N; i++)
            {
                /*определить кол-во, знаения которых больше предыдущего элемента*/
                /*определить кол-во, знаения которых меньше предыдущего элемента*/
                /*определить кол-во пар, сумма которых кратна 3*/

                a = Convert.ToInt32(Console.ReadLine());
                
                if (i == 0)
                {
                    b = a;
                }
                else
                {
                    if (a > b)
                    {
                        count++;
                    }
                    if (a < b)
                    {
                        countless++;
                    }
                    if ((a+b)%3==0)
                    {
                        countTHREE++;
                    }
                }
                b = a;
            }   
                Console.WriteLine($"Количество элементов больших предыдущего: {count}");
                Console.WriteLine($"Количество элементов меньших предыдущего: {countless}");
                Console.WriteLine($"Количество пар сумма которых кратна трём: {countTHREE}");


        }

        }
    }
