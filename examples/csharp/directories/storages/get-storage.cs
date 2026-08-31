// Example: get a storage by code

var client = new StoragesClient("{your-api-key}");
var storage = await client.GetAsync("01");

Console.WriteLine(storage?.GetProperty("name").GetString() ?? "Not found");
