using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.OopPrinciples.Inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            System.Console.WriteLine("Starting the vehicle...");
        }

        public void Stop()
        {
            System.Console.WriteLine("Stopping the vehicle...");
        }

        public void Accelerate()
        {
            System.Console.WriteLine("Accelerating the vehicle...");
        }

        public void Brake()
        {
            System.Console.WriteLine("Braking the vehicle...");
        }
    }
}