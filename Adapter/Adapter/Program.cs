
using Adapter.Adapters;
using Adapter.Data;
using System.Text;
using System.Text.Json;

var url = "https://localhost:7299/api/PayrollCalculator";
var reader = new EmployeeDataReader();
var employees = reader.GetEmployees();

var client = new HttpClient();
foreach (var employee in employees)
{
    var request = new HttpRequestMessage(HttpMethod.Post, url);
    var employeeAdapter = new EmployeeAdapter(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json");
    
    var response = client.SendAsync(request).Result;
    var responseJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responseJson);

    Console.WriteLine("salary for employee " + employee.FullName + " as of today = " + salary);
}
Console.ReadKey();