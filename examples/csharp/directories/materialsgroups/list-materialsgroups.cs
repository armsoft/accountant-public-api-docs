// Example: list materials groups

var client = new MaterialsGroupsClient("{your-api-key}");
var doc = await client.ListAsync();

foreach (var group in doc.RootElement.EnumerateArray())
{
    Console.WriteLine($"{group.GetProperty("code").GetString()} - {group.GetProperty("name").GetString()}");
}
