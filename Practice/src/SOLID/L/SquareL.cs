using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.L
{
    public class SquareL : ShapeL
    {
        public double Side { get; set; }
        
        public override double Area => Math.Pow(Side, 2);
    }
}