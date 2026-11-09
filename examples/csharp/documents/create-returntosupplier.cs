// Example: create a return to supplier

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("returntosupplier", new
{
    date = "2026-01-20",
    baseDocumentISN = "550e8400-e29b-41d4-a716-446655440000",
    supplierCode = "P0001",
    currency = "AMD",
    storage = "01",
    materialsList = new[]
    {
        new { storage = "01", code = "1001", quantity = 2.0, price = 1000.0 }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created return to supplier {isn}");
