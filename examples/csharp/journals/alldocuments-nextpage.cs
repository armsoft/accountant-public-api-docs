// Example: read every page of the All Documents journal

var client = new JournalsClient("{your-api-key}");
var rows = await client.QueryAllAsync("alldocuments", new { startDate = "2026-01-01", endDate = "2026-01-31", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
