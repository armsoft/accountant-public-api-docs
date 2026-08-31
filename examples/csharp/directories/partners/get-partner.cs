// Example: get a single partner by code

var client = new PartnersClient("{your-api-key}");
var partner = await client.GetAsync("P0001");

if (partner is null)
{
    Console.WriteLine("Not found");
}
else
{
    Console.WriteLine(partner.Value.GetProperty("name").GetString());
}
