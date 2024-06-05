using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {


        Console.WriteLine("Введите исходную фразу в формате аборигенов Тау-Кита ");
        string taukita;
        taukita = Console.ReadLine();
        List<string> norm = new List<string>(taukita.Split(' '));

        for (int f = 0; f < (norm.Count / 2); f++)
        {
            for (int m = 0; m < norm.Count; m++)
            {

                if (norm.Count % 2 != 0)
                {

                    List<string> pervoe = new List<string>(norm.GetRange(0, 1));
                    List<string> sredn = new List<string>(norm.GetRange(1, norm.Count - (2 * f + 2)));
                    List<string> tretii = new List<string>(norm.GetRange(norm.Count - (2 * f + 1), 2 * f + 1));
                    norm.Clear();
                    norm.AddRange(sredn);
                    norm.AddRange(pervoe);
                    norm.AddRange(tretii);
                    break;
                }
                else
                {

                    if (f == 0)
                    {
                        List<string> pervoe2 = new List<string>(norm.GetRange(0, 1));
                        List<string> sredn2 = new List<string>(norm.GetRange(1, norm.Count - 1));
                        norm.Clear();
                        norm.AddRange(sredn2);
                        norm.AddRange(pervoe2);
                        break;


                    }
                    else
                    {
                        List<string> pervoe3 = new List<string>(norm.GetRange(0, 1));
                        List<string> sredn3 = new List<string>(norm.GetRange(1, norm.Count - (2 * f + 1)));
                        List<string> tretii3 = new List<string>(norm.GetRange(norm.Count - 2 * f, 2 * f));
                        norm.Clear();
                        norm.AddRange(sredn3);
                        norm.AddRange(pervoe3);
                        norm.AddRange(tretii3);
                        break;


                    }
                }
            }
        }
        for (int j = 0; j < norm.Count; j++)
        {
            string resultat = norm[j];
            for (int i = 0; i < (norm[j].Length) / 2; i++)
            {

                if (norm[j].Length % 2 != 0)
                {

                    string pn = resultat.Substring(0, 1);
                    string sredn = resultat.Substring(1, resultat.Length - (2 * i + 2));
                    string tretn = resultat.Substring(1 + (resultat.Length - (2 * i + 2)));
                    resultat = sredn + pn + tretn;

                }
                else
                {

                    string p = resultat.Substring(0, 1);
                    string sred = resultat.Substring(1, resultat.Length - (2 * i + 1));
                    string tret = resultat.Substring(1 + (resultat.Length - (2 * i + 1)));
                    resultat = sred + p + tret;

                }
            }
            norm[j] = resultat;
        }
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", norm));
    }
}