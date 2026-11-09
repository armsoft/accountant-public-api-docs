// Example: delete a materials group

var client = new MaterialsGroupsClient("{your-api-key}");
var deleted = await client.DeleteAsync("00002");

Console.WriteLine(deleted ? "Deleted" : "Not found");
