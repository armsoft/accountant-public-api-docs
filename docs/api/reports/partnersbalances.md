# Reports - Partners Balances

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_partners_balances.htm)

## Description

Returns partner balances as of a given date.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/partnersbalances`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `PartnersBalancesParam` object.

```json
{
  "date": "2026-01-31",
  "reportCurrency": "AMD",
  "showZeroRows": false,
  "pageSize": 5000
}
```

### Request body field notes

- `date` - Date.
- `partnerGroup` - Partners group.
- `partner` - Partner.
- `account` - Account.
- `currency` - Currency.
- `reportCurrency` - Report currency.
- `accountsSection` - Accounts section.
- `showZeroRows` - Show zero rows.
- `openedByDate` - Opened by date.
- `subtotals` - Selected rows.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `PartnersBalancesDataRowApiResponse` object with paging metadata and an array of `PartnersBalancesDataRow` rows.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "id": 100001,
      "code": "1001",
      "name": "Sample name",
      "status": "",
      "account": "2110",
      "accountName": "",
      "analytic1Code": "",
      "analytic1Name": "",
      "analytic2Code": "",
      "analytic2Name": "",
      "currency": "AMD",
      "debitCurrency": 0,
      "creditCurrency": 0,
      "debitNCC": 0,
      "creditNCC": 0,
      "outOfBalance": false,
      "date": "2026-01-15"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/partnersbalances" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-31", "reportCurrency": "AMD", "showZeroRows": false, "pageSize": 5000}'
```

## `PartnersBalancesDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Partner |
| `name` | string | Name |
| `status` | string | Status |
| `account` | string | Account |
| `accountName` | string | Name |
| `analytic1Code` | string | An. dimension 1 |
| `analytic1Name` | string | Name |
| `analytic2Code` | string | An. dimension 2 |
| `analytic2Name` | string | Name |
| `currency` | string | Currency |
| `debitCurrency` | number | Debit curr. |
| `creditCurrency` | number | Credit curr. |
| `debitNCC` | number | Debit in Dram |
| `creditNCC` | number | Credit in Dram |
| `outOfBalance` | boolean | Out of bal. |
| `date` | date | Date |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/partnersbalances/nextpage`](partnersbalances-nextpage.md). See [Pagination](../../pagination.md).
