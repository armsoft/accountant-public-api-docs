// Example: read, update and delete a document by ISN

var client = new DocumentsClient("{your-api-key}");
var isn = "3fa85f64-5717-4562-b3fc-2c963f66afa6";

var document = await client.GetAsync("invoice", isn);
if (document is null)
{
    Console.WriteLine("Not found");
    return;
}

Console.WriteLine(document.Value.GetProperty("documentNumber").GetString());

// The same ISN is used for update and delete.
await client.DeleteAsync("invoice", isn);
