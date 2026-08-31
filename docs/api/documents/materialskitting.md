# Documents - Materials Kitting

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialskitting.htm)

## Description

Creates, reads, updates and deletes assembling a kit from its component materials.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/materialskitting` | Create a materials kitting |
| GET | `/v1/documents/materialskitting/{isn}` | Get a materials kitting by ISN |
| PUT | `/v1/documents/materialskitting/{isn}` | Update a materials kitting |
| DELETE | `/v1/documents/materialskitting/{isn}` | Delete a materials kitting |

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
materials kitting carries at least:

- `date`
- `documentNumber`
- `storageOutput`
- `storageInput`
- `kit`
- `quantity`
- `account`
- `kitComponents` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "storageOutput": "02",
  "storageInput": "01",
  "kit": "1001",
  "quantity": 10,
  "account": "2110",
  "comment": "Created through the Public API",
  "kitComponents": [
    {
      "type": "1",
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
curl -X POST "https://api.armsoft.am/accountant/v1/documents/materialskitting" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "storageOutput": "02", "storageInput": "01", "kit": "1001", "quantity": 10, "account": "2110", "comment": "Created through the Public API", "kitComponents": [{"type": "1", "code": "1001", "quantity": 10, "amount": 10000, "account": "2110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `MaterialsKitting` object, including `isn` |
| Get | `200 OK` | The `MaterialsKitting` object |
| Update | `200 OK` | The updated `MaterialsKitting` object |
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
  "kit": "1001",
  "quantity": 10,
  "account": "2110",
  "comment": "Created through the Public API",
  "kitComponents": [
    {
      "type": "1",
      "code": "1001",
      "quantity": 10,
      "amount": 10000,
      "account": "2110"
    }
  ]
}
```

## Field reference

### `MaterialsKitting` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `storageOutput` | string | Storage output |
| `storageInput` | string | Storage input |
| `kit` | string | Kit |
| `quantity` | number | Quantity |
| `account` | string | Account |
| `transitAccount` | string | Transit account |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `comment` | string | Comment |
| `kitComponents` | array<MaterialsKittingSpecificationRow> | Kit's components |

### `MaterialsKittingSpecificationRow` fields

The document's rows are sent in `kitComponents`.

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `type` | string | Type |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `amount` | number | Amount |
| `account` | string | Account |
| `rowId` | integer | Line ID |
