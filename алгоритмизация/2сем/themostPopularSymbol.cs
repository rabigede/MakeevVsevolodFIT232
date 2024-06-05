using System;
using System.Linq;

namespace SumOfDigitsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 123, 456, 789, 1011, 1213, 1415, 1617, 1819 };

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