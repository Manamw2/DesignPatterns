using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
    internal class EmployeeAdapter
    {
        private Employee _employee;
        public EmployeeAdapter(Employee employee)
        {
            _employee = employee;
        }
        public string FullName => _employee.FullName;
        public IEnumerable<PayItemAdapter> PayItems => _employee.PayItems.Select(u => new PayItemAdapter(u));
    }
}
