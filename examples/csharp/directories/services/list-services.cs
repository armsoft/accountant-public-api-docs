// Example: list services

var client = new ServicesClient("{your-api-key}");
var doc = await client.ListAsync(new { showAlsoClosed = false, pageSize = 5000 });

foreach (var item in doc.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine($"{item.GetProperty("code").GetString()} - {item.GetProperty("name").GetString()}");
}
