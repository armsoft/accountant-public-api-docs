// Example: update a service
// Send the complete object - omitted properties are cleared.

var client = new ServicesClient("{your-api-key}");
var updated = await client.UpdateAsync("S001", new
{
    code = "S001",
    name = "Sample service",
    unitMeasure = "001",
    account = "2110",
    revenueAccount = "6110",
    vat = true
});

Console.WriteLine(updated);
