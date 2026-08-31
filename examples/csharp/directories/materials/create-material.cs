// Example: create a material

var client = new MaterialsClient("{your-api-key}");
var created = await client.CreateAsync(new
{
    code = "1001",
    name = "Sample material",
    unitMeasure = "001",
    group = "01",
    account = "2110",
    wholePrice = 1000,
    retailPrice = 1200
});

Console.WriteLine(created);
