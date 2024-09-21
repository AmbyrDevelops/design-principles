using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Polymorphism
{
    public class PolyVehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public virtual void Start()
        {
            System.Console.WriteLine("Inspecting vehicle start...");
        }

        public virtual void Stop()
        {
            System.Console.WriteLine("Inspecting the stop...");
        }

        public virtual void Accelerate()
        {
            System.Console.WriteLine("Inspecting vehicle acceleration...");
        }

        public virtual void Brake()
        {
            System.Console.WriteLine("Inspecting vehicle braking...");
        }
    }
}