// Example: read every page of the Calculated Data (wages) report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("calculateddata", new { startDate = "2026-01-01", endDate = "2026-01-31", department = "01", extended = true, pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
