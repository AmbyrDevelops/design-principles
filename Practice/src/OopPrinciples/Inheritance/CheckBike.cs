using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Inheritance
{
    public class CheckBike : Bike
    {
        public void CheckBikeDetails() {
        
            Bike bike = new Bike();
            // Methods shared with the parent class : Vehicle 
            bike.Brand = "Honda";
            bike.Model = "CBR";
            bike.Year = 2020;
            bike.Start();
            bike.Stop();

            // Methods unique to the child class : Bike
            bike.NumberOfWheels = 2;
        }
    }
}