using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapters
{
    internal class PayItemAdapter
    {
        private readonly PayItem _payItem;
        public PayItemAdapter(PayItem payItem)
        {
            _payItem = payItem;
        }
        public string Name => _payItem.Name;
        public decimal Value => _payItem.IsDeduction? _payItem.Value * -1 : _payItem.Value;
    }
}
