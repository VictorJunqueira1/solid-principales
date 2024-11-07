using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.L.Correct
{
    public class Square : IShape
    {
        public int Side { get; set; }
        public int Area() => Side * Side;
    }
}

// Correção: Square e Rectangle implementam a interface IShape independentemente. 
// Cada um calcula sua área sem interferir no comportamento do outro.