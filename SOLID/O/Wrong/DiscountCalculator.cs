using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.O.Wrong
{
    public class DiscountCalculator
    {
        public decimal CalculateDiscount(string customerType, decimal amount)
        {
            if (customerType == "Regular")
                return amount * 0.1m;
            else if (customerType == "Premium")
                return amount * 0.2m;
            return 0;
        }
    }
}

// Problema: Sempre que um novo tipo de desconto é adicionado, o código precisa ser modificado
// Violando o OCP (Open-Closed Principale).