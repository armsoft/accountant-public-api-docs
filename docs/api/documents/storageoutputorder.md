# Documents - Storage Output Order

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storageoutputorder.htm)

## Description

Creates, reads, updates and deletes materials written off from a storage.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/storageoutputorder` | Create a storage output order |
| GET | `/v1/documents/storageoutputorder/{isn}` | Get a storage output order by ISN |
| PUT | `/v1/documents/storageoutputorder/{isn}` | Update a storage output order |
| DELETE | `/v1/documents/storageoutputorder/{isn}` | Delete a storage output order |

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
storage output order carries at least:

- `date`
- `documentNumber`
- `storage`
- `expenseAccount`
- `materialsList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "storage": "01",
  "expenseAccount": "7110",
  "comment": "Created through the Public API",
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "amount": 10000
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/storageoutputorder" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "storage": "01", "expenseAccount": "7110", "comment": "Created through the Public API", "materialsList": [{"code": "1001", "quantity": 10, "amount": 10000}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `StorageOutputOrder` object, including `isn` |
| Get | `200 OK` | The `StorageOutputOrder` object |
| Update | `200 OK` | The updated `StorageOutputOrder` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "storage": "01",
  "expenseAccount": "7110",
  "comment": "Created through the Public API",
  "materialsList": [
    {
      "code": "1001",
      "quantity": 10,
      "amount": 10000
    }
  ]
}
```

## Field reference

### `StorageOutputOrder` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `storage` | string | Storage |
| `expenseAccount` | string | Expense account |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `comment` | string | Comment |
| `letterOfAttorney` | string | Letter of attorney |
| `mediator` | string | Mediator |
| `vehicle` | string | Vehicle |
| `chiefAccountant` | string | Chief accountant |
| `allowed` | string | Allowed |
| `requested` | string | Requested |
| `totalAmount` | number | Total amount |
| `materialsList` | array<StorageOutputOrderSpecificationRow> | Materials list |

### `StorageOutputOrderSpecificationRow` fields

The document's rows are sent in `materialsList`.

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `amount` | number | Amount |
| `rowId` | integer | Line ID |
