# Documents - Fixed Asset Acquisition

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_fixedassetacquisition.htm)

## Description

Creates, reads, updates and deletes acquiring a fixed asset and putting it into operation.

> **Not in the published specification yet.** This document type is implemented in the
> Accountant Public API service but is not yet served by `api.armsoft.am`, so it does not appear
> in [`swagger.json`](../../../swagger.json) until the next service release. The field reference
> below is generated from the service's own model definitions.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/fixedassetacquisition` | Create a fixed asset acquisition |
| GET | `/v1/documents/fixedassetacquisition/{isn}` | Get a fixed asset acquisition by ISN |
| PUT | `/v1/documents/fixedassetacquisition/{isn}` | Update a fixed asset acquisition |
| DELETE | `/v1/documents/fixedassetacquisition/{isn}` | Delete a fixed asset acquisition |

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| isn | uuid | Yes | Internal serial number of the document, returned when it was created |

## Required fields

The specification marks no property as required - anything you omit falls back to the value the
Accountant system would apply to a manually entered document. In practice a usable
fixed asset acquisition carries at least:

- `documentNumber`
- `inventoryNumber`
- `name`
- `inputDate`
- `exploitationDate`
- `fixedAssetType`
- `location`
- `responsiblePerson`
- `supplierCode`
- `supplierAccount`
- `financialCost`
- `grossCarryingAmountAccount`
- `depreciationAccount`

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "documentNumber": "0000001",
  "inventoryNumber": "0000001",
  "name": "Sample name",
  "inputDate": "2026-01-15",
  "exploitationDate": "2026-01-15",
  "fixedAssetType": "1",
  "location": "01",
  "responsiblePerson": "0001",
  "supplierCode": "P0001",
  "supplierAccount": "5210",
  "financialCost": 500000,
  "grossCarryingAmountAccount": "1130",
  "depreciationAccount": "1140"
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/fixedassetacquisition" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"documentNumber": "0000001", "inventoryNumber": "0000001", "name": "Sample name", "inputDate": "2026-01-15", "exploitationDate": "2026-01-15", "fixedAssetType": "1", "location": "01", "responsiblePerson": "0001", "supplierCode": "P0001", "supplierAccount": "5210", "financialCost": 500000, "grossCarryingAmountAccount": "1130", "depreciationAccount": "1140"}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `FixedAssetAcquisition` object, including `isn` |
| Get | `200 OK` | The `FixedAssetAcquisition` object |
| Update | `200 OK` | The updated `FixedAssetAcquisition` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "documentNumber": "0000001",
  "inventoryNumber": "0000001",
  "name": "Sample name",
  "inputDate": "2026-01-15",
  "exploitationDate": "2026-01-15",
  "fixedAssetType": "1",
  "location": "01",
  "responsiblePerson": "0001",
  "supplierCode": "P0001",
  "supplierAccount": "5210",
  "financialCost": 500000,
  "grossCarryingAmountAccount": "1130",
  "depreciationAccount": "1140"
}
```

## Field reference

### `FixedAssetAcquisition` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | Inner number |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `inventoryNumber` | string | Inventory number |
| `name` | string | Name |
| `fullName` | string | Full name |
| `inputDate` | date | Input date |
| `exploitationDate` | date | Exploitation date |
| `fixedAssetType` | string | Type of fixed asset |
| `profitTaxLawGroup` | string | FA group by Profit tax law |
| `purchaseMode` | string | FA purchase mode |
| `location` | string | Location |
| `responsiblePerson` | string | Material responsible person |
| `inventoryCard` | string | Inventory card |
| `supplierCode` | string | Supplier |
| `supplierAccount` | string | Supplier account |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `taxExportType` | string | Electronic/Paper |
| `purchaseDocumentNumber` | string | Purchase document N |
| `purchaseDocumentDate` | date | Date |
| `vatCalculationType` | string | VAT calculation type |
| `includeVATInCost` | boolean | Include VAT in cost |
| `vatInclusionMethod` | string | Include/Exclude VAT |
| `financialUsefulLife` | integer | Useful life (month) |
| `financialCost` | number | Cost |
| `financialCalculatedDepreciation` | number | Calculated depreciation |
| `financialDisposalValue` | number | Disposal (non-depr.) value |
| `financialIsDepreciated` | boolean | Is depreciated |
| `taxUsefulLife` | integer | Useful life (month) |
| `taxCost` | number | Cost |
| `taxCalculatedDepreciation` | number | Calculated depreciation |
| `taxDisposalValue` | number | Disposal (non-depr.) value |
| `taxIsDepreciated` | boolean | Is depreciated |
| `deferredIncomeUsefulLife` | integer | Useful life (month) |
| `deferredIncomeAmount` | number | Deferred income |
| `deferredIncomeCalculatedDepreciation` | number | Calculated depreciation |
| `deferredIncomeIsDepreciated` | boolean | Is depreciated |
| `grossCarryingAmountAccount` | string | Gross carrying amount account |
| `depreciationAccount` | string | Depreciation account |
| `expenseAccount` | string | Expense account |
| `deferredIncomeAccount` | string | Deferred income account |
| `deferredIncomeCurrentAccount` | string | Deferred Income current account |
| `incomeAccount` | string | Income account |
| `commissionDate` | integer | Date of commission |
| `serialNumber` | string | Serial number |
| `technicalCertificate` | string | Technical certificate |
| `brand` | string | Brand |
| `briefDescription` | string | Brief description |
| `producer` | string | Producer |
