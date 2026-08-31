# Documents - Payment Order

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_paymentorder.htm)

## Description

Creates, reads, updates and deletes payment orders sent to the bank.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/paymentorder` | Create a payment order |
| GET | `/v1/documents/paymentorder/{isn}` | Get a payment order by ISN |
| PUT | `/v1/documents/paymentorder/{isn}` | Update a payment order |
| DELETE | `/v1/documents/paymentorder/{isn}` | Delete a payment order |

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
payment order carries at least:

- `date`
- `documentNumber`
- `transactionDate`
- `amount`
- `currency`
- `partnerCode`
- `payerBankAccount`
- `receiverBankAccount`
- `paymentAim`

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "transactionDate": "2026-01-15",
  "amount": 10000,
  "paymentAim": "",
  "payerBankAccount": "",
  "currency": "AMD",
  "partnerCode": "P0001",
  "receiverBankAccount": ""
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/paymentorder" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "transactionDate": "2026-01-15", "amount": 10000, "paymentAim": "", "payerBankAccount": "", "currency": "AMD", "partnerCode": "P0001", "receiverBankAccount": ""}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `PaymentOrder` object, including `isn` |
| Get | `200 OK` | The `PaymentOrder` object |
| Update | `200 OK` | The updated `PaymentOrder` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "transactionDate": "2026-01-15",
  "amount": 10000,
  "paymentAim": "",
  "payerBankAccount": "",
  "currency": "AMD",
  "partnerCode": "P0001",
  "receiverBankAccount": ""
}
```

## Field reference

### `PaymentOrder` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `transactionDate` | date | Transaction date |
| `state` | integer | State |
| `currencyAmount` | number | Amount in curr. |
| `amount` | number | Amount in Dram |
| `paymentAim` | string | Payment aim |
| `payerName` | string | Name |
| `payerTaxCode` | string | Taxpayer’s ID |
| `taxAreaCode` | string | Tax area code |
| `payerBankAccount` | string | Account N |
| `currency` | string | Currency |
| `partnerCode` | string | Partner |
| `receiverName` | string | Name |
| `receiverTaxCode` | string | Taxpayer’s ID |
| `receiverLegalStatus` | string | Legal status |
| `receiverBankAccount` | string | Account N |
| `correspondentAccount` | string | Corr. account |
| `cashOutFlowAccount` | string | Cash out. acc. |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `forOtherPartner` | boolean | Third party |
| `otherPartnerCode` | string | Partner |
| `otherPartnerName` | string | Name |
| `otherPartnerResidence` | string | Residence |
| `otherPartnerLegalStatus` | string | Legal status |
| `otherPartnerTaxCode` | string | Taxpayer’s ID |
| `otherPartnerPassportData` | string | Passport Data |
| `otherPartnerPassportNumber` | string | Passport N |
| `otherPartnerSocialCard` | string | Social card |
| `otherPartnerAddress` | string | Address |
