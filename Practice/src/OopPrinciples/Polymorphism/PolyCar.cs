using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Polymorphism
{
    public class PolyCar : PolyVehicle
    {
        public int NumberOfDoors { get; set; }
        public int NumberOfWheels { get; set; }
        
        public override void Start()
        {
            System.Console.WriteLine("Starting the car...");
        }

        public override void Stop()
        {
            System.Console.WriteLine("Stopping the car...");
        }

        public override void Accelerate()
        {
            System.Console.WriteLine("Accelerating the car...");
        }

        public override void Brake()
        {
            System.Console.WriteLine("Braking the car...");
        }
    }
}