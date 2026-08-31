// Example: create a cash output order

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("cashoutputorder", new
{
    date = "2026-01-15",
    cashDesk = "01",
    currency = "AMD",
    amount = 10000.0,
    partnerCode = "P0001",
    correspondentAccount = "2510",
    aim = "Cash advance",
    base = "Invoice 0000001"
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created cash output order {isn}");
