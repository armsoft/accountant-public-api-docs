// Example: delete a employee

var client = new EmployeesClient("{your-api-key}");
var deleted = await client.DeleteAsync("0001");

Console.WriteLine(deleted ? "Deleted" : "Not found");
