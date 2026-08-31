# Reports - Materials Operations Journal

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materials_operations_journal.htm)

## Description

Returns material movements (input, output, transfers) for a period.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/materialsoperationsjournal`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `MaterialsOperationsParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "storage": "01",
  "pageSize": 5000
}
```

### Request body field notes

- `startDate` - Period begin.
- `endDate` - Period end.
- `storage` - Storage.
- `materialGroup` - Materials group.
- `material` - Material.
- `account` - Account.
- `partner` - Partner.
- `operationTypes` - Operation type.
- `showParties` - By different batches.
- `currency` - Currency.
- `showCurrencies` - Show currencies.
- `showSalePrice` - Show sale price.
- `showVATAmounts` - Show VAT amounts.
- `pageSize` (optional) controls pagination: `0` or omitted returns every row in one response. See [Pagination](../../pagination.md).

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `MaterialsOperationsDataRowApiResponse` object with paging metadata and an array of `MaterialsOperationsDataRow` rows.

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
      "documentType": 0,
      "operationType": "",
      "operationName": "",
      "inputOutput": "",
      "storage": "01",
      "storageName": "",
      "materialId": 0,
      "materialCode": "",
      "materialName": "",
      "unitMeasure": "001",
      "unitMeasureAbbreviation": "pcs",
      "account": "2110",
      "correspondingObject": "",
      "correspondingObjectName": "",
      "analytic1": "",
      "analytic2": "",
      "cost": 0,
      "quantity": 10,
      "costAmount": 0,
      "costVATAmount": 0,
      "unitVAT": 0,
      "currency": "AMD",
      "currencyCost": 0,
      "salePrice": 0,
      "saleAmount": 0,
      "saleVATPrice": 0,
      "saleVATAmount": 0,
      "salePriceCurrency": 0,
      "saleAmountCurrency": 0,
      "comment": "Created through the Public API",
      "group": "01",
      "groupName": "",
      "specification": "",
      "cpaClassifier": "",
      "barcode": "1234567890123",
      "vat": true,
      "fullName": "Sample full name",
      "incomeDate": "2026-01-15",
      "partySupplierId": 0,
      "partySupplierCode": "",
      "partySupplierName": "",
      "partyDocumentNumber": "",
      "partyDocumentType": 0,
      "partyDocumentTypeName": "",
      "partyPurchasingPrice": 0,
      "partyPurchasingPriceWithoutVAT": 0
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/materialsoperationsjournal" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "storage": "01", "pageSize": 5000}'
```

## `MaterialsOperationsDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `documentType` | integer | Document type |
| `operationType` | string | Operation type |
| `operationName` | string | Operation type |
| `inputOutput` | string | Input\output |
| `storage` | string | Storage |
| `storageName` | string | Name |
| `materialId` | integer | — |
| `materialCode` | string | Material |
| `materialName` | string | Name |
| `unitMeasure` | string | Unit |
| `unitMeasureAbbreviation` | string | Unit of measure |
| `account` | string | Account |
| `correspondingObject` | string | Corresponding object |
| `correspondingObjectName` | string | Corresponding object name |
| `analytic1` | string | An. dimension 1 |
| `analytic2` | string | An. dimension 2 |
| `cost` | number | Price in drams |
| `quantity` | number | Quantity |
| `costAmount` | number | Prime cost amount |
| `costVATAmount` | number | VAT of cost’s amount |
| `unitVAT` | number | Unit VAT |
| `currency` | string | Currency |
| `currencyCost` | number | Input price in curr. |
| `salePrice` | number | Sale price |
| `saleAmount` | number | Sale amount |
| `saleVATPrice` | number | Sales price VAT |
| `saleVATAmount` | number | VAT of sale’s amount |
| `salePriceCurrency` | number | Sale price in curr. |
| `saleAmountCurrency` | number | Sale amount in curr. |
| `comment` | string | Comment |
| `group` | string | Group |
| `groupName` | string | Name |
| `specification` | string | Specification |
| `cpaClassifier` | string | — |
| `barcode` | string | Barcode |
| `vat` | boolean | — |
| `fullName` | string | Full name |
| `incomeDate` | date | Income date |
| `partySupplierId` | integer | — |
| `partySupplierCode` | string | Supplier |
| `partySupplierName` | string | Name |
| `partyDocumentNumber` | string | Document N |
| `partyDocumentType` | integer | Document type |
| `partyDocumentTypeName` | string | Document type |
| `partyPurchasingPrice` | number | Purchasing price |
| `partyPurchasingPriceWithoutVAT` | number | Purchasing price |

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/materialsoperationsjournal/nextpage`](materialsoperationsjournal-nextpage.md). See [Pagination](../../pagination.md).
