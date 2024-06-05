using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public struct Person
{
    public int YearOfBirth;
    public string CityOfBirth;
    public string CountryOfBirth;
}

class Program
{
    static void Main()
    {
        List<Person> allPersons = new List<Person>();

        string[] lines = File.ReadAllLines("input.txt");
        foreach (string line in lines)
        {
            string[] data = line.Split(',');
            Person person = new Person
            {
                YearOfBirth = int.Parse(data[0]),
                CityOfBirth = data[1],
                CountryOfBirth = data[2]
            };
            allPersons.Add(person);
        }

        GroupByYearOfBirth(allPersons);
        GroupByCityOfBirth(allPersons);

        Console.WriteLine("Введите страну для фильтрации:");
        string countryFilter = Console.ReadLine();
        FilterByCountry(allPersons, countryFilter);
        Console.ReadKey();
    }

    public static void GroupByYearOfBirth(List<Person> persons)
    {
        var groupedByYear = persons.GroupBy(p => p.YearOfBirth);
        using (StreamWriter sw = new StreamWriter("groupByYear.txt"))
        {
            foreach (var group in groupedByYear)
            {
                sw.WriteLine($"Year: {group.Key}");
                foreach (var person in group)
                {
                    sw.WriteLine($"{person.YearOfBirth}, {person.CityOfBirth}, {person.CountryOfBirth}");
                }
                sw.WriteLine();
            }
        }
    }

    public static void GroupByCityOfBirth(List<Person> persons)
    {
        var groupedByCity = persons.GroupBy(p => p.CityOfBirth);
        using (StreamWriter sw = new StreamWriter("groupByCity.txt"))
        {
            foreach (var group in groupedByCity)
            {
                sw.WriteLine($"City: {group.Key}");
                foreach (var person in group)
                {
                    sw.WriteLine($"{person.YearOfBirth}, {person.CityOfBirth}, {person.CountryOfBirth}");
                }
                sw.WriteLine();
            }
        }
    }

    public static void FilterByCountry(List<Person> persons, string country)
    {
        var filteredByCountry = persons.Where(p => p.CountryOfBirth == country);
        using (StreamWriter sw = new StreamWriter("filterByCountry.txt"))
        {
            foreach (var person in filteredByCountry)
            {
                sw.WriteLine($"{person.YearOfBirth}, {person.CityOfBirth}, {person.CountryOfBirth}");
            }
        }
    }
}