// Example: list storages

var client = new StoragesClient("{your-api-key}");
var doc = await client.ListAsync(showAlsoClosed: false);

foreach (var storage in doc.RootElement.EnumerateArray())
{
    Console.WriteLine($"{storage.GetProperty("code").GetString()} - {storage.GetProperty("name").GetString()}");
}
