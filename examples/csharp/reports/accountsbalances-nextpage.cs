// Example: read every page of the Accounts Balances report

var client = new ReportsClient("{your-api-key}");
var rows = await client.QueryAllAsync("accountsbalances", new { date = "2026-01-31", accountsSection = "2", reportCurrency = "AMD", showZeroRows = false, pageSize = 5000 });

Console.WriteLine($"{rows.Count} rows");
