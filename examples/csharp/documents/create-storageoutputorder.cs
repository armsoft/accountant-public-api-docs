// Example: create a storage output order

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("storageoutputorder", new
{
    date = "2026-01-15",
    storage = "01",
    expenseAccount = "7110",
    materialsList = new[]
    {
        new { code = "1001", quantity = 2.0, amount = 2000.0 }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created storage output order {isn}");
