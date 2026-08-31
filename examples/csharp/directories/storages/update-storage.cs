// Example: update a storage

var client = new StoragesClient("{your-api-key}");
var updated = await client.UpdateAsync("02", new
{
    code = "02",
    name = "Second storage (renamed)",
    stockkeeper = "0001",
    address = "Yerevan",
    isClosed = false
});

Console.WriteLine(updated);
