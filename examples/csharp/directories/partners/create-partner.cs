// Example: create a partner

var client = new PartnersClient("{your-api-key}");
var created = await client.CreateAsync(new
{
    code = "P0001",
    name = "Sample partner",
    fullName = "Sample partner LLC",
    taxCode = "01234567",
    group = "01",
    vatPayer = true
});

Console.WriteLine(created);
