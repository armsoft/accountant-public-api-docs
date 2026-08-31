# Documents - Transfer Invoice

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_transfer_invoice.htm)

## Description

Creates, reads, updates and deletes transfer invoices (invoices for payment).

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/transferinvoice` | Create a transfer invoice |
| GET | `/v1/documents/transferinvoice/{isn}` | Get a transfer invoice by ISN |
| PUT | `/v1/documents/transferinvoice/{isn}` | Update a transfer invoice |
| DELETE | `/v1/documents/transferinvoice/{isn}` | Delete a transfer invoice |

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
transfer invoice carries at least:

- `date`
- `documentNumber`
- `customer`
- `currency`
- `storage`
- `itemList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "customer": "P0001",
  "currency": "AMD",
  "comment": "Created through the Public API",
  "storage": "01",
  "itemList": [
    {
      "type": "1",
      "storage": "01",
      "code": "1001",
      "quantity": 10,
      "price": 1000,
      "vat": true
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/transferinvoice" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "customer": "P0001", "currency": "AMD", "comment": "Created through the Public API", "storage": "01", "itemList": [{"type": "1", "storage": "01", "code": "1001", "quantity": 10, "price": 1000, "vat": true}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `TransferInvoice` object, including `isn` |
| Get | `200 OK` | The `TransferInvoice` object |
| Update | `200 OK` | The updated `TransferInvoice` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "customer": "P0001",
  "currency": "AMD",
  "comment": "Created through the Public API",
  "storage": "01",
  "itemList": [
    {
      "type": "1",
      "storage": "01",
      "code": "1001",
      "quantity": 10,
      "price": 1000,
      "vat": true
    }
  ]
}
```

## Field reference

### `TransferInvoice` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `customer` | string | Customer |
| `currency` | string | Currency |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate |
| `state` | integer | State |
| `contract` | string | Contract |
| `contractDate` | date | Contract date |
| `comment` | string | Comment |
| `vatCalculationType` | string | — |
| `storage` | string | Storage |
| `discountPercent` | number | Discount percent |
| `vatAmount` | number | — |
| `totalAmount` | number | Total amount |
| `supplierBusinessAddress` | string | Bus. address |
| `supplierSettlementAccount` | string | Settlement account |
| `supplierManagerPosition` | string | Manager position |
| `supplierManagerName` | string | Manager first name, last name |
| `supplierAccountantPosition` | string | Accountant position |
| `supplierAccountantName` | string | Accountant first name, last name |
| `customerName` | string | Name |
| `customerLegalAddress` | string | Legal address |
| `customerBusinessAddress` | string | Bus. address |
| `customerSettlementAccount` | string | Settlement account |
| `customerTaxCode` | string | Taxpayer’s ID |
| `customerManagerPosition` | string | Manager position |
| `customerManagerName` | string | Manager first name, last name |
| `customerAccountantPosition` | string | Accountant position |
| `customerAccountantName` | string | Accountant first name, last name |
| `stateRegisterNumber` | string | S/P state regist. N |
| `passportNumber` | string | Passport N |
| `itemList` | array<TransferInvoiceSpecificationRow> | Items list |

### `TransferInvoiceSpecificationRow` fields

The document's rows are sent in `itemList`.

| Field | Type | Description |
|-------|------|-------------|
| `type` | string | Type |
| `storage` | string | Storage |
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `price` | number | Price |
| `discountPercent` | number | Discount percent |
| `discountedPrice` | number | Discounted price |
| `amount` | number | Amount |
| `vat` | boolean | — |
| `rowNumber` | integer | line N |
| `rowId` | integer | Line ID |
