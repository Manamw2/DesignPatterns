using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.DiscountStrategy
{
    internal interface IDiscountStategy
    {
        double GetDiscount(double totalPrice);
    }
}
