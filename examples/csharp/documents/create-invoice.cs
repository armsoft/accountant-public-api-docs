// Example: create a invoice

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("invoice", new
{
    date = "2026-01-15",
    customer = "P0001",
    currency = "AMD",
    storage = "01",
    itemList = new[]
    {
        new { type = "1", code = "1001", quantity = 10.0, price = 1000.0, vat = true }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created invoice {isn}");
