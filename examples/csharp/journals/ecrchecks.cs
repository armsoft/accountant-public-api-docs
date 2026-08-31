// Example: read the ECR Checks journal

var client = new JournalsClient("{your-api-key}");
var page = await client.QueryAsync("ecrchecks", new { startDate = "2026-01-01", endDate = "2026-01-31", cashDesk = "01", pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
