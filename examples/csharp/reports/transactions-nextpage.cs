// Example: read every page of the Transactions report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("transactions", new { startDate = "2026-01-01", endDate = "2026-01-31", debitAccount = "2110", showPartners = true, pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
