// Example: read the Partners Balances report

var client = new ReportsClient("{your-api-key}");
var page = await client.QueryAsync("partnersbalances", new { date = "2026-01-31", reportCurrency = "AMD", showZeroRows = false, pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
