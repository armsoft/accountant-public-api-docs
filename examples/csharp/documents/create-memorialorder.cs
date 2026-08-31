// Example: create a memorial order

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("memorialorder", new
{
    date = "2026-01-15",
    amount = 10000.0,
    currency = "AMD",
    transactionsList = new[]
    {
        new { debitAccount = "2110", creditAccount = "5210", amount = 10000.0 }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created memorial order {isn}");
