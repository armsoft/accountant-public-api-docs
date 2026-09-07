# Documents - Cash Input Order

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_cashinputorder.htm)

## Description

Creates, reads, updates and deletes cash received into a cash desk.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/cashinputorder` | Create a cash input order |
| GET | `/v1/documents/cashinputorder/{isn}` | Get a cash input order by ISN |
| PUT | `/v1/documents/cashinputorder/{isn}` | Update a cash input order |
| DELETE | `/v1/documents/cashinputorder/{isn}` | Delete a cash input order |

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
cash input order carries at least:

- `date`
- `documentNumber`
- `cashDesk`
- `currency`
- `amount`
- `partnerCode`
- `correspondentAccount`
- `base`

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "cashDesk": "01",
  "currency": "AMD",
  "amount": 10000,
  "correspondentAccount": "2510",
  "partnerCode": "P0001",
  "base": "Invoice 0000001"
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/cashinputorder" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "cashDesk": "01", "currency": "AMD", "amount": 10000, "correspondentAccount": "2510", "partnerCode": "P0001", "base": "Invoice 0000001"}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `CashInputOrder` object, including `isn` |
| Get | `200 OK` | The `CashInputOrder` object |
| Update | `200 OK` | The updated `CashInputOrder` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "cashDesk": "01",
  "currency": "AMD",
  "amount": 10000,
  "correspondentAccount": "2510",
  "partnerCode": "P0001",
  "base": "Invoice 0000001"
}
```

## Field reference

### `CashInputOrder` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | Inner number |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `cashDesk` | string | Cash |
| `currency` | string | Currency |
| `amount` | number | Sum in AMD |
| `currencyAmount` | number | Amount in curr. |
| `ecrCheckNumber` | string | ECR check num |
| `correspondentAccount` | string | Corr. account |
| `cashInFlowAccount` | string | Cash in. acc. |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `partnerCode` | string | Partner |
| `payerName` | string | Received |
| `base` | string | Base |
| `attached` | string | Attached |
