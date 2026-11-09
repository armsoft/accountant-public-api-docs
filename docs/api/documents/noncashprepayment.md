# Documents - Non-cash Prepayment

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_noncashprepayment.htm)

## Description

Creates, reads, updates and deletes non-cash (card) prepayments received from a customer through a cash desk's ECR.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/noncashprepayment` | Create a non-cash prepayment |
| GET | `/v1/documents/noncashprepayment/{isn}` | Get a non-cash prepayment by ISN |
| PUT | `/v1/documents/noncashprepayment/{isn}` | Update a non-cash prepayment |
| DELETE | `/v1/documents/noncashprepayment/{isn}` | Delete a non-cash prepayment |

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
non-cash prepayment carries at least:

- `date`
- `documentNumber`
- `cashDesk`
- `currencyAmount`
- `amount`
- `customer`

`cashDesk` is the cash desk the ECR is attached to. `currency` is read-only - it is taken from the
cash desk. `currencyAmount` is the amount in the cash desk's currency and `amount` its AMD
equivalent; for an AMD cash desk send the same value in both. `nonCashTransactionAccount` and
`receivedPrepaymentAccount` default to the accounts set in the Accountant settings when omitted.

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "cashDesk": "01",
  "currencyAmount": 50000,
  "amount": 50000,
  "customer": "P0001",
  "comment": "Created through the Public API"
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/noncashprepayment" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "cashDesk": "01", "currencyAmount": 50000, "amount": 50000, "customer": "P0001", "comment": "Created through the Public API"}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `NonCashPrepayment` object, including `isn` |
| Get | `200 OK` | The `NonCashPrepayment` object |
| Update | `200 OK` | The updated `NonCashPrepayment` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "cashDesk": "01",
  "currencyAmount": 50000,
  "amount": 50000,
  "customer": "P0001",
  "comment": "Created through the Public API"
}
```

## Field reference

### `NonCashPrepayment` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `cashDesk` | string | Cash |
| `ecrCheckNumber` | string | — |
| `useECRPOS` | boolean | Use ECR POS |
| `nonCashTransactionAccount` | string | Non-cash transaction’s account |
| `cashInFlowAccount` | string | Cash in. acc. |
| `partnerCode` | string | Partner |
| `currency` | string | Currency |
| `currencyAmount` | number | Amount in curr. |
| `amount` | number | Sum in AMD |
| `receivedPrepaymentAccount` | string | Received prepayment account |
| `customer` | string | Customer |
| `printExpenseConfirmingCheck` | boolean | Print expense confirming check |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `comment` | string | Comment |
