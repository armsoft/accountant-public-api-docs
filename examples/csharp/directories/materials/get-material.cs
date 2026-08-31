// Example: get a single material by code

var client = new MaterialsClient("{your-api-key}");
var material = await client.GetAsync("1001");

if (material is null)
{
    Console.WriteLine("Not found");
}
else
{
    Console.WriteLine(material.Value.GetProperty("name").GetString());
}
