# Documents - Overhead Expense Allocation

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_overheadexpenseallocation.htm)

## Description

Creates, reads, updates and deletes allocating overhead expenses across received materials.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/overheadexpenseallocation` | Create a overhead expense allocation |
| GET | `/v1/documents/overheadexpenseallocation/{isn}` | Get a overhead expense allocation by ISN |
| PUT | `/v1/documents/overheadexpenseallocation/{isn}` | Update a overhead expense allocation |
| DELETE | `/v1/documents/overheadexpenseallocation/{isn}` | Delete a overhead expense allocation |

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
overhead expense allocation carries at least:

- `date`
- `documentNumber`
- `baseDocument`
- `supplierCode`
- `currency`
- `storage`
- `amount`
- `distributionType`
- `materialsList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "baseDocument": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "currency": "AMD",
  "supplierCode": "P0001",
  "comment": "Created through the Public API",
  "storage": "01",
  "distributionType": "",
  "amount": 10000,
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "inputOrderAmount": 10000,
      "allocatedAmount": 0,
      "account": "2110"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/overheadexpenseallocation" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "baseDocument": "3fa85f64-5717-4562-b3fc-2c963f66afa6", "currency": "AMD", "supplierCode": "P0001", "comment": "Created through the Public API", "storage": "01", "distributionType": "", "amount": 10000, "materialsList": [{"code": "1001", "quantity": 10, "inputOrderAmount": 10000, "allocatedAmount": 0, "account": "2110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `OverheadExpenseAllocation` object, including `isn` |
| Get | `200 OK` | The `OverheadExpenseAllocation` object |
| Update | `200 OK` | The updated `OverheadExpenseAllocation` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "baseDocument": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "currency": "AMD",
  "supplierCode": "P0001",
  "comment": "Created through the Public API",
  "storage": "01",
  "distributionType": "",
  "amount": 10000,
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "inputOrderAmount": 10000,
      "allocatedAmount": 0,
      "account": "2110"
    }
  ]
}
```

## Field reference

### `OverheadExpenseAllocation` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `baseDocument` | uuid | Base document |
| `currency` | string | Currency |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate |
| `previousDayExchangeRate` | boolean | Previous day exchange rate |
| `supplierCode` | string | Supplier |
| `supplierAccount` | string | Supplier account |
| `prepaymentAccount` | string | Prepayment account |
| `vatAccount` | string | — |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `taxExportType` | string | Electronic/Paper |
| `purchaseDocumentNumber` | string | Purchase document N |
| `purchaseDocumentDate` | date | Date |
| `comment` | string | Comment |
| `overheadExpenseType` | string | Overhead expenses obtaining type |
| `vatCalculationType` | string | — |
| `includeVATInCost` | boolean | Include VAT in cost |
| `vatInclusionMethod` | string | — |
| `storage` | string | Storage |
| `allowEditList` | boolean | Allow edit list |
| `distributionType` | string | Distribution type |
| `distributionBase` | string | Distribution base |
| `amount` | number | Amount |
| `vatAmount` | number | — |
| `materialsList` | array<OverheadExpenseAllocationSpecificationRow> | Materials list |

### `OverheadExpenseAllocationSpecificationRow` fields

The document's rows are sent in `materialsList`.

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `inputOrderAmount` | number | Input order amount |
| `allocatedAmount` | number | Allocated amount |
| `account` | string | Account |
| `includeInDistribution` | boolean | — |
| `coefficient` | number | AOE coefficient |
| `rowId` | integer | Line ID |
