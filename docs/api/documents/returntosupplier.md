# Documents - Return To Supplier

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_returntosupplier.htm)

## Description

Creates, reads, updates and deletes returns of materials to a supplier.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/returntosupplier` | Create a return to supplier |
| GET | `/v1/documents/returntosupplier/{isn}` | Get a return to supplier by ISN |
| PUT | `/v1/documents/returntosupplier/{isn}` | Update a return to supplier |
| DELETE | `/v1/documents/returntosupplier/{isn}` | Delete a return to supplier |

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
return to supplier carries at least:

- `date`
- `documentNumber`
- `baseDocumentISN`
- `supplierCode`
- `currency`
- `storage`
- `materialsList` - at least one row, with `price` or `amount`

`baseDocumentISN` is the `isn` of the document the materials were received with. In each row
send `price` or `amount` - the other one is calculated from `quantity`. `vatCalculationType` takes
`1` with VAT, `2` VAT included, `3` without VAT or `4` zero-rated VAT; when it is omitted the
service picks it from the Accountant settings and whether the supplier is a VAT payer.
`currencyExchangeRate` and `currencyExchangeBase` are required for a document in foreign
currency.

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-20",
  "documentNumber": "0000001",
  "baseDocumentISN": "550e8400-e29b-41d4-a716-446655440000",
  "supplierCode": "P0001",
  "currency": "AMD",
  "supplierAccount": "5210",
  "comment": "Created through the Public API",
  "storage": "01",
  "materialsList": [
    {
      "storage": "01",
      "code": "1001",
      "quantity": 2,
      "price": 1000
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/returntosupplier" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-20", "documentNumber": "0000001", "baseDocumentISN": "550e8400-e29b-41d4-a716-446655440000", "supplierCode": "P0001", "currency": "AMD", "supplierAccount": "5210", "comment": "Created through the Public API", "storage": "01", "materialsList": [{"storage": "01", "code": "1001", "quantity": 2, "price": 1000}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `ReturnToSupplier` object, including `isn` |
| Get | `200 OK` | The `ReturnToSupplier` object |
| Update | `200 OK` | The updated `ReturnToSupplier` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-20",
  "documentNumber": "0000001",
  "baseDocumentISN": "550e8400-e29b-41d4-a716-446655440000",
  "supplierCode": "P0001",
  "currency": "AMD",
  "supplierAccount": "5210",
  "comment": "Created through the Public API",
  "storage": "01",
  "materialsList": [
    {
      "storage": "01",
      "code": "1001",
      "quantity": 2,
      "price": 1000
    }
  ]
}
```

## Field reference

### `ReturnToSupplier` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `baseDocumentISN` | uuid | Base document |
| `currency` | string | Currency |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate |
| `previousDayExchangeRate` | boolean | Previous day exchange rate |
| `supplierCode` | string | Supplier |
| `supplierAccount` | string | Supplier account |
| `transitAccount` | string | Transit account |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `comment` | string | Comment |
| `baseTaxInvoiceSeries` | string | Base serial |
| `baseTaxInvoiceNumber` | string | Base serial number |
| `baseSubmissionDate` | date | Base submission date |
| `vatCalculationType` | string | — |
| `vatIncludedInCost` | boolean | — |
| `storage` | string | Storage |
| `vatAmount` | number | — |
| `totalAmount` | number | Total amount |
| `supplierName` | string | Name |
| `supplierLegalAddress` | string | Legal address |
| `supplierBusinessAddress` | string | Bus. address |
| `supplierSettlementAccount` | string | Settlement account |
| `supplierTaxCode` | string | Taxpayer’s ID |
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
| `materialsList` | array<ReturnToSupplierSpecificationRow> | Materials list |

### `ReturnToSupplierSpecificationRow` fields

The document's rows are sent in `materialsList`.

| Field | Type | Description |
|-------|------|-------------|
| `storage` | string | Storage |
| `id` | integer | Inner number |
| `code` | string | Code |
| `name` | string | Name |
| `unitAbbreviation` | string | Unit |
| `quantity` | number | Quantity |
| `price` | number | Price |
| `amount` | number | Amount |
| `rowId` | integer | Line ID |
