// Example: delete a partner

var client = new PartnersClient("{your-api-key}");
var deleted = await client.DeleteAsync("P0001");

Console.WriteLine(deleted ? "Deleted" : "Not found");
