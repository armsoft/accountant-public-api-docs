# Journals - All Documents

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_alldocuments.htm)

## Description

Returns every document registered in the given period, regardless of its type.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/journals/alldocuments`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `AllDocumentsJournalParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "pageSize": 5000
}
```

### Request body field notes

- `startDate` - Period begin.
- `endDate` - Period end.
- `documentTypes` - Document type.
- `currency` - Currency.
- `partner` - Partner.
- `employee` - Employee.
- `material` - Material.
- `inventoryNumber` - Inventory number.
- `documentState` - State.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `AllDocumentsJournalDataRowApiResponse` object with paging metadata and an array of `AllDocumentsJournalDataRow` rows.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "date": "2026-01-15",
      "dayOrderNumber": 0,
      "documentNumber": "0000001",
      "type": 1,
      "typeName": "",
      "currency": "AMD",
      "amount": 10000,
      "state": 1,
      "stateName": "",
      "partnerId": 0,
      "partnerCode": "P0001",
      "partnerName": "",
      "employeeCode": "",
      "employeeName": "",
      "comment": "Created through the Public API",
      "userName": "",
      "lastChange": "2026-01-15T00:00:00Z"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/journals/alldocuments" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "pageSize": 5000}'
```

## `AllDocumentsJournalDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `dayOrderNumber` | integer | Day order number |
| `documentNumber` | string | Document N |
| `type` | integer | Document type |
| `typeName` | string | Document type |
| `currency` | string | Currency |
| `amount` | number | Amount |
| `state` | integer | Document state |
| `stateName` | string | State |
| `partnerId` | integer | Inner number |
| `partnerCode` | string | Partner |
| `partnerName` | string | Partner name |
| `employeeCode` | string | Employee |
| `employeeName` | string | Employee name |
| `comment` | string | Comment |
| `userName` | string | User name |
| `lastChange` | date-time | Last modification date |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/journals/alldocuments/nextpage`](alldocuments-nextpage.md). See [Pagination](../../pagination.md).
