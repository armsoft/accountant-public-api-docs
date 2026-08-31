# Journals - Invoices

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_invoices.htm)

## Description

Returns invoice documents (tax invoices and related types) for the given period.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/journals/invoices`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `InvoiceDocumentsJournalParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "partner": "P0001",
  "pageSize": 5000
}
```

### Request body field notes

- `startDate` (required) - Period begin.
- `endDate` (required) - Period end.
- `documentTypes` - Document type.
- `currency` - Currency.
- `partner` - Partner.
- `showOutputAmountsAsNegatives` - Show output amounts as negatives.
- `documentState` - State.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `InvoiceDocumentsJournalDataRowApiResponse` object with paging metadata and an array of `InvoiceDocumentsJournalDataRow` rows.

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
      "submissionDate": "2026-01-15",
      "taxSerialNumber": "",
      "currency": "AMD",
      "amount": 10000,
      "vatType": "",
      "vatTypeName": "",
      "state": 1,
      "stateName": "",
      "partnerId": 0,
      "partnerCode": "P0001",
      "partnerName": "",
      "partnerTaxCode": "",
      "partnerStatus": "",
      "comment": "Created through the Public API",
      "taxExportType": "",
      "userName": "",
      "lastChange": "2026-01-15T00:00:00Z"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/journals/invoices" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "partner": "P0001", "pageSize": 5000}'
```

## `InvoiceDocumentsJournalDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `type` | integer | Type |
| `typeName` | string | Type |
| `submissionDate` | date | Submission date |
| `taxSerialNumber` | string | Tax serial number |
| `currency` | string | Currency |
| `amount` | number | Amount |
| `vatType` | string | — |
| `vatTypeName` | string | — |
| `state` | integer | Document state |
| `stateName` | string | State |
| `partnerId` | integer | Inner number |
| `partnerCode` | string | Partner |
| `partnerName` | string | Name |
| `partnerTaxCode` | string | Taxpayer’s ID |
| `partnerStatus` | string | Status |
| `comment` | string | Comment |
| `taxExportType` | string | Electronic/Paper |
| `userName` | string | User name |
| `lastChange` | date-time | Last modification date |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/journals/invoices/nextpage`](invoices-nextpage.md). See [Pagination](../../pagination.md).
