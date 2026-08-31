// Example: create a overhead expense allocation

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("overheadexpenseallocation", new
{
    date = "2026-01-15",
    supplierCode = "P0001",
    currency = "AMD",
    storage = "01",
    amount = 5000.0,
    materialsList = new[]
    {
        new { code = "1001", quantity = 10.0, inputOrderAmount = 10000.0, account = "2110" }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created overhead expense allocation {isn}");
