using System;
using System.Linq;

namespace LastDigitMultipleOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] numbers = { 123, 456, 789, 1011, 1213, 1415, 1617, 1819 };

            var a = from n in numbers
                    where n % 10 % 3 == 0
                    select n;

            Console.WriteLine("Элементы с последней цифрой, кратной 3:");
            foreach (int n in a)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}