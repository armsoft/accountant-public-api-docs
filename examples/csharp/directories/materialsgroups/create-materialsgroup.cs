// Example: create a materials group (omit code to get the next sequential one)

var client = new MaterialsGroupsClient("{your-api-key}");
var created = await client.CreateAsync(new
{
    name = "Stationery",
    parent = "10"
});

Console.WriteLine(created);
