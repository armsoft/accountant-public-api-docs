// Example: update a partner
// Send the complete object - omitted properties are cleared.

var client = new PartnersClient("{your-api-key}");
var updated = await client.UpdateAsync("P0001", new
{
    code = "P0001",
    name = "Sample partner",
    fullName = "Sample partner LLC",
    taxCode = "01234567",
    group = "01",
    vatPayer = true
});

Console.WriteLine(updated);
