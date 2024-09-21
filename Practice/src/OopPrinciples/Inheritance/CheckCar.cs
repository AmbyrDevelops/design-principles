using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Inheritance
{
    public class CheckCar : Car
    {
        public void CheckCarDetails() {
        
            Car car = new Car();
            // Methods shared with the parent class : Vehicle 
            car.Brand = "Toyota";
            car.Model = "Corolla";
            car.Year = 2020;
            car.Start();
            car.Stop();

            // Methods unique to the child class : Car
            car.NumberOfDoors = 4;
            car.NumberOfWheels = 4;
        }
    }
}