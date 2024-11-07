using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.L.Wrong
{
    public class Square : Rectangle
    {
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }
        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}

// Problema: A classe Square altera o comportamento de Rectangle, pois um quadrado deve ter lados iguais, enquanto um retângulo não.
// Isso viola o LSP (Liskov Substituition Principale).