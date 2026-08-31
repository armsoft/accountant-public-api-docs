// Example: read every page of the Invoices journal

var client = new JournalsClient("{your-api-key}");
var rows = await client.QueryAllAsync("invoices", new { startDate = "2026-01-01", endDate = "2026-01-31", partner = "P0001", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
