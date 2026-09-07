# Documents - Fixed Asset Disposal Act

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_fixedassetdisposalact.htm)

## Description

Creates, reads, updates and deletes writing fixed assets off the balance sheet.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/fixedassetdisposalact` | Create a fixed asset disposal act |
| GET | `/v1/documents/fixedassetdisposalact/{isn}` | Get a fixed asset disposal act by ISN |
| PUT | `/v1/documents/fixedassetdisposalact/{isn}` | Update a fixed asset disposal act |
| DELETE | `/v1/documents/fixedassetdisposalact/{isn}` | Delete a fixed asset disposal act |

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
fixed asset disposal act carries at least:

- `date`
- `documentNumber`
- `outputLocation`
- `relievedResponsiblePerson`
- `inventoriesList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "outputLocation": "01",
  "relievedResponsiblePerson": "0001",
  "comment": "Created through the Public API",
  "inventoriesList": [
    {
      "inventoryNumber": "0000001",
      "grossCarryingAmountAccount": "1130",
      "depreciationAccount": "1140",
      "expenseAccount": "7110"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/fixedassetdisposalact" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "outputLocation": "01", "relievedResponsiblePerson": "0001", "comment": "Created through the Public API", "inventoriesList": [{"inventoryNumber": "0000001", "grossCarryingAmountAccount": "1130", "depreciationAccount": "1140", "expenseAccount": "7110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `FixedAssetDisposalAct` object, including `isn` |
| Get | `200 OK` | The `FixedAssetDisposalAct` object |
| Update | `200 OK` | The updated `FixedAssetDisposalAct` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "outputLocation": "01",
  "relievedResponsiblePerson": "0001",
  "comment": "Created through the Public API",
  "inventoriesList": [
    {
      "inventoryNumber": "0000001",
      "grossCarryingAmountAccount": "1130",
      "depreciationAccount": "1140",
      "expenseAccount": "7110"
    }
  ]
}
```

## Field reference

### `FixedAssetDisposalAct` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | Inner number |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `outputLocation` | string | Output location |
| `relievedResponsiblePerson` | string | Relieved mat.responsible person |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `comment` | string | Comment |
| `inventoriesList` | array<FixedAssetDisposalActSpecificationRow> | Inventories |

### `FixedAssetDisposalActSpecificationRow` fields

The document's rows are sent in `inventoriesList`.

| Field | Type | Description |
|-------|------|-------------|
| `inventoryNumber` | string | Inventory |
| `name` | string | Name |
| `grossCarryingAmountAccount` | string | Gross carrying amount account |
| `depreciationAccount` | string | Depreciation account |
| `expenseAccount` | string | Expense account |
| `deferredIncomeAccount` | string | Deferred income account |
| `deferredIncomeCurrentAccount` | string | Deferred Income current account |
| `incomeAccount` | string | Income account |
