using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DiscountStrategy
{
    internal class DefaultDiscountStategy : IDiscountStategy
    {
        public double GetDiscount(double totalPrice)
        {
            return 0;
        }
    }
}
