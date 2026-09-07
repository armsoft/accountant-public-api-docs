# Reports API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_reports.htm)

Reports endpoints map to `ReportsController` in API version `v1`. Every report takes its own
parameter object, returns paginated rows, and has a matching `/nextpage` call.

## Documentation links

- [Accounts Balances Online docs](https://online.armsoft.am/acc7/rest_api_account_balances.htm)
- [Accounts Turnover Online docs](https://online.armsoft.am/acc7/rest_api_accounts_turnover.htm)
- [Transactions Online docs](https://online.armsoft.am/acc7/rest_api_transactions.htm)
- [Partners Balances Online docs](https://online.armsoft.am/acc7/rest_api_partners_balances.htm)
- [Partners Transactions Online docs](https://online.armsoft.am/acc7/rest_api_partners_transactions.htm)
- [Materials Balances Online docs](https://online.armsoft.am/acc7/rest_api_materials_balances.htm)
- [Materials Operations Journal Online docs](https://online.armsoft.am/acc7/rest_api_materials_operations_journal.htm)
- [Storage Input Orders and Received Services Online docs](https://online.armsoft.am/acc7/rest_api_storageinputorderandrecievedservices.htm)
- [Calculated Data Online docs](https://online.armsoft.am/acc7/rest_api_reports_calculateddata.htm)

## Endpoints

- [Accounts Balances](accountsbalances.md) / [Next Page](accountsbalances-nextpage.md)
- [Accounts Turnover](accountsturnover.md) / [Next Page](accountsturnover-nextpage.md)
- [Transactions](transactions.md) / [Next Page](transactions-nextpage.md)
- [Partners Balances](partnersbalances.md) / [Next Page](partnersbalances-nextpage.md)
- [Partners Transactions](partnerstransactions.md) / [Next Page](partnerstransactions-nextpage.md)
- [Materials Balances](materialsbalances.md) / [Next Page](materialsbalances-nextpage.md)
- [Materials Operations Journal](materialsoperationsjournal.md) / [Next Page](materialsoperationsjournal-nextpage.md)
- [Storage Input Orders and Received Services](storageinputordersandreceivedservices.md) / [Next Page](storageinputordersandreceivedservices-nextpage.md)
- [Calculated Data](calculateddata.md) / [Next Page](calculateddata-nextpage.md)

## Overview

| Report | Route | Contents |
|--------|-------|----------|
| [Accounts Balances](accountsbalances.md) | `/v1/reports/accountsbalances` | Synthetic account balances as of a given date |
| [Accounts Turnover](accountsturnover.md) | `/v1/reports/accountsturnover` | Account turnover for a period |
| [Transactions](transactions.md) | `/v1/reports/transactions` | The general-ledger transactions journal for a period |
| [Partners Balances](partnersbalances.md) | `/v1/reports/partnersbalances` | Partner balances as of a given date |
| [Partners Transactions](partnerstransactions.md) | `/v1/reports/partnerstransactions` | Transactions between partners for a period |
| [Materials Balances](materialsbalances.md) | `/v1/reports/materialsbalances` | Material balances per storage as of a given date |
| [Materials Operations Journal](materialsoperationsjournal.md) | `/v1/reports/materialsoperationsjournal` | Material movements (input, output, transfers) for a period |
| [Storage Input Orders and Received Services](storageinputordersandreceivedservices.md) | `/v1/reports/storageinputordersandreceivedservices` | Purchases of materials and received services for a period |
| [Calculated Data](calculateddata.md) | `/v1/reports/calculateddata` | Wages accruals and deductions calculated for a period |

## Base Path

`/accountant/v1/reports`
