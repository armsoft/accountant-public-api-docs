# C# Directory Examples

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_directories.htm)

Client wrappers:

- [`PartnersClient.cs`](PartnersClient.cs)
- [`MaterialsClient.cs`](MaterialsClient.cs)
- [`ServicesClient.cs`](ServicesClient.cs)
- [`EmployeesClient.cs`](EmployeesClient.cs)
- [`StoragesClient.cs`](StoragesClient.cs)

Per-operation examples live in the sub-folders:
[`partners/`](partners/), [`materials/`](materials/), [`services/`](services/),
[`employees/`](employees/), [`storages/`](storages/).

All four paginated directories share the same shape, so the same code works for each of them —
only the client class and the filter object change.

See [Directories API](../../../docs/api/directories/README.md) for the endpoint reference.
