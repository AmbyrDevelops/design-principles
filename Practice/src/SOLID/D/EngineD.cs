using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.D
{
    // low level module deals with specific details
    public class EngineD : IEngine
    {
        public void Start() => Console.WriteLine("Engine started");
    }
}