// Example: read every page of the Partners Balances report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("partnersbalances", new { date = "2026-01-31", reportCurrency = "AMD", showZeroRows = false, pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
