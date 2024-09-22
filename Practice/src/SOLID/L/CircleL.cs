using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.L
{
    public class CircleL : ShapeL
    {
        public double Radius { get; set; }
        
        public override double Area => Math.PI * Math.Pow(Radius, 2);   
    }
}