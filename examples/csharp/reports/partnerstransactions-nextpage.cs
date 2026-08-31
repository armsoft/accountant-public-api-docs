// Example: read every page of the Partners Transactions report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("partnerstransactions", new { startDate = "2026-01-01", endDate = "2026-01-31", debitPartner = "P0001", pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
