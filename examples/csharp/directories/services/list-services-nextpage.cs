// Example: page through every service

var client = new ServicesClient("{your-api-key}");
var page = await client.ListAsync(new { showAlsoClosed = false, pageSize = 5000 });

while (true)
{
    foreach (var item in page.RootElement.GetProperty("data").EnumerateArray())
    {
        Console.WriteLine(item.GetProperty("code").GetString());
    }

    if (!page.RootElement.GetProperty("hasMore").GetBoolean()) break;

    var id = page.RootElement.GetProperty("id").GetString();
    page = await client.ListNextPageAsync(id);
}
