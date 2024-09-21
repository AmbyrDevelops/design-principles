using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Polymorphism
{
    public class PolyMotorcycle : PolyVehicle
    {
        public override void Start()
        {
            Console.WriteLine("Starting the motorcycle...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the motorcycle...");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Accelerating the motorcycle...");
        }

        public override void Brake()
        {
            Console.WriteLine("Braking the motorcycle...");
        }
    }
}