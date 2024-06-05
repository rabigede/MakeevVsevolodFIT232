using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите количество волшебных слов = ");
        int kolvo = Convert.ToInt32(Console.ReadLine());
        List<string> spisok = new List<string>();
        string slovo;
        Console.WriteLine("Введите волшебные слова через enter = ");
        for (int m = 0; m < kolvo; m++)
        {
            slovo = Console.ReadLine();
            if (slovo.Length > 15)
            {
                Console.WriteLine("Слово слишком длинное, давай поменьше ");
                break;
            }
            else if (string.IsNullOrEmpty(slovo))
            {
                Console.WriteLine("Строка пустая, нет ни начальной, ни конечной буквы ");
                break;
            }
            spisok.Add(slovo);
        }

        Console.WriteLine("Введите количество букв, на которые могут начинаться искомые волшебные слова = ");
        int nachalo = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> bukvinach = new Dictionary<string, int>();
        if (nachalo <= 26)
        {
            for (int i = 0; i < nachalo; i++)
            {
                Console.WriteLine("Введите через пробел букву и количество слов, начинающихся на эту букву, которые можно использовать. Enter - переход на следующую строку =  ");
                string[] delitel = Console.ReadLine().Split(' ');
                string key = delitel[0];
                int value = Convert.ToInt32(delitel[1]);

                bukvinach[key] = value;
            }
        }
        else
        {
            Console.WriteLine("Английский алфавит состоит из 26 букв ");
        }

        Console.WriteLine("Введите количество букв, на которые могут оканчиваться искомые волшебные слова = ");
        int konec = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, int> bukvikon = new Dictionary<string, int>();
        if (konec <= 26)
        {
            for (int j = 0; j < konec; j++)
            {
                Console.WriteLine("Введите через пробел букву и количество слов, оканчивающихся на эту букву, которые можно использовать. Enter - переход на следующую строку = ");
                string[] delitel2 = Console.ReadLine().Split(' ');
                string key2 = delitel2[0];
                int value2 = Convert.ToInt32(delitel2[1]);
                bukvikon[key2] = value2;
            }
        }
        else
        {
            Console.WriteLine("Английский алфавит состоит из 26 букв ");
        }

        int maxresultat = 0;

        foreach (var perestanovki in Perestanovki(spisok))
        {
            int resultat = 0;
            Dictionary<string, int> dbukvinach = new Dictionary<string, int>(bukvinach);
            Dictionary<string, int> dbukvikon = new Dictionary<string, int>(bukvikon);

            foreach (var word in perestanovki)
            {
                string start = word.First().ToString();
                if (dbukvinach.ContainsKey(start) && dbukvinach[start] > 0)
                {
                    dbukvinach[start]--;
                    string end = word.Last().ToString();
                    if (dbukvikon.ContainsKey(end) && dbukvikon[end] > 0)
                    {
                        dbukvikon[end]--;
                        resultat++;
                    }
                    else
                    {
                        dbukvinach[start]++;
                    }
                }
            }
            maxresultat = Math.Max(maxresultat, resultat);
        }

        Console.WriteLine("Результат готов =  " + maxresultat);
    }

    public static IEnumerable<IEnumerable<T>> Perestanovki<T>(IEnumerable<T> list) where T : IEnumerable<char>, IEquatable<T>
    {
        if (list.Count() == 1)
        {
            yield return list;
        }
        else
        {
            foreach (var slova in list)
            {
                var remaining = list.Where(x => !x.Equals(slova));
                foreach (var perestanovki in Perestanovki(remaining))
                {
                    yield return perestanovki.Prepend(slova);
                }
            }
        }
    }
}