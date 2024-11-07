using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.L.Correct
{
    public class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Area() => Width * Height;
    }
}