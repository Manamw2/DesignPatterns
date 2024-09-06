// See https://aka.ms/new-console-template for more information

using Singleton;

while (true)
{
    Console.WriteLine("Enter base currency");
    string baseCurrency = Console.ReadLine();
    Console.WriteLine("Enter target currency");
    string targetCurrency = Console.ReadLine();
    Console.WriteLine("Enter ammount");
    int ammount = int.Parse(Console.ReadLine());
    double newValue = CurrencyConverter.Instance.Convert(baseCurrency, targetCurrency, ammount);
    Console.WriteLine(newValue.ToString());
    Console.WriteLine("------------------------------------------");
}