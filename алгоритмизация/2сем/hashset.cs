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
            /*
               1) Дается три множества, найти пересечения и объединения множеств, используется методы Set'а
                  Необходимо найти дополнения для каждого множества (тоже методы у Set)
            */
            HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4 };
            HashSet<int> set2 = new HashSet<int>() { 1, 2, 4 };
            HashSet<int> set3 = new HashSet<int>() { 3, 2, 5 };

            HashSet<int> peresechenia = new HashSet<int>(set1); //пересечение
            peresechenia.IntersectWith(set2);
            peresechenia.IntersectWith(set3);

            HashSet<int> obedinenie = new HashSet<int>(set1); //объединение
            obedinenie.UnionWith(set2);
            obedinenie.UnionWith(set3);

            HashSet<int> dop1 = new HashSet<int>(obedinenie); //дополнение к 1
            dop1.ExceptWith(set1);

            HashSet<int> dop2 = new HashSet<int>(obedinenie); //дополнение ко 2
            dop2.ExceptWith(set2);

            HashSet<int> dop3 = new HashSet<int>(obedinenie); //дополнение к 3
            dop3.ExceptWith(set3);

            //вывод
            Console.WriteLine("Пересечение трех множеств");
            foreach (int i in peresechenia)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Объединение трех множеств");
            foreach (int i in obedinenie)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Дополнение 1 множеств");
            foreach (int i in dop1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Дополнение 2 множества");
            foreach (int i in dop2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Дополнение 3 множества");
            foreach (int i in dop3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}