// Example: list materials

var client = new MaterialsClient("{your-api-key}");
var doc = await client.ListAsync(new { group = "01", showAlsoClosed = false, pageSize = 5000 });

foreach (var item in doc.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine($"{item.GetProperty("code").GetString()} - {item.GetProperty("name").GetString()}");
}
