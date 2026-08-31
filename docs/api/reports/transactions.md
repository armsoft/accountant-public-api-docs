# Reports - Transactions

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_transactions.htm)

## Description

Returns the general-ledger transactions journal for a period.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/transactions`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `TransactionsParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "debitAccount": "2110",
  "showPartners": true,
  "pageSize": 5000
}
```

### Request body field notes

- `startDate` - Period begin.
- `endDate` - Period end.
- `debitAccount` - Debit.
- `creditAccount` - Credit.
- `accountsANDCondition` - Require both the debit and the credit account filter to match (AND instead of OR).
- `debitPartner` - Debit part.
- `creditPartner` - Credit part.
- `partnersANDCondition` - Require both the debit and the credit partner filter to match (AND instead of OR).
- `debitAnalytic1` - An. dimension 1.
- `creditAnalytic1` - An. dimension 1.
- `analytics1ANDCondition` - Require both analytical dimension 1 filters to match (AND instead of OR).
- `debitAnalytic2` - An. dimension 2.
- `creditAnalytic2` - An. dimension 2.
- `analytics2ANDCondition` - Require both analytical dimension 2 filters to match (AND instead of OR).
- `debitCurrency` - Debit curr.
- `creditCurrency` - Credit curr.
- `currenciesANDCondition` - Require both the debit and the credit currency filter to match (AND instead of OR).
- `documentTypes` - Document type.
- `showPartners` - Show the partners.
- `showAnalytics1` - Show the analytical dim. 1.
- `showAnalytics2` - Show the analytical dim. 2.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `TransactionsDataRowApiResponse` object with paging metadata and an array of `TransactionsDataRow` rows.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "date": "2026-01-15",
      "documentNumber": "0000001",
      "type": 1,
      "typeName": "",
      "debitAccount": "2110",
      "debitAccountType": "",
      "debitCurrency": "AMD",
      "debitPartner": "P0001",
      "debitPartnerName": "",
      "debitPartnerGroup": "",
      "debitPartnerTaxCode": "",
      "debitAnalytic1": "",
      "debitAnalytic1Name": "",
      "debitAnalytic2": "",
      "debitAnalytic2Name": "",
      "creditAccount": "5210",
      "creditAccountType": "",
      "creditCurrency": "AMD",
      "creditPartner": "P0002",
      "creditPartnerName": "",
      "creditPartnerGroup": "",
      "creditPartnerTaxCode": "",
      "creditAnalytic1": "",
      "creditAnalytic1Name": "",
      "creditAnalytic2": "",
      "creditAnalytic2Name": "",
      "amount": 10000,
      "currencyAmount": 10000,
      "comment": "Created through the Public API",
      "userName": "",
      "systemGenerated": false
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/transactions" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "debitAccount": "2110", "showPartners": true, "pageSize": 5000}'
```

## `TransactionsDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `type` | integer | Type |
| `typeName` | string | Type |
| `debitAccount` | string | Debit |
| `debitAccountType` | string | Invoice type |
| `debitCurrency` | string | Debit curr. |
| `debitPartner` | string | Debit part. |
| `debitPartnerName` | string | Debit-name |
| `debitPartnerGroup` | string | Debit-group |
| `debitPartnerTaxCode` | string | Debit - Taxpayer’s ID |
| `debitAnalytic1` | string | Analytical dimension 1 |
| `debitAnalytic1Name` | string | Analytical dimension 1 |
| `debitAnalytic2` | string | Analytical dimension 2 |
| `debitAnalytic2Name` | string | Analytical dimension 2 |
| `creditAccount` | string | Credit |
| `creditAccountType` | string | Invoice type |
| `creditCurrency` | string | Credit curr. |
| `creditPartner` | string | Credit part. |
| `creditPartnerName` | string | Credit-name |
| `creditPartnerGroup` | string | Credit-group |
| `creditPartnerTaxCode` | string | Credit - Taxpayer’s ID |
| `creditAnalytic1` | string | Analytical dimension 1 |
| `creditAnalytic1Name` | string | Analytical dimension 1 |
| `creditAnalytic2` | string | Analytical dimension 2 |
| `creditAnalytic2Name` | string | Analytical dimension 2 |
| `amount` | number | Amount in Dram |
| `currencyAmount` | number | Amount in curr. |
| `comment` | string | Comment |
| `userName` | string | User name |
| `systemGenerated` | boolean | System |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/transactions/nextpage`](transactions-nextpage.md). See [Pagination](../../pagination.md).
