// Example: create a fixed asset disposal act

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("fixedassetdisposalact", new
{
    date = "2026-01-15",
    outputLocation = "01",
    relievedResponsiblePerson = "0001",
    inventoriesList = new[]
    {
        new
        {
            inventoryNumber = "0000001",
            grossCarryingAmountAccount = "1130",
            depreciationAccount = "1140",
            expenseAccount = "7110"
        }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created fixed asset disposal act {isn}");
