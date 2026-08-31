# Reports - Partners Transactions

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_partners_transactions.htm)

## Description

Returns transactions between partners for a period.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/partnerstransactions`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `PartnersTransactionsParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "debitPartner": "P0001",
  "pageSize": 5000
}
```

### Request body field notes

- `startDate` - Period begin.
- `endDate` - Period end.
- `debitPartnerGroup` - Debit-group.
- `creditPartnerGroup` - Credit-group.
- `partnersGroupANDCondition` - Require both the debit and the credit partner group filter to match (AND instead of OR).
- `debitPartner` - Debit part.
- `creditPartner` - Credit part.
- `partnersANDCondition` - Require both the debit and the credit partner filter to match (AND instead of OR).
- `debitAccount` - Debit-account.
- `creditAccount` - Credit-account.
- `accountsANDCondition` - Require both the debit and the credit account filter to match (AND instead of OR).
- `debitCurrency` - Debit curr.
- `creditCurrency` - Credit curr.
- `currenciesANDCondition` - Require both the debit and the credit currency filter to match (AND instead of OR).
- `documentTypes` - Document type.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `PartnersTransactionsDataRowApiResponse` object with paging metadata and an array of `PartnersTransactionsDataRow` rows.

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
      "debitPartnerGroup": "",
      "debitPartnerGroupName": "",
      "debitPartner": "P0001",
      "debitPartnerName": "",
      "debitPartnerTaxCode": "",
      "debitAccount": "2110",
      "debitAccountType": "",
      "debitCurrency": "AMD",
      "creditPartnerGroup": "",
      "creditPartnerGroupName": "",
      "creditPartner": "P0002",
      "creditPartnerName": "",
      "creditPartnerTaxCode": "",
      "creditAccount": "5210",
      "creditAccountType": "",
      "creditCurrency": "AMD",
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
curl -X POST "https://api.armsoft.am/accountant/v1/reports/partnerstransactions" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "debitPartner": "P0001", "pageSize": 5000}'
```

## `PartnersTransactionsDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `type` | integer | Type |
| `typeName` | string | Type |
| `debitPartnerGroup` | string | Debit-group |
| `debitPartnerGroupName` | string | Debit group name |
| `debitPartner` | string | Debit-code |
| `debitPartnerName` | string | Debit-name |
| `debitPartnerTaxCode` | string | Debit - Taxpayer’s ID |
| `debitAccount` | string | Debit-account |
| `debitAccountType` | string | Invoice type |
| `debitCurrency` | string | Debit curr. |
| `creditPartnerGroup` | string | Credit-group |
| `creditPartnerGroupName` | string | Crebit group name |
| `creditPartner` | string | Credit-code |
| `creditPartnerName` | string | Credit-name |
| `creditPartnerTaxCode` | string | Credit - Taxpayer’s ID |
| `creditAccount` | string | Credit-account |
| `creditAccountType` | string | Invoice type |
| `creditCurrency` | string | Credit curr. |
| `amount` | number | Amount in Dram |
| `currencyAmount` | number | Amount in curr. |
| `comment` | string | Comment |
| `userName` | string | User name |
| `systemGenerated` | boolean | System |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/partnerstransactions/nextpage`](partnerstransactions-nextpage.md). See [Pagination](../../pagination.md).
