
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
    IDiscountStategy discountStategy = null;
    if (customer.Category == CustomerCategory.Default)
        discountStategy = new DefaultDiscountStategy();
    else if (customer.Category == CustomerCategory.Silver)
        discountStategy = new SilverDiscountStategy();
    else if (customer.Category == CustomerCategory.Gold)
        discountStategy = new GoldDiscountStategy();
    InvoiceManager invoiceManager = new InvoiceManager(discountStategy);
    Invoice invoice = invoiceManager.CreateInvoice(customer, quantity, price);
    Console.WriteLine($"New invoice has been created for customer {customer.Name} with total price {invoice.NetPrice}");
    Console.ReadKey();
    Console.WriteLine("-----------------------------------");
}