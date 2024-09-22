using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice.src.SOLID.D
{
    // high level module (broader scope) coordinating multiple implementations
    public interface IEngine
    {
        void Start();
    }
}