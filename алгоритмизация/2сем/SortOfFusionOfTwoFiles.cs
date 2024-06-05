using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveEverySecondElement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "Hello", "World", "This", "is", "a", "test" };

            // Запрос для отбора элементов четной длины
            var evenLengthStrings = strings.Where(s => s.Length % 2 == 0);

            Console.WriteLine("Элементы четной длины:");
            foreach (string s in evenLengthStrings)
            {
                Console.WriteLine(s);
            }

            // Удаление каждого второго элемента
            strings.RemoveAt(1);
            strings.RemoveAt(3);
            strings.RemoveAt(5);

            // Запрос для повторного отбора элементов четной длины
            evenLengthStrings = strings.Where(s => s.Length % 2 == 0);

            Console.WriteLine("\nЭлементы четной длины после удаления:");
            foreach (string s in evenLengthStrings)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}