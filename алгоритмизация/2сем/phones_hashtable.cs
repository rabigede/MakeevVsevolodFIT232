using System;
using System.Linq;

namespace SumOfDigitsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 222, 54, 78, 101, 1245, 1474, 427, 7852, 0 };

            var numbersWithEvenSumOfDigits = from n in numbers
                                             where n.ToString().Sum(c => int.Parse(c.ToString())) % 2 == 0
                                             select n;

            Console.WriteLine("Элементы с чётной суммой цифр:");
            foreach (int n in numbersWithEvenSumOfDigits)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}