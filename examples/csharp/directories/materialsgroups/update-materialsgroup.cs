// Example: rename a materials group

var client = new MaterialsGroupsClient("{your-api-key}");
var updated = await client.UpdateAsync("00002", new
{
    name = "Office stationery"
});

Console.WriteLine(updated);
