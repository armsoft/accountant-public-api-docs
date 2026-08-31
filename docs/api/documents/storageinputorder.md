# Documents - Storage Input Order

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storageinputorder.htm)

## Description

Creates, reads, updates and deletes materials received into a storage.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/storageinputorder` | Create a storage input order |
| GET | `/v1/documents/storageinputorder/{isn}` | Get a storage input order by ISN |
| PUT | `/v1/documents/storageinputorder/{isn}` | Update a storage input order |
| DELETE | `/v1/documents/storageinputorder/{isn}` | Delete a storage input order |

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
storage input order carries at least:

- `date`
- `documentNumber`
- `storage`
- `supplierCode`
- `currency`
- `materialsList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "storage": "01",
  "currency": "AMD",
  "supplierCode": "P0001",
  "comment": "Created through the Public API",
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "price": 1000,
      "vat": true,
      "account": "2110"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/storageinputorder" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "storage": "01", "currency": "AMD", "supplierCode": "P0001", "comment": "Created through the Public API", "materialsList": [{"code": "1001", "quantity": 10, "price": 1000, "vat": true, "account": "2110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `StorageInputOrder` object, including `isn` |
| Get | `200 OK` | The `StorageInputOrder` object |
| Update | `200 OK` | The updated `StorageInputOrder` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "storage": "01",
  "currency": "AMD",
  "supplierCode": "P0001",
  "comment": "Created through the Public API",
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "price": 1000,
      "vat": true,
      "account": "2110"
    }
  ]
}
```

## Field reference

### `StorageInputOrder` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `storage` | string | Storage |
| `currency` | string | Currency |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate |
| `supplierCode` | string | Supplier |
| `supplierName` | string | Name |
| `supplierAccount` | string | Supplier account |
| `prepaymentAccount` | string | Prepayment account |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `taxExportType` | string | Electronic/Paper |
| `purchaseDocumentNumber` | string | Purchase document N |
| `purchaseDocumentDate` | date | Date |
| `comment` | string | Comment |
| `purchasingType` | string | Materials purchasing type |
| `vatCalculationType` | string | — |
| `includeVATInCost` | boolean | Include VAT in cost |
| `vatInclusionMethod` | string | — |
| `discountPercent` | number | Discount percent |
| `vatAmount` | number | — |
| `totalAmount` | number | Total amount |
| `supplierLegalAddress` | string | Legal address |
| `supplierBusinessAddress` | string | Bus. address |
| `supplierSettlementAccount` | string | Settlement account |
| `supplierTaxCode` | string | Taxpayer’s ID |
| `supplierManagerPosition` | string | Manager position |
| `supplierManagerName` | string | Manager first name, last name |
| `supplierAccountantPosition` | string | Accountant position |
| `supplierAccountantName` | string | Accountant first name, last name |
| `letterOfAttorney` | string | Letter of attorney |
| `mediator` | string | Mediator |
| `vehicle` | string | Vehicle |
| `chiefAccountant` | string | Chief accountant |
| `allowed` | string | Allowed |
| `accepted` | string | Accepted |
| `transportationDocumentNumber` | string | Transportation document N |
| `transportationDocumentDate` | date | Date |
| `materialsList` | array<StorageInputOrderSpecificationRow> | Materials list |

### `StorageInputOrderSpecificationRow` fields

The document's rows are sent in `materialsList`.

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `price` | number | Price |
| `discountPercent` | number | Discount percent |
| `discountedPrice` | number | Discounted price |
| `amount` | number | Amount |
| `vat` | boolean | — |
| `account` | string | Account |
| `cpaClassifier` | string | — |
| `rowNumber` | integer | line N |
| `rowId` | integer | Line ID |
