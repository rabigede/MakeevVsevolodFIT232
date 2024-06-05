using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите через пробел количество шестеренок и количество описаний соединения шестеренок ");
        string[] KolShestIOpis = Console.ReadLine().Split();
        int N = Convert.ToInt32(KolShestIOpis[0]);
        int M = Convert.ToInt32(KolShestIOpis[1]);

        Dictionary<int, int> NomerIZubia = new Dictionary<int, int>();
        Console.WriteLine("Введите через пробел номер шестеренки и количество зубьев у нее ");
        for (int i = 0; i < N; i++)
        {
            string[] stroka = Console.ReadLine().Split();
            int nomer = Convert.ToInt32(stroka[0]);
            int zubia = Convert.ToInt32(stroka[1]);
            NomerIZubia[nomer] = zubia;
        }
        List<(int, int)> soedinenia = new List<(int, int)>();
        Console.WriteLine("Введите через пробел номера двух соединенных шестеренок ");
        for (int j = 0; j < M; j++)
        {
            string[] stroka = Console.ReadLine().Split();
            int S1 = Convert.ToInt32(stroka[0]);
            int S2 = Convert.ToInt32(stroka[1]);
            soedinenia.Add((S1, S2));
        }


        Console.WriteLine("Введите через пробел номера шестеренок, надетых на валы двигателя и кольца канатной дороги, соответственно ");
        string[] strokapred = Console.ReadLine().Split();
        int Z1 = Convert.ToInt32(strokapred[0]);
        int Z2 = Convert.ToInt32(strokapred[1]);

        Console.WriteLine("Введите направление вращения шестеренки, надетой на вал двигателя. Значение -1 соответствует вращению по часовой стрелки, а 1 - против часовой ");
        int V = Convert.ToInt32(Console.ReadLine());

        Dictionary<int, List<int>> graf = new Dictionary<int, List<int>>();
        foreach ((int S1, int S2) in soedinenia)
        {
            if (!graf.ContainsKey(S1))
            {
                graf[S1] = new List<int>();
            }
            if (!graf.ContainsKey(S2))
            {
                graf[S2] = new List<int>();
            }
            graf[S1].Add(S2);
            graf[S2].Add(S1);
        }
        Dictionary<int, int?> napravlenie = new Dictionary<int, int?>();
        Dictionary<int, double?> skorost = new Dictionary<int, double?>();

        foreach (int i in NomerIZubia.Keys)
        {
            napravlenie[i] = null;
            skorost[i] = null;
        }

        napravlenie[Z1] = V;
        skorost[Z1] = 1.0;
        Console.WriteLine("Результат ");
        bool rabota = PoiskvGlubinu(Z1, -1, graf, NomerIZubia, napravlenie, V, skorost);

        if (rabota && napravlenie[Z2] != null)
        {
            int W = napravlenie[Z2].Value;
            double O = skorost[Z2].Value;
            Console.WriteLine("1");
            Console.WriteLine(W);
            Console.WriteLine(O.ToString("F3"));
        }
        else
        {
            Console.WriteLine("-1");
        }
        Console.ReadKey();
    }
    static bool PoiskvGlubinu(int usel, int roditel, Dictionary<int, List<int>> graf, Dictionary<int, int> NomerIZubia, Dictionary<int, int?> napravlenie, int Z1_napravlenie, Dictionary<int, double?> skorost)
    {
        foreach (int neighbor in graf[usel])
        {
            if (neighbor == roditel)
                continue;
            if (napravlenie[neighbor] == null)
            {
                napravlenie[neighbor] = -napravlenie[usel];
                skorost[neighbor] = skorost[usel] * NomerIZubia[usel] / NomerIZubia[neighbor];
                if (!PoiskvGlubinu(neighbor, usel, graf, NomerIZubia, napravlenie, Z1_napravlenie, skorost))
                    return false;
            }
            else if (napravlenie[neighbor] != -napravlenie[usel])
                return false;
        }
        return true;
    }

}