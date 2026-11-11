// Example: read every page of the Fixed Assets Card report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("fixedassetscard", new { date = "2026-01-31", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
