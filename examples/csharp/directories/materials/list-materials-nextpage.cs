// Example: page through every material

var client = new MaterialsClient("{your-api-key}");
var page = await client.ListAsync(new { group = "01", showAlsoClosed = false, pageSize = 5000 });

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
