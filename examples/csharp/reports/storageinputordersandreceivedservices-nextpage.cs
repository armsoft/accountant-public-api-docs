// Example: read every page of the Storage Input Orders and Received Services report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("storageinputordersandreceivedservices", new { startDate = "2026-01-01", endDate = "2026-01-31", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
