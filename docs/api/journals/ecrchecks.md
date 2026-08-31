# Journals - ECR Checks

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_ecr_checks.htm)

## Description

Returns electronic cash register checks for the given period.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/journals/ecrchecks`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `ECRChecksJournalParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "cashDesk": "01",
  "pageSize": 5000
}
```

### Request body field notes

- `startDate` - Period begin.
- `endDate` - Period end.
- `documentTypes` - Type.
- `partner` - Partner.
- `cashDesk` - Cash.
- `showPayments` - Show payments.
- `showOutputAmountsAsNegatives` - Show output amounts as negatives.
- `documentState` - State.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `ECRChecksJournalDataRowApiResponse` object with paging metadata and an array of `ECRChecksJournalDataRow` rows.

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
      "ecrCheckNumber": "",
      "type": 1,
      "typeName": "",
      "amount": 10000,
      "cashAmount": 0,
      "nonCashAmount": 0,
      "prepaymentAmount": 0,
      "receivablesAmount": 0,
      "state": 1,
      "stateName": "",
      "cashDesk": "01",
      "partnerId": 0,
      "partnerCode": "P0001",
      "partnerName": "",
      "partnerTaxCode": "",
      "comment": "Created through the Public API",
      "userName": "",
      "lastChange": "2026-01-15T00:00:00Z"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/journals/ecrchecks" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "cashDesk": "01", "pageSize": 5000}'
```

## `ECRChecksJournalDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `ecrCheckNumber` | string | — |
| `type` | integer | Type |
| `typeName` | string | Type |
| `amount` | number | Amount |
| `cashAmount` | number | Cash |
| `nonCashAmount` | number | Non-cash |
| `prepaymentAmount` | number | Prepayment |
| `receivablesAmount` | number | Receivables |
| `state` | integer | State |
| `stateName` | string | State |
| `cashDesk` | string | Cash |
| `partnerId` | integer | Inner number |
| `partnerCode` | string | Partner |
| `partnerName` | string | Name |
| `partnerTaxCode` | string | Taxpayer’s ID |
| `comment` | string | Comment |
| `userName` | string | User name |
| `lastChange` | date-time | Last change |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/journals/ecrchecks/nextpage`](ecrchecks-nextpage.md). See [Pagination](../../pagination.md).
