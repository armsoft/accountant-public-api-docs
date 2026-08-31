// Example: read the Storage Input Orders and Received Services report

var client = new ReportsClient("{your-api-key}");
var page = await client.QueryAsync("storageinputordersandreceivedservices", new { startDate = "2026-01-01", endDate = "2026-01-31", pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
