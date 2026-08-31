// Example: delete a service

var client = new ServicesClient("{your-api-key}");
var deleted = await client.DeleteAsync("S001");

Console.WriteLine(deleted ? "Deleted" : "Not found");
