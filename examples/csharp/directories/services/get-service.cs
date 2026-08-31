// Example: get a single service by code

var client = new ServicesClient("{your-api-key}");
var service = await client.GetAsync("S001");

if (service is null)
{
    Console.WriteLine("Not found");
}
else
{
    Console.WriteLine(service.Value.GetProperty("name").GetString());
}
