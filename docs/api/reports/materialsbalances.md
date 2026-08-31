# Reports - Materials Balances

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materials_balances.htm)

## Description

Returns material balances per storage as of a given date.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/materialsbalances`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `MaterialsBalancesParam` object.

```json
{
  "date": "2026-01-31",
  "storage": "01",
  "showZeroRows": false,
  "pageSize": 5000
}
```

### Request body field notes

- `date` - Date.
- `storage` - Storage.
- `group` - Materials group.
- `material` - Material.
- `showByDifferentAccounts` - By different accounts.
- `account` - Account.
- `showByDifferentParties` - By different batches.
- `minimumQuantities` - Minimum quantities.
- `salePrices` - Show sale price.
- `currency` - Currency.
- `showZeroRows` - Show zero rows.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `MaterialsBalancesDataRowApiResponse` object with paging metadata and an array of `MaterialsBalancesDataRow` rows.

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
      "unitMeasure": "001",
      "unitMeasureAbbreviation": "pcs",
      "storage": "01",
      "storageName": "",
      "quantity": 10,
      "cost": 0,
      "costAmount": 0,
      "unitVAT": 0,
      "vatAmount": 1666.67,
      "group": "01",
      "groupName": "",
      "account": "2110",
      "salePrice": 0,
      "saleAmount": 0,
      "retailPrice": 1200,
      "retailAmount": 0,
      "currency": "AMD",
      "currencyPrice": 2.5,
      "currencyAmount": 10000,
      "minimumQuantity": 0,
      "variance": 0,
      "maximumQuantity": 0,
      "orderQuantity": 0,
      "orderComment": "",
      "incomeDate": "2026-01-15",
      "partySupplierId": 0,
      "partySupplierCode": "",
      "partySupplierName": "",
      "partySupplierTaxCode": "",
      "purchasingPrice": 0,
      "purchasingPriceWithoutVAT": 0,
      "partyDocumentType": "",
      "partyDocumentNumber": "",
      "partyBase": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
      "partyRow": 0,
      "costingMethod": "",
      "specification": ""
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/materialsbalances" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-31", "storage": "01", "showZeroRows": false, "pageSize": 5000}'
```

## `MaterialsBalancesDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitMeasure` | string | Unit of measure |
| `unitMeasureAbbreviation` | string | Name |
| `storage` | string | Storage |
| `storageName` | string | Name |
| `quantity` | number | Balance |
| `cost` | number | Price in drams |
| `costAmount` | number | Amount |
| `unitVAT` | number | Unit VAT |
| `vatAmount` | number | — |
| `group` | string | Group |
| `groupName` | string | Name |
| `account` | string | Account |
| `salePrice` | number | Sale price |
| `saleAmount` | number | Sale amount |
| `retailPrice` | number | Retail price |
| `retailAmount` | number | Retail amount |
| `currency` | string | Currency |
| `currencyPrice` | number | Sale price in curr. |
| `currencyAmount` | number | Sale amount in curr. |
| `minimumQuantity` | number | Minimum quantity |
| `variance` | number | Variance |
| `maximumQuantity` | number | Maximal quantity (max) |
| `orderQuantity` | number | Order quantity |
| `orderComment` | string | Comment |
| `incomeDate` | date | Income date |
| `partySupplierId` | integer | Inner number |
| `partySupplierCode` | string | Supplier |
| `partySupplierName` | string | Name |
| `partySupplierTaxCode` | string | Supplier tax code |
| `purchasingPrice` | number | Purchasing price |
| `purchasingPriceWithoutVAT` | number | Purchasing price |
| `partyDocumentType` | string | Document type |
| `partyDocumentNumber` | string | Document N |
| `partyBase` | uuid | Inner number |
| `partyRow` | integer | line N |
| `costingMethod` | string | Costing  method |
| `specification` | string | Specification |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/materialsbalances/nextpage`](materialsbalances-nextpage.md). See [Pagination](../../pagination.md).
