// Example: create a storage

var client = new StoragesClient("{your-api-key}");
var created = await client.CreateAsync(new
{
    code = "02",
    name = "Second storage",
    stockkeeper = "0001",
    address = "Yerevan"
});

Console.WriteLine(created);
