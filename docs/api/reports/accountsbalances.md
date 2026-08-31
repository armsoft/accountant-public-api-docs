# Reports - Accounts Balances

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_account_balances.htm)

## Description

Returns synthetic account balances as of a given date.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/accountsbalances`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `AccountBalancesParam` object.

```json
{
  "date": "2026-01-31",
  "accountsSection": "2",
  "reportCurrency": "AMD",
  "showZeroRows": false,
  "pageSize": 5000
}
```

### Request body field notes

- `date` - Date.
- `account` - Account.
- `currency` - Currency.
- `reportCurrency` - Report currency.
- `accountsSection` - Accounts section.
- `showOnlyLastLevels` - Show only last levels accounts.
- `showPartners` - Show the partners.
- `showAnalytics1` - Show the analytical dim. 1.
- `showAnalytics2` - Show the analytical dim. 2.
- `showZeroRows` - Show zero rows.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `AccountsBalancesDataRowApiResponse` object with paging metadata and an array of `AccountsBalancesDataRow` rows.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "account": "2110",
      "currency": "AMD",
      "name": "Sample name",
      "nameRU": "",
      "debitCurrencyAmount": 0,
      "creditCurrencyAmount": 0,
      "debitAmount": 0,
      "creditAmount": 0,
      "outOfBalance": false,
      "accountType": "",
      "leaf": false,
      "isPartnerAccount": false,
      "isAnalytic1": false,
      "isAnalytic2": false,
      "path": "",
      "parent": "",
      "partnerId": 0,
      "partnerCode": "P0001",
      "partnerName": "",
      "analytic1Code": "",
      "analytic1Name": "",
      "analytic2Code": "",
      "analytic2Name": ""
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/accountsbalances" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-31", "accountsSection": "2", "reportCurrency": "AMD", "showZeroRows": false, "pageSize": 5000}'
```

## `AccountsBalancesDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `account` | string | Account |
| `currency` | string | Currency |
| `name` | string | Name |
| `nameRU` | string | Name (russian) |
| `debitCurrencyAmount` | number | Debit curr. |
| `creditCurrencyAmount` | number | Credit curr. |
| `debitAmount` | number | Debit in Dram |
| `creditAmount` | number | Credit in Dram |
| `outOfBalance` | boolean | Out of bal. |
| `accountType` | string | Invoice type |
| `leaf` | boolean | Account |
| `isPartnerAccount` | boolean | Partner |
| `isAnalytic1` | boolean | An. dimension 1 |
| `isAnalytic2` | boolean | An. dimension 2 |
| `path` | string | Account |
| `parent` | string | Account |
| `partnerId` | integer | Inner number |
| `partnerCode` | string | Partner |
| `partnerName` | string | Name |
| `analytic1Code` | string | An. dimension 1 |
| `analytic1Name` | string | Name |
| `analytic2Code` | string | An. dimension 2 |
| `analytic2Name` | string | Name |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/accountsbalances/nextpage`](accountsbalances-nextpage.md). See [Pagination](../../pagination.md).
