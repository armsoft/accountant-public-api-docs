# Documents - Memorial Order

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_memorial_order.htm)

## Description

Creates, reads, updates and deletes free-form accounting entries (memorial orders).

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/memorialorder` | Create a memorial order |
| GET | `/v1/documents/memorialorder/{isn}` | Get a memorial order by ISN |
| PUT | `/v1/documents/memorialorder/{isn}` | Update a memorial order |
| DELETE | `/v1/documents/memorialorder/{isn}` | Delete a memorial order |

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
memorial order carries at least:

- `date`
- `documentNumber`
- `amount`
- `currency`
- `transactionsList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "amount": 10000,
  "currency": "AMD",
  "comment": "Created through the Public API",
  "transactionsList": [
    {
      "debitAccount": "2110",
      "debitPartner": "P0001",
      "creditAccount": "5210",
      "creditPartner": "P0002",
      "amount": 10000,
      "comment": "Created through the Public API"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/memorialorder" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "amount": 10000, "currency": "AMD", "comment": "Created through the Public API", "transactionsList": [{"debitAccount": "2110", "debitPartner": "P0001", "creditAccount": "5210", "creditPartner": "P0002", "amount": 10000, "comment": "Created through the Public API"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `MemorialOrder` object, including `isn` |
| Get | `200 OK` | The `MemorialOrder` object |
| Update | `200 OK` | The updated `MemorialOrder` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "amount": 10000,
  "currency": "AMD",
  "comment": "Created through the Public API",
  "transactionsList": [
    {
      "debitAccount": "2110",
      "debitPartner": "P0001",
      "creditAccount": "5210",
      "creditPartner": "P0002",
      "amount": 10000,
      "comment": "Created through the Public API"
    }
  ]
}
```

## Field reference

### `MemorialOrder` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `amount` | number | Amount |
| `currency` | string | Currency |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate |
| `previousDayExchangeRate` | boolean | Previous day exchange rate |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `comment` | string | Comment |
| `transactionsList` | array<MemorialOrderSpecificationRow> | Operation |

### `MemorialOrderSpecificationRow` fields

The document's rows are sent in `transactionsList`.

| Field | Type | Description |
|-------|------|-------------|
| `debitAccount` | string | Debit |
| `debitPartner` | string | Debit part. |
| `debitAnalytic1` | string | Analytical dimension 1 |
| `debitAnalytic2` | string | Analytical dimension 2 |
| `debitCurrency` | string | Debit curr. |
| `creditAccount` | string | Credit |
| `creditPartner` | string | Credit part. |
| `creditAnalytic1` | string | Analytical dimension 1 |
| `creditAnalytic2` | string | Analytical dimension 2 |
| `creditCurrency` | string | Credit curr. |
| `currencyAmount` | number | Amount in curr. |
| `amount` | number | Amount in Dram |
| `comment` | string | Comment |
