﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int numberOfCars;
        public List<Car> ParkingLot { get; set; } = new List<Car>();
    }
}
