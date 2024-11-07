using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solid.SOLID.O.Correct
{
    public interface IDiscount
    {
        decimal ApplyDiscount(decimal amount);
    }

    public class RegularDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal amount) => amount * 0.1m;
    }

    public class PremiumDiscount : IDiscount
    {
        public decimal ApplyDiscount(decimal amount) => amount * 0.2m;
    }
}