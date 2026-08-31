# Reports - Accounts Turnover

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_accounts_turnover.htm)

## Description

Returns account turnover for a period.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/accountsturnover`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `AccountsTurnoverParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "reportCurrency": "AMD",
  "showZeroRows": false,
  "pageSize": 5000
}
```

### Request body field notes

- `startDate` - Period begin.
- `endDate` - Period end.
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

Returns a `AccountsTurnoverDataRowApiResponse` object with paging metadata and an array of `AccountsTurnoverDataRow` rows.

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
      "partnerId": 0,
      "partnerCode": "P0001",
      "partnerName": "",
      "analytic1Code": "",
      "analytic1Name": "",
      "analytic2Code": "",
      "analytic2Name": "",
      "startDebitCurrencyAmount": 0,
      "startCreditCurrencyAmount": 0,
      "startDebitAmount": 0,
      "startCreditAmount": 0,
      "turnoverDebitCurrencyAmount": 0,
      "turnoverCreditCurrencyAmount": 0,
      "turnoverDebitAmount": 0,
      "turnoverCreditAmount": 0,
      "endDebitCurrencyAmount": 0,
      "endCreditCurrencyAmount": 0,
      "endDebitAmount": 0,
      "endCreditAmount": 0,
      "outOfBalance": false,
      "accountType": "",
      "leaf": false,
      "isPartnerAccount": false,
      "isAnalytic1": false,
      "isAnalytic2": false,
      "path": "",
      "parent": ""
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/accountsturnover" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "reportCurrency": "AMD", "showZeroRows": false, "pageSize": 5000}'
```

## `AccountsTurnoverDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `account` | string | Account |
| `currency` | string | Currency |
| `name` | string | Name |
| `nameRU` | string | Name (russian) |
| `partnerId` | integer | Inner number |
| `partnerCode` | string | Partner |
| `partnerName` | string | Name |
| `analytic1Code` | string | An. dimension 1 |
| `analytic1Name` | string | Name |
| `analytic2Code` | string | An. dimension 2 |
| `analytic2Name` | string | Name |
| `startDebitCurrencyAmount` | number | Starting Db. bal. in Curr. |
| `startCreditCurrencyAmount` | number | Starting Cr. bal. in Curr. |
| `startDebitAmount` | number | Beginning Db. bal. in Dram |
| `startCreditAmount` | number | Beginning Cr. bal. in Dram |
| `turnoverDebitCurrencyAmount` | number | Turnover Db. in Curr. |
| `turnoverCreditCurrencyAmount` | number | Turnover Cr. in Curr. |
| `turnoverDebitAmount` | number | Turnover Db. in Dram |
| `turnoverCreditAmount` | number | Turnover Cr. in Dram |
| `endDebitCurrencyAmount` | number | Ending Db. bal. in Curr. |
| `endCreditCurrencyAmount` | number | Ending Cr. bal. in Curr. |
| `endDebitAmount` | number | Ending Db. bal. in Dram |
| `endCreditAmount` | number | Ending Cr. bal. in Dram |
| `outOfBalance` | boolean | Out of bal. |
| `accountType` | string | Invoice type |
| `leaf` | boolean | Account |
| `isPartnerAccount` | boolean | Partner |
| `isAnalytic1` | boolean | An. dimension 1 |
| `isAnalytic2` | boolean | An. dimension 2 |
| `path` | string | Account |
| `parent` | string | Parent |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/accountsturnover/nextpage`](accountsturnover-nextpage.md). See [Pagination](../../pagination.md).
