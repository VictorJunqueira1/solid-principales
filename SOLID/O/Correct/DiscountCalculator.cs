using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.O.Correct
{
    public class DiscountCalculator
    {
    public decimal CalculateDiscount(IDiscount discountStrategy, decimal amount)
    {
        return discountStrategy.ApplyDiscount(amount);
    }
    }
}

// Correção: Agora é possível adicionar novos tipos de desconto sem modificar DiscountCalculator. 
// Cada tipo de desconto implementa IDiscount.