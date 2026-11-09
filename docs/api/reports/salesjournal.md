# Reports - Sales Journal

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_salesjournal.htm)

## Description

Returns the **Sales journal** report (`Վաճառքների մատյան` / `Журнал продаж`): every sale, retail
sale and return of materials, services and fixed assets for a period, one row per document line,
with its cost, sale price and amount, profit and VAT figures.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/salesjournal`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey` (also reachable with a limited-access key)

## Request body (example)

A `SalesJournalParam` object.

```json
{
  "startDate": "2026-01-01",
  "endDate": "2026-01-31",
  "storage": "01",
  "operationTypes": "R",
  "showVATAmounts": true,
  "pageSize": 5000
}
```

### Request body fields

| Field | Type | Description |
|-------|------|-------------|
| `startDate` | date | Period begin. Defaults to the current date when omitted |
| `endDate` | date | Period end. Defaults to the current date when omitted |
| `storage` | string | Storage code. When filled, only operations of that storage are returned |
| `materialGroup` | string | Materials group code - only materials of that group |
| `material` | string | Material code - only that material |
| `service` | string | Service code - only that service |
| `fixedAsset` | string | Fixed asset code - only that fixed asset |
| `incomeAccount` | string | Income account |
| `expenseAccount` | string | Expense account |
| `partnerGroup` | string | Partner group code - only operations with partners of that group |
| `customer` | string | Customer (partner) code - only operations with that partner |
| `operationTypes` | string | Operation type - `R` sale, `T` retail sale, `V` return. Empty returns every type |
| `showByDifferentParties` | boolean | By different batches - split sold materials by batch and add the batch's input document details (`incomeDate`, `party*` fields) |
| `currency` | string | Currency code - only operations in that currency |
| `showCurrencies` | boolean | Show currencies - add the operations' currency amounts |
| `showVATAmounts` | boolean | Show VAT amounts - add the sale amount VAT and cost amount VAT |
| `showMTAdditionalColumns` | boolean | Show MT additional columns - add the CPA classifier, VAT and full name of materials |
| `pageSize` | integer | Pagination; `0` or omitted returns every row in one response. See [Pagination](../../pagination.md) |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `SalesJournalDataRowApiResponse` object with paging metadata and an array of
`SalesJournalDataRow` rows.

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
      "documentType": 1,
      "operationType": "R",
      "operationName": "Sale",
      "itemType": "1",
      "itemId": 100001,
      "itemCode": "1001",
      "itemName": "Sample material",
      "storage": "01",
      "storageName": "Main storage",
      "unitMeasure": "001",
      "unitMeasureAbbreviation": "pcs",
      "partnerGroup": "01",
      "customer": "P0001",
      "customerAccount": "2210",
      "customerBusinessAddress": "",
      "quantity": 10,
      "cost": 600,
      "costAmount": 6000,
      "initialPrice": 1000,
      "salePrice": 1000,
      "saleAmount": 10000,
      "environmentalFeePercent": 0,
      "environmentalFeeAmount": 0,
      "profit": 2333.33,
      "profitPercentBySale": 28,
      "profitPercentByCost": 38.89,
      "unitVAT": 120,
      "costVATAmount": 1200,
      "saleVATPrice": 166.67,
      "saleVATAmount": 1666.67,
      "vatDifference": 466.67,
      "currency": "AMD",
      "salePriceCurrency": 1000,
      "saleAmountCurrency": 10000,
      "discountPercent": 0,
      "itemVAT": true,
      "incomeAccount": "6110",
      "expenseAccount": "7110",
      "analytic1": "",
      "analytic2": "",
      "comment": "",
      "group": "10",
      "groupName": "Goods",
      "specification": "",
      "cpaClassifier": "",
      "vat": true,
      "fullName": "",
      "baseDocumentDate": null,
      "baseDocumentNumber": "",
      "rowId": 0,
      "incomeDate": null,
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
curl -X POST "https://api.armsoft.am/accountant/v1/reports/salesjournal" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"startDate": "2026-01-01", "endDate": "2026-01-31", "storage": "01", "operationTypes": "R", "showVATAmounts": true, "pageSize": 5000}'
```

## `SalesJournalDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | Internal serial number (ISN) of the document |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `documentType` | integer | Document type |
| `operationType` | string | Operation type |
| `operationName` | string | Operation name |
| `itemType` | string | Type - `1` material, `2` service, `3` fixed asset |
| `itemId` | integer | Inner number of the material, service or fixed asset |
| `itemCode` | string | Code |
| `itemName` | string | Name |
| `storage` | string | Storage |
| `storageName` | string | Storage name |
| `unitMeasure` | string | Unit of measure code |
| `unitMeasureAbbreviation` | string | Unit of measure |
| `partnerGroup` | string | Partner's group |
| `customer` | string | Customer |
| `customerAccount` | string | Customer account |
| `customerBusinessAddress` | string | Bus. address |
| `quantity` | number | Quantity |
| `cost` | number | Price in drams |
| `costAmount` | number | Prime cost amount |
| `initialPrice` | number | Initial price |
| `salePrice` | number | Sale price |
| `saleAmount` | number | Sale amount |
| `environmentalFeePercent` | number | Env. fee (%) |
| `environmentalFeeAmount` | number | Env. fee amount |
| `profit` | number | Profit |
| `profitPercentBySale` | number | Profit percent by sale |
| `profitPercentByCost` | number | Profit percent by cost |
| `unitVAT` | number | Unit VAT |
| `costVATAmount` | number | VAT of cost's amount (with `showVATAmounts`) |
| `saleVATPrice` | number | Sales price VAT |
| `saleVATAmount` | number | VAT of sale's amount (with `showVATAmounts`) |
| `vatDifference` | number | Difference between the sale amount VAT and the cost amount VAT |
| `currency` | string | Currency |
| `salePriceCurrency` | number | Sale price in curr. (with `showCurrencies`) |
| `saleAmountCurrency` | number | Sale amount in curr. (with `showCurrencies`) |
| `discountPercent` | number | Discount percent |
| `itemVAT` | boolean | Whether the item is subject to VAT |
| `incomeAccount` | string | Income account |
| `expenseAccount` | string | Expense account |
| `analytic1` | string | An. dimension 1 |
| `analytic2` | string | An. dimension 2 |
| `comment` | string | Comment |
| `group` | string | Group |
| `groupName` | string | Materials group name |
| `specification` | string | Specification |
| `cpaClassifier` | string | CPA classifier code (with `showMTAdditionalColumns`) |
| `vat` | boolean | VAT (with `showMTAdditionalColumns`) |
| `fullName` | string | Full name (with `showMTAdditionalColumns`) |
| `baseDocumentDate` | date | Base document date |
| `baseDocumentNumber` | string | Base document number |
| `rowId` | integer | Line ID |
| `incomeDate` | date | Income date of the batch (with `showByDifferentParties`) |
| `partySupplierId` | integer | Inner number of the batch supplier (with `showByDifferentParties`) |
| `partySupplierCode` | string | Batch supplier (with `showByDifferentParties`) |
| `partySupplierName` | string | Batch supplier name (with `showByDifferentParties`) |
| `partyDocumentNumber` | string | Batch input document N (with `showByDifferentParties`) |
| `partyDocumentType` | integer | Batch input document type (with `showByDifferentParties`) |
| `partyDocumentTypeName` | string | Batch input document type name (with `showByDifferentParties`) |
| `partyPurchasingPrice` | number | Batch purchasing price (with `showByDifferentParties`) |
| `partyPurchasingPriceWithoutVAT` | number | Batch purchasing price without VAT (with `showByDifferentParties`) |

### Coded field values

| Field | Value | Meaning |
|-------|-------|---------|
| `operationType` | `R` / `T` / `V` | Sale / Retail sale / Return |
| `itemType` | `1` / `2` / `3` | Material / Service / Fixed asset |

`storage` and `storageName` are empty for services and fixed assets. `operationName`,
`partyDocumentTypeName` and the other name fields are localized according to the
`Accept-Language` header.

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/salesjournal/nextpage`](salesjournal-nextpage.md). See [Pagination](../../pagination.md).
