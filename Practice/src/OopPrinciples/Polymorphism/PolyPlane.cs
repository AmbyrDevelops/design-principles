using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Polymorphism
{
    public class PolyPlane : PolyVehicle
    {
        public override void Start()
        {
            Console.WriteLine("Starting the plane...");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping the plane...");
        }

        public override void Accelerate()
        {
            Console.WriteLine("Accelerating the plane...");
        }

        public override void Brake()
        {
            Console.WriteLine("Braking the plane...");
        }

        public void TakeOff()
        {
            Console.WriteLine("Taking off...");
        }
    }
}