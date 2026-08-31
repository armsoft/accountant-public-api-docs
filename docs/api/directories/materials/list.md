# Materials - GetAll

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialslist.htm)

## Description

Returns the list of material records matching the supplied filters.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/materials/list`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `MaterialFilters` object. Every filter is optional.

```json
{
  "group": "01",
  "showAlsoClosed": false,
  "pageSize": 5000
}
```

### Request body field notes

- `codes` - Code.
- `lastModifiedDate` - Last modification date.
- `group` - Group.
- `showAlsoClosed` - Show also closed.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response; a value greater than `0` returns pages. See [Pagination](../../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `MaterialRowApiResponse` object with paging metadata and an array of `MaterialRow` records.

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
      "fullName": "Sample full name",
      "unitMeasure": "001",
      "unitMeasureAbbreviation": "pcs",
      "group": "01",
      "cpaClassifier": "",
      "account": "2110",
      "wholePrice": 1000,
      "retailPrice": 1200,
      "specification": "",
      "barcode": "1234567890123",
      "externalCode": "",
      "costingMethod": "",
      "aoeCoefficient": 0,
      "discountPercent": 0,
      "environmentalFeePercent": 0,
      "minimumQuantity": 0,
      "maximumQuantity": 0,
      "vat": true,
      "revenueAccount": "6110",
      "retailRevenueAccount": "",
      "expenseAccount": "7110",
      "revenueAdjustmentAccount": "",
      "lastModifierName": "",
      "lastModifyDate": "2026-01-15T00:00:00Z",
      "isClosed": false
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/directories/materials/list" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"group": "01", "showAlsoClosed": false, "pageSize": 5000}'
```

## Pagination

This endpoint supports pagination through the `pageSize` parameter. When the response contains
`hasMore: true`, fetch the following pages from [`/v1/directories/materials/list/nextpage`](nextpage.md).
See [Pagination](../../../pagination.md) for the full workflow.
