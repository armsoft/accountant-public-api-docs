// Example: read the Calculated Data (wages) report

var client = new ReportsClient("{your-api-key}");
var page = await client.QueryAsync("calculateddata", new { startDate = "2026-01-01", endDate = "2026-01-31", department = "01", extended = false, pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
