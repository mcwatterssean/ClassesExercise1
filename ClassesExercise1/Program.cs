using System;
using System.Collections.Generic;

namespace ClassesExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car()
            {
                Make = "Hyundai",
                Model = "Sonata",
                Year = 1999
            };

            Car hisCar = new Car();
            hisCar.Make = "Ford";
            hisCar.Model = "Focus";
            hisCar.Year = 2013;

            var chevy = new Car( "Chevy", "Impala", 2001);

            var carList = new List<Car>() { myCar, hisCar, chevy };

            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} { vehicle.Model} { vehicle.Year}");
            }    



        }
    }
}
