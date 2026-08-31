// Example: read every page of the ECR Checks journal

var client = new JournalsClient("{your-api-key}");
var rows = await client.QueryAllAsync("ecrchecks", new { startDate = "2026-01-01", endDate = "2026-01-31", cashDesk = "01", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
