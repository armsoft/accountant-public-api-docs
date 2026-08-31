// Example: list employees

var client = new EmployeesClient("{your-api-key}");
var doc = await client.ListAsync(new { codes = new[] { "0001", "0002" }, pageSize = 5000 });

foreach (var item in doc.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine($"{item.GetProperty("code").GetString()} - {item.GetProperty("fullName").GetString()}");
}
