using System;
using System.Collections.Generic;
using CarRental.Models;

namespace CarRental.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var carsStack = new Stack<Car>();
            carsStack.Push(new Car { PlateId = "GD23412" });
            carsStack.Push(new Car { PlateId = "GD23414" });
            carsStack.Push(new Car { PlateId = "GD23413" });

            Console.WriteLine($"Cars on stack {carsStack.Count}");
            var firstCar = carsStack.Pop();
            Console.WriteLine($"Cars on stack {carsStack.Count}");





        }
    }
}
