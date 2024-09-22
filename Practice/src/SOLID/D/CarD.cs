using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.D
{
    public class CarD
    {
        private IEngine engine;

        public CarD(IEngine engine)
        {
            this.engine = engine;
        }

        public void Start() => engine.Start();
    }
}