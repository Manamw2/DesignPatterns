using Strategy.Models;
using Strategy.DiscountStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Data
{
    internal class CustomerDataReader
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return new[]
            {
                new Customer()
                {
                    Id = 1,
                    Name = "Mahmoud Amr",
                    Category = CustomerCategory.Default
                },
                new Customer()
                {
                    Id = 2,
                    Name = "Nabil Amr",
                    Category = CustomerCategory.Silver
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Moastafa Amr",
                    Category = CustomerCategory.Gold
                }
            };
        }
    }
}
