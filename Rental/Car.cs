using System;
using System.Collections.Generic;

namespace Rental
{
    public class Car
    {
        private static List<Car> cars = new List<Car>();
        public string Brand { get; set; }
        public string Model { get; set; }

        public Car() { }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void Create()
        {
            var newCar = new Car(Brand, Model);
            cars.Add(newCar);
            Console.WriteLine("Car has Added");
        }

        public void Delete()
        {
            var car = cars.Find(c => c.Brand == Brand && c.Model == Model);
            if (car != null)
            {
                cars.Remove(car);
                Console.WriteLine($"Car {Brand} {Model} deleted.");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }
        }

        public void Update()
        {
            var car = cars.Find(c => c.Brand == Brand && c.Model == Model);
            if (car != null)
            {
                Console.WriteLine("Enter new Brand:");
                car.Brand = Console.ReadLine();
                Console.WriteLine("Enter new Model:");
                car.Model = Console.ReadLine();
                Console.WriteLine("Car updated successfully.");
            }
            else
            {
                Console.WriteLine("Car not found.");
            }
        }

        public void Get()
        {
            if (cars.Count == 0)
            {
                Console.WriteLine("No cars available.");
            }
            else
            {
                Console.WriteLine("Available cars:");
                foreach (var ar in cars)
                {
                    Console.WriteLine($"Brand: {ar.Brand}, Model: {ar.Model}");
                }
            }
        }
    }
}
