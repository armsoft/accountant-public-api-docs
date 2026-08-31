// Example: create a payment order

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("paymentorder", new
{
    date = "2026-01-15",
    transactionDate = "2026-01-15",
    amount = 10000.0,
    currency = "AMD",
    partnerCode = "P0001",
    paymentAim = "Payment for materials"
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created payment order {isn}");
