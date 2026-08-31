// Example: create a fixed asset acquisition

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("fixedassetacquisition", new
{
    inventoryNumber = "0000001",
    name = "Office server",
    inputDate = "2026-01-15",
    exploitationDate = "2026-01-15",
    location = "01",
    responsiblePerson = "0001",
    supplierCode = "P0001",
    financialCost = 500000.0,
    grossCarryingAmountAccount = "1130",
    depreciationAccount = "1140"
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created fixed asset acquisition {isn}");
