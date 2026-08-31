// Example: create a storage input order

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("storageinputorder", new
{
    date = "2026-01-15",
    storage = "01",
    supplierCode = "P0001",
    currency = "AMD",
    materialsList = new[]
    {
        new { code = "1001", quantity = 10.0, price = 1000.0, vat = true, account = "2110" }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created storage input order {isn}");
