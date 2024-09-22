using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.O
{
    public class Triangle : Shape
    {
        public double Base { get; set; }

        public double Height { get; set; }

        public override double CalculateArea()
        {
            return (Base * Height) / 2;
        }
    }
}