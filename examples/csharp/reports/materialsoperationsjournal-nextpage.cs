// Example: read every page of the Materials Operations Journal report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("materialsoperationsjournal", new { startDate = "2026-01-01", endDate = "2026-01-31", storage = "01", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
