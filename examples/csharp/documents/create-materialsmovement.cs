// Example: create a materials movement

var client = new DocumentsClient("{your-api-key}");
var created = await client.CreateAsync("materialsmovement", new
{
    date = "2026-01-15",
    storageOutput = "01",
    storageInput = "02",
    materialsList = new[]
    {
        new { code = "1001", quantity = 3.0, amount = 3000.0, account = "2110" }
    }
});

var isn = created.GetProperty("isn").GetString();
Console.WriteLine($"Created materials movement {isn}");
