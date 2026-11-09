// Example: create a non-cash prepayment

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("noncashprepayment", new
{
    date = "2026-01-15",
    cashDesk = "01",
    currencyAmount = 50000.0,
    amount = 50000.0,
    customer = "P0001"
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created non-cash prepayment {isn}");
