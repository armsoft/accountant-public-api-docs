// Example: update a material
// Send the complete object - omitted properties are cleared.

var client = new MaterialsClient("{your-api-key}");
var updated = await client.UpdateAsync("1001", new
{
    code = "1001",
    name = "Sample material",
    unitMeasure = "001",
    group = "01",
    account = "2110",
    wholePrice = 1000,
    retailPrice = 1200
});

Console.WriteLine(updated);
