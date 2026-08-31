// Example: read every page of the Accounts Turnover report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("accountsturnover", new { startDate = "2026-01-01", endDate = "2026-01-31", reportCurrency = "AMD", showZeroRows = false, pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
