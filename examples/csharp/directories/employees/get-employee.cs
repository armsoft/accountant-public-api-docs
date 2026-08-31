// Example: get a single employee by code

var client = new EmployeesClient("{your-api-key}");
var employee = await client.GetAsync("0001");

if (employee is null)
{
    Console.WriteLine("Not found");
}
else
{
    Console.WriteLine(employee.Value.GetProperty("fullName").GetString());
}
