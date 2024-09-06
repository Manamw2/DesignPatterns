using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Models
{
    internal class Invoice
    {
        public Customer Customer { get; set; }
        public IEnumerable<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(u => u.Quantity * u.UnitPrice);
        public double DiscountPercentage { get; set; }
        public double NetPrice => TotalPrice - DiscountPercentage * TotalPrice;
    }
}
