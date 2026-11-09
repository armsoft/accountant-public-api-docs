# Documents - Return From Customer

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_returnfromcustomer.htm)

## Description

Creates, reads, updates and deletes returns of goods, services or fixed assets from a customer.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/returnfromcustomer` | Create a return from customer |
| GET | `/v1/documents/returnfromcustomer/{isn}` | Get a return from customer by ISN |
| PUT | `/v1/documents/returnfromcustomer/{isn}` | Update a return from customer |
| DELETE | `/v1/documents/returnfromcustomer/{isn}` | Delete a return from customer |

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
return from customer carries at least:

- `date`
- `documentNumber`
- `baseDocumentISN`
- `customer`
- `currency`
- `vatCalculationType`
- `storage`
- `itemList` - at least one row

`baseDocumentISN` is the `isn` of the sale document the items are returned against. When no base
document is given, each row must carry its cost - `costPriceWithoutVAT` or `costAmountWithoutVAT`,
and `costAccount`. `vatCalculationType` takes `1` with VAT, `2` VAT included, `3` without VAT,
`4` zero-rated VAT or `5` VAT included at 16.67 %. A row's `type` is `1` material, `2` service or
`3` fixed asset. When `discountedPrice` and `amount` are omitted they are calculated from `price`,
`quantity` and `discountPercent` (the row's, or the document's when the row has none).

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-20",
  "documentNumber": "0000001",
  "baseDocumentISN": "550e8400-e29b-41d4-a716-446655440000",
  "customer": "P0001",
  "currency": "AMD",
  "vatCalculationType": "1",
  "comment": "Created through the Public API",
  "storage": "01",
  "itemList": [
    {
      "type": "1",
      "storage": "01",
      "code": "1001",
      "quantity": 2,
      "price": 1000,
      "vat": true,
      "expenseAccount": "7110",
      "incomeAccount": "6110"
    }
  ]
}
```

## Usage example

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/returnfromcustomer" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-20", "documentNumber": "0000001", "baseDocumentISN": "550e8400-e29b-41d4-a716-446655440000", "customer": "P0001", "currency": "AMD", "vatCalculationType": "1", "comment": "Created through the Public API", "storage": "01", "itemList": [{"type": "1", "storage": "01", "code": "1001", "quantity": 2, "price": 1000, "vat": true, "expenseAccount": "7110", "incomeAccount": "6110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `ReturnFromCustomer` object, including `isn` |
| Get | `200 OK` | The `ReturnFromCustomer` object |
| Update | `200 OK` | The updated `ReturnFromCustomer` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-20",
  "documentNumber": "0000001",
  "baseDocumentISN": "550e8400-e29b-41d4-a716-446655440000",
  "customer": "P0001",
  "currency": "AMD",
  "vatCalculationType": "1",
  "comment": "Created through the Public API",
  "storage": "01",
  "itemList": [
    {
      "type": "1",
      "storage": "01",
      "code": "1001",
      "quantity": 2,
      "price": 1000,
      "vat": true,
      "expenseAccount": "7110",
      "incomeAccount": "6110"
    }
  ]
}
```

## Field reference

### `ReturnFromCustomer` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `state` | integer | State |
| `baseDocumentISN` | uuid | Base document |
| `ecrReturnCheckNumber` | string | — |
| `customer` | string | Customer |
| `currency` | string | Currency |
| `currencyExchangeRate` | number | Currency exchange rate |
| `currencyExchangeBase` | number | Currency exchange rate |
| `previousDayExchangeRate` | boolean | Previous day exchange rate |
| `contract` | string | Contract |
| `contractDate` | date | Contract date |
| `cashDesk` | string | Cash |
| `customerAccount` | string | Customer account |
| `receivedPrepaymentAccount` | string | Received prepayment account |
| `vatAccount` | string | — |
| `environmentalFeeAccount` | string | Environmental fees' credit account |
| `nonCashTransactionAccount` | string | Non-cash transaction’s account |
| `analytic1` | string | Analytical dimension 1 |
| `analytic2` | string | Analytical dimension 2 |
| `baseTaxInvoiceSeries` | string | Base serial |
| `baseTaxInvoiceNumber` | string | Base serial number |
| `baseSubmissionDate` | date | Base submission date |
| `taxExportType` | string | Electronic/Paper |
| `taxInvoiceSeries` | string | Serial |
| `taxInvoiceNumber` | string | Number |
| `submissionDate` | date | Submission date |
| `comment` | string | Comment |
| `vatCalculationType` | string | — |
| `dealType` | string | Deal type |
| `storage` | string | Storage |
| `discountPercent` | number | Discount percent |
| `nonCashAmount` | number | Non-cash amount |
| `prepaymentAmount` | number | Payment in advance |
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
| `idDocumentType` | string | Identification document |
| `passportNumber` | string | Passport N |
| `socialCardNumber` | string | Social card number |
| `customerAdditionalData` | string | Additional data |
| `shippingMethod` | string | Shipping method |
| `additionalFullName` | string | Full name |
| `credentialNumber` | string | Credential number |
| `credentialDate` | date | Credential date |
| `itemList` | array<ReturnFromCustomerSpecificationRow> | Items list |

### `ReturnFromCustomerSpecificationRow` fields

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
| `environmentalFeePercent` | number | Env. fee (%) |
| `environmentalFeeAmount` | number | Env. fee amount |
| `vat` | boolean | — |
| `dealType` | string | Deal type |
| `costPriceWithoutVAT` | number | Cost price (without VAT) |
| `costAmountWithoutVAT` | number | Cost amount (without VAT) |
| `costVATAmount` | number | VAT of cost’s amount |
| `costAccount` | string | Cost account |
| `expenseAccount` | string | Expense account |
| `incomeAccount` | string | Income account |
| `markingList` | array<string> | Marking |
| `cpaClassifier` | string | — |
| `rowNumber` | integer | line N |
| `rowId` | integer | Line ID |
