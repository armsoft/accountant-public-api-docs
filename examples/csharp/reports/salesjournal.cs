// Example: read the Sales Journal report

var client = new ReportsClient("{your-api-key}");
var page = await client.QueryAsync("salesjournal", new { startDate = "2026-01-01", endDate = "2026-01-31", operationTypes = "R", showVATAmounts = true, pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
