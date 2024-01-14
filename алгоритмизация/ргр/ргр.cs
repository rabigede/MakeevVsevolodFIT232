using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 10. Программа с помощью датчика случайных чисел выбирает число
             * в диапазоне от 0 до N. 
             * Угадать это число с ограничением числа попыток и без */

            Console.Write("Введите число N: ");
            int n  = int.Parse(Console.ReadLine());

            Console.WriteLine("\nВыберите формат игры:\n1. Пять попыток.\n2. Без ограничений.");
            int game_type = int.Parse(Console.ReadLine());
            if ((game_type != 1)&&(game_type != 2))
            {
                Console.WriteLine("\nВы допустили роковую ошибку, попытавшись обмануть меня. " +
                    "Я больше не буду с вами играть. :/\n");
                return;
            }


            var rand = new Random();
            int number = rand.Next(n+1);
            int k = 0;
            int k2 = 0;

            while ((k == 0)&&(k2 < 5))
            {
                Console.Write("\nПопробуйте угадать число: ");
                int guess = int.Parse(Console.ReadLine());

                if (number == guess)
                {
                    k = 1;
                    Console.WriteLine("\n^_^ Число отгадано! :D");
                }
                if (number > guess)
                {
                    Console.WriteLine("Загаданное число больше.");
                    if (game_type == 1)
                    {
                        k2 += 1;
                    }
                }
                if (number < guess)
                {
                    Console.WriteLine("Загаданное число меньше.");
                    if (game_type == 1)
                    {
                        k2 += 1;
                    }
                }
                if ((k2==5)&&(number!=guess))
                {
                    Console.WriteLine("\nУвы, попытки закончились, вы проиграли.. T_T\n");
                }
            }

        }
    }
}
