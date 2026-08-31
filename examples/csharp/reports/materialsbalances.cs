// Example: read the Materials Balances report

var client = new ReportsClient("{your-api-key}");
var page = await client.QueryAsync("materialsbalances", new { date = "2026-01-31", storage = "01", showZeroRows = false, pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
