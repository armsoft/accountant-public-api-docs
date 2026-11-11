# Reports - Fixed Assets Card

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_reports.htm)

## Description

Returns the **Fixed assets card** report (`Տեղեկանք ըստ քարտարանի` / `Инвентарная ведомость`):
the fixed assets register as of a date, one row per inventory number and register type, with the
gross carrying value, accumulated depreciation, carrying value, location, responsible person,
state and useful life. With `groupBy` the report instead returns totals by fixed asset type,
state, or both.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/reports/fixedassetscard`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `FixedAssetsCardParam` object.

```json
{
  "date": "2026-01-31",
  "registerTypes": ["1", "2"],
  "states": ["2"],
  "extended": true,
  "pageSize": 5000
}
```

### Request body fields

| Field | Type | Description |
|-------|------|-------------|
| `date` | date | Report date - the register is shown as of this date. Defaults to the current date when omitted |
| `inventoryNumber` | string | Inventory number - only that fixed asset |
| `registerTypes` | string[] | Register types to include - `1` financial, `2` tax, `3` deferred income. Defaults to `["1"]` when omitted. See the note below on `3` |
| `fixedAssetType` | string | Fixed asset type code - only assets of that type |
| `location` | string | Location (department) code - only assets at that location |
| `responsiblePerson` | string | Materially responsible person (employee code) - only assets in that person's charge |
| `states` | string[] | States to include - `1` not yet commissioned, `2` in use, `3` temporarily taken out of use, `4` written off. Empty or omitted returns every state |
| `extended` | boolean | Extended - add the acquisition and passport details (`inputDate`, `supplier*`, `documentNumber`, `producer`, `commissionDate`, `serialNumber`, `technicalCertificate`, `brand`, `briefDescription`, `taxExportType`, `purchaseDocument*`) and `disposalValue` |
| `groupBy` | string | Group by - `1` fixed asset type, `2` state, `3` state and type. Empty or omitted returns one row per fixed asset |
| `pageSize` | integer | Pagination; `0` or omitted returns every row in one response. See [Pagination](../../pagination.md) |

The `states` filter takes the codes `1`-`4` above; the `state` field of each returned row holds the
state's operation code instead (see [Coded field values](#coded-field-values)).

Register type `3` (deferred income) applies only to databases kept in public sector mode; in other
databases it returns no rows.

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns a `FixedAssetsCardDataRowApiResponse` object with paging metadata and an array of
`FixedAssetsCardDataRow` rows.

### Sample response

```json
{
  "id": "550e8400-e29b-41d4-a716-446655440000",
  "hasMore": true,
  "data": [
    {
      "id": 100001,
      "inventoryCard": "001",
      "inventoryNumber": "000001",
      "name": "Sample computer",
      "registerType": "1",
      "registerTypeName": "Financial",
      "grossCarryingValue": 600000,
      "accumulatedDepreciation": 150000,
      "carryingValue": 450000,
      "disposalValue": 0,
      "fixedAssetType": "01",
      "location": "01",
      "responsiblePerson": "E0001",
      "responsiblePersonName": "Sample employee",
      "grossCarryingAmountAccount": "1110",
      "depreciationAccount": "1120",
      "expenseAccount": "7130",
      "deferredIncomeAccount": null,
      "deferredIncomeCurrentAccount": null,
      "incomeAccount": null,
      "state": "PIO",
      "stateName": "Exploitable",
      "dateOfCommissioning": "2025-02-01",
      "usefulLife": 60,
      "remainingUsefulLife": 45,
      "inputDate": "2025-01-20",
      "profitTaxLawGroup": "4",
      "supplierCode": "P0002",
      "supplierName": "Sample supplier",
      "supplierAccount": "5211",
      "documentNumber": "0000012",
      "producer": "",
      "commissionDate": 2024,
      "serialNumber": "SN-12345",
      "technicalCertificate": "",
      "brand": "",
      "briefDescription": "",
      "taxExportType": "Electronic",
      "purchaseDocumentNumber": "A1234567",
      "purchaseDocumentDate": "2025-01-20"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/reports/fixedassetscard" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-31", "registerTypes": ["1", "2"], "states": ["2"], "extended": true, "pageSize": 5000}'
```

## `FixedAssetsCardDataRow` fields

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number of the fixed asset |
| `inventoryCard` | string | Inventory card |
| `inventoryNumber` | string | Inventory number |
| `name` | string | Name of the fixed asset; with `groupBy` `1` or `3`, the name of the fixed asset type |
| `registerType` | string | Register type code |
| `registerTypeName` | string | Register type |
| `grossCarryingValue` | number | Gross carrying value |
| `accumulatedDepreciation` | number | Accumulated depreciation |
| `carryingValue` | number | Carrying value (gross carrying value less accumulated depreciation) |
| `disposalValue` | number | Disposal (non-depreciable) value (with `extended`) |
| `fixedAssetType` | string | Fixed asset type code |
| `location` | string | Location (department) code |
| `responsiblePerson` | string | Materially responsible person (employee code) |
| `responsiblePersonName` | string | Materially responsible person name |
| `grossCarryingAmountAccount` | string | Gross carrying amount account (financial register type) |
| `depreciationAccount` | string | Depreciation account (financial register type) |
| `expenseAccount` | string | Expense account (financial register type) |
| `deferredIncomeAccount` | string | Deferred income account (deferred income register type) |
| `deferredIncomeCurrentAccount` | string | Deferred income current part account (deferred income register type) |
| `incomeAccount` | string | Income account (deferred income register type) |
| `state` | string | State code |
| `stateName` | string | State |
| `dateOfCommissioning` | date | Date of putting into commission - filled while the asset is in use |
| `usefulLife` | integer | Useful life (months) |
| `remainingUsefulLife` | integer | Remaining useful life (months) |
| `inputDate` | date | Input date (with `extended`) |
| `profitTaxLawGroup` | string | Fixed asset group under the profit tax law |
| `supplierCode` | string | Supplier (with `extended`) |
| `supplierName` | string | Supplier name (with `extended`) |
| `supplierAccount` | string | Supplier account (with `extended`) |
| `documentNumber` | string | Input document N (with `extended`) |
| `producer` | string | Producer (with `extended`) |
| `commissionDate` | integer | Year of manufacture (with `extended`) |
| `serialNumber` | string | Serial number (with `extended`) |
| `technicalCertificate` | string | Technical certificate (with `extended`) |
| `brand` | string | Brand (with `extended`) |
| `briefDescription` | string | Brief description (with `extended`) |
| `taxExportType` | string | Tax invoice issue form - electronic or paper (with `extended`) |
| `purchaseDocumentNumber` | string | Purchase document (tax invoice) N (with `extended`) |
| `purchaseDocumentDate` | date | Purchase document (tax invoice) date (with `extended`) |

### Coded field values

| Field | Value | Meaning |
|-------|-------|---------|
| `registerType` | `1` / `2` / `3` | Financial / Tax / Deferred income |
| `state` | `PUR` | Not yet commissioned |
| `state` | `PIO` / `RIO` | In use (put into operation / returned to operation) |
| `state` | `TMP` | Temporarily taken out of use |
| `state` | `OFF` | Written off |

`registerTypeName`, `stateName` and `taxExportType` are localized according to the
`Accept-Language` header. The account fields are filled only for the register type they belong
to and are empty in grouped results.

### Grouped results

With `groupBy` set, each row is a total for one register type and one group, and only these fields
are filled: `registerType`, `registerTypeName`, `grossCarryingValue`, `accumulatedDepreciation`,
`carryingValue`, plus `fixedAssetType` and `name` (grouping by type) and/or `state` and `stateName`
(grouping by state). Grouped totals cover the financial and tax register types: `["1"]` returns
financial totals only, `["2"]` tax totals only, and any other selection returns both. Grouping by
type alone (`groupBy` `1`) ignores the `states` filter.

## Pagination

When the response contains `hasMore: true`, fetch the following pages from
[`/v1/reports/fixedassetscard/nextpage`](fixedassetscard-nextpage.md). See [Pagination](../../pagination.md).
