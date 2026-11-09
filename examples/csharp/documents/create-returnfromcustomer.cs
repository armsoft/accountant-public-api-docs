// Example: create a return from customer against the original sale

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("returnfromcustomer", new
{
    date = "2026-01-20",
    baseDocumentISN = "550e8400-e29b-41d4-a716-446655440000",
    customer = "P0001",
    currency = "AMD",
    vatCalculationType = "1",
    storage = "01",
    itemList = new[]
    {
        new { type = "1", storage = "01", code = "1001", quantity = 2.0, price = 1000.0, vat = true, expenseAccount = "7110", incomeAccount = "6110" }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created return from customer {isn}");
