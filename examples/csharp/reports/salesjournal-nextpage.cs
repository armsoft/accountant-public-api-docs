// Example: read every page of the Sales Journal report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("salesjournal", new { startDate = "2026-01-01", endDate = "2026-01-31", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
