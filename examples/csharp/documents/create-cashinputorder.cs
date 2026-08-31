// Example: create a cash input order

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("cashinputorder", new
{
    date = "2026-01-15",
    cashDesk = "01",
    currency = "AMD",
    amount = 10000.0,
    partnerCode = "P0001",
    correspondentAccount = "2510",
    base = "Invoice 0000001"
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created cash input order {isn}");
