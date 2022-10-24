using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var carLot = new CarLot();

            var lamborghini = new Car();
            lamborghini.Make = "Lamborghini";
            lamborghini.Model = "Miura";
            lamborghini.Year = 1966;
            lamborghini.EngineNoise = "Zoom zoom zoom";
            lamborghini.HonkNoise = "beeeep";
            lamborghini.IsDrivable = true;

            var dodge = new Car()
            {
                Make = "Dodge",
                Model = "Charger",
                Year = 1969,
                EngineNoise = "intimadating vroom",
                HonkNoise = "General Lee Dixie horn",
                IsDrivable = true
            };

            Car chevrolet = new Car(1969, "Chevrolet", "Vrooom", "Loud beep", true, "Camaro");

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.ParkingLot = new List<Car>() { lamborghini, dodge, chevrolet };

            foreach (var car in carLot.ParkingLot)
            {
                Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                car.MakeEngineNoise();
                car.MakeHonkNoise();
                Console.WriteLine("---------------------------");
            }
        }
    }
}
