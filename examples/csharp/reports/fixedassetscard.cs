// Example: read the Fixed Assets Card report

var client = new ReportsClient("{your-api-key}");
var page = await client.QueryAsync("fixedassetscard", new { date = "2026-01-31", registerTypes = new[] { "1", "2" }, states = new[] { "2" }, extended = true, pageSize = 5000 });

Console.WriteLine($"hasMore: {page.RootElement.GetProperty("hasMore").GetBoolean()}");
foreach (var row in page.RootElement.GetProperty("data").EnumerateArray())
{
    Console.WriteLine(row);
}
