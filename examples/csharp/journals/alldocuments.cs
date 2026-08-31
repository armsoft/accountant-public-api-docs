// Example: read the All Documents journal

var client = new JournalsClient("{your-api-key}");
var page = await client.QueryAsync("alldocuments", new { startDate = "2026-01-01", endDate = "2026-01-31", pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
