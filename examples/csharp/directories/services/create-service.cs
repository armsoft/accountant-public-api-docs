// Example: create a service

var client = new ServicesClient("{your-api-key}");
var created = await client.CreateAsync(new
{
    code = "S001",
    name = "Sample service",
    unitMeasure = "001",
    account = "2110",
    revenueAccount = "6110",
    vat = true
});

Console.WriteLine(created);
