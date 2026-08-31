// Example: create a materials kitting

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("materialskitting", new
{
    date = "2026-01-15",
    storageOutput = "01",
    storageInput = "01",
    kit = "2001",
    quantity = 1.0,
    account = "2110",
    kitComponents = new[]
    {
        new { type = "1", code = "1001", quantity = 2.0, amount = 2000.0, account = "2110" }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created materials kitting {isn}");
