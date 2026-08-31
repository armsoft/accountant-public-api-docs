// Example: delete a material

var client = new MaterialsClient("{your-api-key}");
var deleted = await client.DeleteAsync("1001");

Console.WriteLine(deleted ? "Deleted" : "Not found");
