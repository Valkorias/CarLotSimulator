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

            CarLot carLot = new CarLot();

            Car car1 = new Car();
            car1.Make = "Lamborghini";
            car1.Model = "Miura";
            car1.Year = 1966;
            car1.EngineNoise = "Zoom zoom zoom";
            car1.HonkNoise = "beeeep";
            car1.IsDrivable = true;

            carLot.ParkingLot.Add(car1);
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");
            Console.WriteLine();
            Console.WriteLine();

            Car car2 = new Car()
            {
                Make = "Dodge",
                Model = "Charger",
                Year = 1969,
                EngineNoise = "intimadating vroom",
                HonkNoise = "General Lee Dixie horn",
                IsDrivable = true
            };
            
            carLot.ParkingLot.Add(car2);
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");
            Console.WriteLine();
            Console.WriteLine();


            Car car3 = new Car(1969, "Chevrolet", "Vrooom", "Loud beep", true, "Camaro");

            carLot.ParkingLot.Add(car3);
            Console.WriteLine($"Number of Cars in the lot is: {CarLot.numberOfCars}");
            Console.WriteLine();
            Console.WriteLine();

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            carLot.ParkingLot = new List<Car>() { car1, car2, car3 };

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
