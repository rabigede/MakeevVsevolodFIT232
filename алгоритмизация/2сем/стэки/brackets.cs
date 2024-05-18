using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RPN();
        }
        static void RPN()
        {
            Console.Write("Введите выражение в обратной польской записи: ");
            string rpn = Console.ReadLine();

            try
            {
                int result = calculateRPN(rpn);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        static int calculateRPN(string rpn)
        {
            Stack<int> stack = new Stack<int>();

            foreach (char a in rpn)
            {
                if (char.IsDigit(a))
                {
                    stack.Push(a - '0');
                }
                else if (IsOperator(a))
                {
                    int operand2 = stack.Pop();
                    int operand1 = stack.Pop();

                    if (a == '/' && operand2 == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль.");
                    }

                    stack.Push(calculation(operand1, operand2, a));
                }
                else if (!char.IsWhiteSpace(a)) // Проверка на недопустимые символы
                {
                    throw new ArgumentException("Недопустимый символ в выражении.");
                }
            }

            if (stack.Count != 1)
            {
                throw new ArgumentException("Неправильное выражение в обратной польской записи.");
            }

            return stack.Pop();
        }

        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }
        static int calculation(int a, int b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return a / b;
                default: throw new ArgumentException("Неизвестный оператор");
            }
        }
    }

}
