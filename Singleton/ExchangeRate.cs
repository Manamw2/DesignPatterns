using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class ExchangeRate
    {
        public ExchangeRate(string baseCurrnency, string targetCurrency, double rate)
        {
            BaseCurrency = baseCurrnency;
            TargetCurrency = targetCurrency;
            Rate = rate;
        }
        public string BaseCurrency { get; }
        public string TargetCurrency { get; }
        public double Rate { get; }
    }
}
