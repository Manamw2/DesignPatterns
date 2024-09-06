using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;

        //constructor must be private for singleton pattern
        private CurrencyConverter()
        {
            LoadExchangeRate();
        }

        //add lock object to prevent multible inctances when multible threads reach instance creation at same time
        private static object _lock = new object();

        //add static instance of the class
        private static CurrencyConverter _instance;

        //encapsulate the static instance
        public static CurrencyConverter Instance
        {
            get
            {
                //lazy intialization only when when first access the instance
                if(_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new CurrencyConverter();
                        }
                    }
                }
                return _instance;
            }
        }

        private void LoadExchangeRate()
        {
            Thread.Sleep(2000);
            _exchangeRates = new[]
            {
                new ExchangeRate("usd", "sar", 3.75),
                new ExchangeRate("usd", "egp", 30.6),
                new ExchangeRate("sar", "egp", 8.15),
            };
        }
        public double Convert(string baseCurrency, string targetCurrency, int ammount)
        {
            ExchangeRate? rate = _exchangeRates.FirstOrDefault(u => u.BaseCurrency == baseCurrency && u.TargetCurrency == targetCurrency);
            return ammount * rate.Rate;
        }
    }
}
