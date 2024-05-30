using System;
using System.Linq;

class Auto
{
    public bool isWashed = false;
    public string brand;

    public Auto(string brand)
    {
        this.isWashed = false;
        this.brand = brand;
    }
}

class Garage
{
    public Auto[] autos = new Auto[] { };

    public Garage(Auto[] autos)
    {
        this.autos = autos;
    }
}

class CarWash
{
    public static void Wash(Auto automobile)
    {
        automobile.isWashed = true;
    }
}

class Delegates
{
    public delegate void CarFunction(Auto automobile);

    public static void Main(string[] args)
    {
        CarFunction wash = CarWash.Wash;

        Garage garage = new Garage(new Auto[] {
        new Auto("Машина №1"),
        new Auto("Машина №2"),
        new Auto("Машина №3")
      });

        foreach (var auto in garage.autos)
        {
            Console.WriteLine($"{auto.brand}: Чистая ли машина: {auto.isWashed}");
        }

        Console.WriteLine("\n*Ведётся процесс помывки машин*\n");

        foreach (var auto in garage.autos)
        {
            wash(auto);
        }

        foreach (var auto in garage.autos)
        {
            Console.WriteLine($"{auto.brand}: Чистая ли машина: {auto.isWashed}");
        }
        Console.ReadKey();
    }
}