# C# Report Examples

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_reports.htm)

- [`ReportsClient.cs`](ReportsClient.cs) — one wrapper covering every report

- [`accountsbalances.cs`](accountsbalances.cs) / [`accountsbalances-nextpage.cs`](accountsbalances-nextpage.cs) — Accounts Balances
- [`accountsturnover.cs`](accountsturnover.cs) / [`accountsturnover-nextpage.cs`](accountsturnover-nextpage.cs) — Accounts Turnover
- [`transactions.cs`](transactions.cs) / [`transactions-nextpage.cs`](transactions-nextpage.cs) — Transactions
- [`partnersbalances.cs`](partnersbalances.cs) / [`partnersbalances-nextpage.cs`](partnersbalances-nextpage.cs) — Partners Balances
- [`partnerstransactions.cs`](partnerstransactions.cs) / [`partnerstransactions-nextpage.cs`](partnerstransactions-nextpage.cs) — Partners Transactions
- [`materialsbalances.cs`](materialsbalances.cs) / [`materialsbalances-nextpage.cs`](materialsbalances-nextpage.cs) — Materials Balances
- [`materialsoperationsjournal.cs`](materialsoperationsjournal.cs) / [`materialsoperationsjournal-nextpage.cs`](materialsoperationsjournal-nextpage.cs) — Materials Operations Journal
- [`storageinputordersandreceivedservices.cs`](storageinputordersandreceivedservices.cs) / [`storageinputordersandreceivedservices-nextpage.cs`](storageinputordersandreceivedservices-nextpage.cs) — Storage Input Orders and Received Services
- [`calculateddata.cs`](calculateddata.cs) / [`calculateddata-nextpage.cs`](calculateddata-nextpage.cs) — Calculated Data

`QueryAllAsync` walks the pages for you; `QueryAsync` / `NextPageAsync` give you manual control.

See [Reports API](../../../docs/api/reports/README.md) for the endpoint reference.
