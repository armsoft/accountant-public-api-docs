# Reports - Storage Input Orders and Received Services

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storageinputorderandrecievedservices.htm)

## Description

Returns purchases of materials and received services for a period.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/storageinputordersandreceivedservices`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `StorageInputOrdersAndReceivedServicesParam` object.

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
- `documentType` - Document type.
- `itemCode` - Material or service.
- `documentState` - Document state.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `StorageInputOrdersAndReceivedServicesDataRowApiResponse` object with paging metadata and an array of `StorageInputOrdersAndReceivedServicesDataRow` rows.

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
      "itemCode": "1001",
      "itemName": "",
      "unitMeasure": "001",
      "unitMeasureAbbreviation": "pcs",
      "supplierCode": "P0001",
      "supplierName": "",
      "supplierTaxCode": "",
      "quantity": 10,
      "currency": "AMD",
      "price": 1000,
      "discountPercent": 0,
      "discountedPrice": 1000,
      "amount": 10000,
      "vat": true,
      "account": "2110",
      "cpaClassifier": "",
      "comment": "Created through the Public API",
      "documentState": 0,
      "documentStateName": ""
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/storageinputordersandreceivedservices" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "pageSize": 5000}'
```

## `StorageInputOrdersAndReceivedServicesDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `itemCode` | string | Code |
| `itemName` | string | Name |
| `unitMeasure` | string | Unit |
| `unitMeasureAbbreviation` | string | Unit of measure |
| `supplierCode` | string | Supplier |
| `supplierName` | string | Supplier name |
| `supplierTaxCode` | string | Supplier tax code |
| `quantity` | number | Quantity |
| `currency` | string | Currency |
| `price` | number | Price |
| `discountPercent` | number | Discount percent |
| `discountedPrice` | number | Discounted price |
| `amount` | number | Amount |
| `vat` | boolean | — |
| `account` | string | Account |
| `cpaClassifier` | string | — |
| `comment` | string | Comment |
| `documentState` | integer | Document state |
| `documentStateName` | string | Document state |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/storageinputordersandreceivedservices/nextpage`](storageinputordersandreceivedservices-nextpage.md). See [Pagination](../../pagination.md).
