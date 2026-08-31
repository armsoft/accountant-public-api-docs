// Example: page through every employee

var client = new EmployeesClient("{your-api-key}");
var page = await client.ListAsync(new { codes = new[] { "0001", "0002" }, pageSize = 5000 });

while (true)
{
    foreach (var item in page.RootElement.GetProperty("data").EnumerateArray())
    {
        Console.WriteLine(item.GetProperty("code").GetString());
    }

    if (!page.RootElement.GetProperty("hasMore").GetBoolean()) break;

    var id = page.RootElement.GetProperty("id").GetString();
    page = await client.ListNextPageAsync(id);
}
