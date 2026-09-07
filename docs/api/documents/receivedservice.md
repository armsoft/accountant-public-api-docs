# Documents - Received Service

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_receivedservice.htm)

## Description

Creates, reads, updates and deletes services received from a supplier.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/receivedservice` | Create a received service |
| GET | `/v1/documents/receivedservice/{isn}` | Get a received service by ISN |
| PUT | `/v1/documents/receivedservice/{isn}` | Update a received service |
| DELETE | `/v1/documents/receivedservice/{isn}` | Delete a received service |

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
received service carries at least:

- `date`
- `documentNumber`
- `supplierCode`
- `supplierAccount`
- `currency`
- `servicesList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "currency": "AMD",
  "supplierCode": "P0001",
  "supplierAccount": "5210",
  "comment": "Created through the Public API",
  "servicesList": [
    {
      "code": "1001",
      "quantity": 10,
      "price": 1000,
      "vat": true,
      "account": "2110"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/receivedservice" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "currency": "AMD", "supplierCode": "P0001", "supplierAccount": "5210", "comment": "Created through the Public API", "servicesList": [{"code": "1001", "quantity": 10, "price": 1000, "vat": true, "account": "2110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `ReceivedService` object, including `isn` |
| Get | `200 OK` | The `ReceivedService` object |
| Update | `200 OK` | The updated `ReceivedService` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "currency": "AMD",
  "supplierCode": "P0001",
  "supplierAccount": "5210",
  "comment": "Created through the Public API",
  "servicesList": [
    {
      "code": "1001",
      "quantity": 10,
      "price": 1000,
      "vat": true,
      "account": "2110"
    }
  ]
}
```

## Field reference

### `ReceivedService` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | Inner number |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `currency` | string | Currency |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate |
| `previousDayExchangeRate` | boolean | Previous day exchange rate |
| `supplierCode` | string | Supplier |
| `supplierAccount` | string | Supplier account |
| `prepaymentAccount` | string | Prepayment account |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `selfInvoice` | boolean | Self-invoice |
| `taxExportType` | string | Electronic/Paper |
| `purchaseDocumentNumber` | string | Purchase document N |
| `submissionDate` | date | Submission date |
| `comment` | string | Comment |
| `purchasingType` | string | Service purchasing type |
| `vatCalculationType` | string | VAT calculation type |
| `includeVATInExpense` | boolean | Include VAT in expense |
| `vatInclusionMethod` | string | Include/Exclude VAT |
| `vatAmount` | number | VAT amount |
| `totalAmount` | number | Total amount |
| `supplierLegalAddress` | string | Legal address |
| `supplierBusinessAddress` | string | Bus. address |
| `supplierSettlementAccount` | string | Settlement account |
| `supplierTaxCode` | string | Taxpayer’s ID |
| `supplierManagerPosition` | string | Manager position |
| `supplierManagerName` | string | Manager first name, last name |
| `supplierAccountantPosition` | string | Accountant position |
| `supplierAccountantName` | string | Accountant first name, last name |
| `servicesList` | array<ReceivedServiceSpecificationRow> | Services |

### `ReceivedServiceSpecificationRow` fields

The document's rows are sent in `servicesList`.

| Field | Type | Description |
|-------|------|-------------|
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `price` | number | Price |
| `amount` | number | Amount |
| `vat` | boolean | VAT |
| `account` | string | Account |
| `rowNumber` | integer | line N |
