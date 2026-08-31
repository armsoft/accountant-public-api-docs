# Documents - Cash Output Order

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_cashoutputorder.htm)

## Description

Creates, reads, updates and deletes cash paid out of a cash desk.

> **Not in the published specification yet.** This document type is implemented in the
> Accountant Public API service but is not yet served by `api.armsoft.am`, so it does not appear
> in [`swagger.json`](../../../swagger.json) until the next service release. The field reference
> below is generated from the service's own model definitions.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/cashoutputorder` | Create a cash output order |
| GET | `/v1/documents/cashoutputorder/{isn}` | Get a cash output order by ISN |
| PUT | `/v1/documents/cashoutputorder/{isn}` | Update a cash output order |
| DELETE | `/v1/documents/cashoutputorder/{isn}` | Delete a cash output order |

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
cash output order carries at least:

- `date`
- `documentNumber`
- `cashDesk`
- `currency`
- `amount`
- `partnerCode`
- `correspondentAccount`
- `aim`
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
  "aim": "Cash advance",
  "base": "Invoice 0000001"
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/cashoutputorder" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "cashDesk": "01", "currency": "AMD", "amount": 10000, "correspondentAccount": "2510", "partnerCode": "P0001", "aim": "Cash advance", "base": "Invoice 0000001"}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `CashOutputOrder` object, including `isn` |
| Get | `200 OK` | The `CashOutputOrder` object |
| Update | `200 OK` | The updated `CashOutputOrder` object |
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
  "aim": "Cash advance",
  "base": "Invoice 0000001"
}
```

## Field reference

### `CashOutputOrder` fields

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
| `ecrReturnCheckNumber` | string | ECR check num |
| `correspondentAccount` | string | Corr. account |
| `cashOutFlowAccount` | string | Cash out. acc. |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `partnerCode` | string | Partner |
| `receiverName` | string | Receiver |
| `aim` | string | Code |
| `base` | string | Base |
| `enclosure` | string | Enclosure |
| `otherInformation` | string | Other information |
