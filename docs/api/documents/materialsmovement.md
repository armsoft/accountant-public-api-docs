# Documents - Materials Movement

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialsmovement.htm)

## Description

Creates, reads, updates and deletes materials moved between two storages.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/materialsmovement` | Create a materials movement |
| GET | `/v1/documents/materialsmovement/{isn}` | Get a materials movement by ISN |
| PUT | `/v1/documents/materialsmovement/{isn}` | Update a materials movement |
| DELETE | `/v1/documents/materialsmovement/{isn}` | Delete a materials movement |

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
materials movement carries at least:

- `date`
- `documentNumber`
- `storageOutput`
- `storageInput`
- `materialsList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "storageOutput": "02",
  "storageInput": "01",
  "comment": "Created through the Public API",
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "amount": 10000,
      "account": "2110"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/materialsmovement" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "storageOutput": "02", "storageInput": "01", "comment": "Created through the Public API", "materialsList": [{"code": "1001", "quantity": 10, "amount": 10000, "account": "2110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `MaterialsMovement` object, including `isn` |
| Get | `200 OK` | The `MaterialsMovement` object |
| Update | `200 OK` | The updated `MaterialsMovement` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "storageOutput": "02",
  "storageInput": "01",
  "comment": "Created through the Public API",
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "amount": 10000,
      "account": "2110"
    }
  ]
}
```

## Field reference

### `MaterialsMovement` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `storageOutput` | string | Storage output |
| `storageInput` | string | Storage input |
| `printSalePriceType` | string | Print the sale prices |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `comment` | string | Comment |
| `chiefAccountant` | string | Chief accountant |
| `mediator` | string | Mediator |
| `allowed` | string | Allowed |
| `bookNumber` | string | Distributor entries book N |
| `bookPage` | integer | page N |
| `bookLine` | integer | line N |
| `taxExportType` | string | Electronic/Paper |
| `taxInvoiceSeries` | string | Serial |
| `taxInvoiceNumber` | string | Number |
| `submissionDate` | date | Submission date |
| `transportationMethod` | string | Transportation method |
| `vehicle` | boolean | Vehicle |
| `brand` | string | Brand |
| `licensePlate` | string | License plate |
| `contract` | string | Contract |
| `contractDate` | date | Contract date |
| `additionalData` | string | Additional data |
| `materialsList` | array<MaterialsMovementSpecificationRow> | Materials list |

### `MaterialsMovementSpecificationRow` fields

The document's rows are sent in `materialsList`.

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `amount` | number | Amount |
| `account` | string | Account of input |
| `rowId` | integer | Line ID |
