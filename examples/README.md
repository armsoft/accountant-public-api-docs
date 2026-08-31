# Examples

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api.htm)

Example requests are documented directly in the endpoint pages and guides; ready-to-run C#
samples live in this folder.

## Where to start

- [Getting Started Guide](../docs/getting-started.md)
- [Authentication Guide](../docs/authentication.md)
- [Directories API Reference](../docs/api/directories/README.md)
- [List Materials Example](../docs/api/directories/materials/list.md)
- [Documents API Reference](../docs/api/documents/README.md)
- [Error Handling Guide](../docs/error-handling.md)

## C# Examples

Client wrappers are in [`csharp/directories/`](csharp/directories/),
[`csharp/documents/`](csharp/documents/), [`csharp/journals/`](csharp/journals/) and
[`csharp/reports/`](csharp/reports/):

- [`PartnersClient.cs`](csharp/directories/PartnersClient.cs) — wrapper for Partners endpoints
- [`MaterialsClient.cs`](csharp/directories/MaterialsClient.cs) — wrapper for Materials endpoints
- [`ServicesClient.cs`](csharp/directories/ServicesClient.cs) — wrapper for Services endpoints
- [`EmployeesClient.cs`](csharp/directories/EmployeesClient.cs) — wrapper for Employees endpoints
- [`StoragesClient.cs`](csharp/directories/StoragesClient.cs) — wrapper for Storages endpoints
- [`DocumentsClient.cs`](csharp/documents/DocumentsClient.cs) — wrapper for every document type
- [`JournalsClient.cs`](csharp/journals/JournalsClient.cs) — wrapper for Journals endpoints
- [`ReportsClient.cs`](csharp/reports/ReportsClient.cs) — wrapper for Reports endpoints

Individual operation examples are in the per-directory subfolders (e.g.
`csharp/directories/materials/`, `csharp/directories/partners/`).

## Journals and Reports Examples

- [C# Journals examples](csharp/journals/README.md)
- [C# Reports examples](csharp/reports/README.md)

## Planned additions

- cURL collection for all endpoints
- Postman collection
