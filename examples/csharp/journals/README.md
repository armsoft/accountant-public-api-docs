# C# Journal Examples

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_journals.htm)

- [`JournalsClient.cs`](JournalsClient.cs) — one wrapper covering every journal

- [`alldocuments.cs`](alldocuments.cs) / [`alldocuments-nextpage.cs`](alldocuments-nextpage.cs) — All Documents
- [`invoices.cs`](invoices.cs) / [`invoices-nextpage.cs`](invoices-nextpage.cs) — Invoices
- [`ecrchecks.cs`](ecrchecks.cs) / [`ecrchecks-nextpage.cs`](ecrchecks-nextpage.cs) — ECR Checks

`QueryAllAsync` walks the pages for you; `QueryAsync` / `NextPageAsync` give you manual control.

See [Journals API](../../../docs/api/journals/README.md) for the endpoint reference.
