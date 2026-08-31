// Example: create a received service

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("receivedservice", new
{
    date = "2026-01-15",
    supplierCode = "P0001",
    supplierAccount = "5210",
    currency = "AMD",
    servicesList = new[]
    {
        new { code = "S001", quantity = 1.0, price = 50000.0, vat = true, account = "7110" }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created received service {isn}");
