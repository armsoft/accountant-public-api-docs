// Example: read every page of the Materials Balances report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("materialsbalances", new { date = "2026-01-31", storage = "01", showZeroRows = false, pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
