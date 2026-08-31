// Example: create a retail sale

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("retailsale", new
{
    date = "2026-01-15",
    customer = "P0001",
    cashDesk = "01",
    storage = "01",
    itemList = new[]
    {
        new { type = "1", code = "1001", quantity = 1.0, price = 1200.0, vat = true }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created retail sale {isn}");
