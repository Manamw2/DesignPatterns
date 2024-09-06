using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DiscountStrategy
{
    internal class GoldDiscountStategy : IDiscountStategy
    {
        public double GetDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.1 : 0;
        }
    }
}
