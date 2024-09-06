using Strategy.DiscountStrategy;
using Strategy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Helpers
{
    //the context class
    internal class InvoiceManager
    {
        //common interface of Strategy classes
        private readonly IDiscountStategy _discountStategy;
        public InvoiceManager(IDiscountStategy stategy)
        {
            _discountStategy = stategy;
        }
        
        public Invoice CreateInvoice(Customer customer, double quantity, double price)
        {
            Invoice invoice =  new Invoice()
            {
                Customer = customer,
                Lines = new[]
                {
                    new InvoiceLine()
                    {
                        Quantity = quantity,
                        UnitPrice = price
                    }
                },
            };
            invoice.DiscountPercentage = _discountStategy.GetDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}
