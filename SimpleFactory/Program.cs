
using Strategy;
using Strategy.Data;
using Strategy.DiscountStrategy;
using Strategy.Helpers;
using Strategy.Models;

var reader = new CustomerDataReader();
var customers = reader.GetCustomers();

while (true)
{
    Console.WriteLine("Enter Customer Id");
    int id = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter Quantity");
    double quantity = double.Parse(Console.ReadLine());
    Console.WriteLine("Enter price");
    double price = double.Parse(Console.ReadLine());
    var customer = customers.FirstOrDefault(x => x.Id == id);
    //use simple factory instead of implementing logic each time creating InvoiceManager
    IDiscountStategy discountStategy = new CustomerDiscountStrategyFactory().CreateDiscountStrategy(customer.Category);
    InvoiceManager invoiceManager = new InvoiceManager(discountStategy);
    Invoice invoice = invoiceManager.CreateInvoice(customer, quantity, price);
    Console.WriteLine($"New invoice has been created for customer {customer.Name} with total price {invoice.NetPrice}");
    Console.ReadKey();
    Console.WriteLine("-----------------------------------");
}