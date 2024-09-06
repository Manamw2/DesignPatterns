using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Data
{
    internal class EmployeeDataReader
    {
        public IEnumerable<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    FullName = "Mahmoud Amr",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem {Name = "Mahmoud Amr", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Mediacal Insurance", Value = 150, IsDeduction = true}
                    }
                },
                new Employee()
                {
                    FullName = "Ali Adel",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem {Name = "Basic Salary", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Mediacal Insurance", Value = -150}
                    }
                },
                new Employee()
                {
                    FullName = "Mona Hassan",
                    PayItems = new List<PayItem>()
                    {
                        new PayItem {Name = "Basic Salary", Value = 1000},
                        new PayItem {Name = "Transportation", Value = 250},
                        new PayItem {Name = "Mediacal Insurance", Value = -150}
                    }
                }
            };
        }
    }
}
