// Example: read the Partners Transactions report

var client = new ReportsClient("{your-api-key}");
var page = await client.QueryAsync("partnerstransactions", new { startDate = "2026-01-01", endDate = "2026-01-31", debitPartner = "P0001", pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
