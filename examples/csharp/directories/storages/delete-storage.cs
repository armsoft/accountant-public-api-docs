// Example: delete a storage

var client = new StoragesClient("{your-api-key}");
var deleted = await client.DeleteAsync("02");

Console.WriteLine(deleted ? "Deleted" : "Not found");
