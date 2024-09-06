
using Strategy.DiscountStrategy;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //simple factory class for centeralizaion
    internal class CustomerDiscountStrategyFactory
    {
        public IDiscountStategy CreateDiscountStrategy(CustomerCategory category)
        {
            IDiscountStategy discountStategy = null;
            if (category == CustomerCategory.Default)
                discountStategy = new DefaultDiscountStategy();
            else if (category == CustomerCategory.Silver)
                discountStategy = new SilverDiscountStategy();
            else if (category == CustomerCategory.Gold)
                discountStategy = new GoldDiscountStategy();
            return discountStategy;
        }
    }
}
