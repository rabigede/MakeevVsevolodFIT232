using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carwashing

/*
    Разработать программу, которая реализует взаимодействие следующих классов:
    автомобиль, гараж (гараж это коллекция автомобилей), 
    мойка (независимое предприятие, только принимает автомобили).
    Необходимо выполнить помывку всех автомобилей, делегируя выполнение работы мойке.
*/

{
    public class Program
    {
        public static void Main()
        {
            // Создаем гараж с несколькими автомобилями
            Garage garage = new Garage();
            garage.AddCar(new Car());
            garage.AddCar(new Car());
            garage.AddCar(new Car());

            // Создаем автомойку
            CarWash carWash = new CarWash();

            // Отправляем грязные автомобили на мойку
            foreach (Car car in garage.GetDirtyCars())
            {
                carWash.WashCar(car);
            }

            // Проверяем, что все автомобили чистые
            bool allClean = garage.GetDirtyCars().Count() == 0;
            Console.WriteLine(allClean ? "Все автомобили чистые" : "Не все автомобили чистые");
        }
    }

    public class Car
    {
        public bool IsClean { get; set; }

        public Car()
        {
            IsClean = false;
        }

        public void Wash()
        {
            IsClean = true;
        }
    }

    public class Garage
    {
        private List<Car> _cars;

        public Garage()
        {
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public IEnumerable<Car> GetDirtyCars()
        {
            return _cars.Where(car => !car.IsClean);
        }
    }

    public class CarWash
    {
        public void WashCar(Car car)
        {
            car.Wash();
        }
    }
}
