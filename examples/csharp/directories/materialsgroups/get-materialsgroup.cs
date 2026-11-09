// Example: get a materials group by code

var client = new MaterialsGroupsClient("{your-api-key}");
var group = await client.GetAsync("10");

Console.WriteLine(group?.GetProperty("name").GetString() ?? "Not found");
