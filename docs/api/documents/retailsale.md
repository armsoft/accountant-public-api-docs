# Documents - Retail Sale

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_retailsale.htm)

## Description

Creates, reads, updates and deletes retail sales registered against a cash desk.

## Endpoints

| Method | Route | Description |
|--------|-------|-------------|
| POST | `/v1/documents/retailsale` | Create a retail sale |
| GET | `/v1/documents/retailsale/{isn}` | Get a retail sale by ISN |
| PUT | `/v1/documents/retailsale/{isn}` | Update a retail sale |
| DELETE | `/v1/documents/retailsale/{isn}` | Delete a retail sale |

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
retail sale carries at least:

- `date`
- `documentNumber`
- `customer`
- `cashDesk`
- `storage`
- `itemList` - at least one row

## Create request example

Only the fields listed above have to be sent; everything else is optional.

```json
{
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "customer": "P0001",
  "cashDesk": "01",
  "comment": "Created through the Public API",
  "storage": "01",
  "itemList": [
    {
      "type": "1",
      "storage": "01",
      "code": "1001",
      "quantity": 10,
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
curl -X POST "https://api.armsoft.am/accountant/v1/documents/retailsale" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY" \
  -H "Content-Type: application/json" \
  -d '{"date": "2026-01-15", "documentNumber": "0000001", "customer": "P0001", "cashDesk": "01", "comment": "Created through the Public API", "storage": "01", "itemList": [{"type": "1", "storage": "01", "code": "1001", "quantity": 10, "price": 1000, "vat": true, "expenseAccount": "7110", "incomeAccount": "6110"}]}'
```

## Response

| Operation | Status | Body |
|-----------|--------|------|
| Create | `201 Created` | The created `RetailSale` object, including `isn` |
| Get | `200 OK` | The `RetailSale` object |
| Update | `200 OK` | The updated `RetailSale` object |
| Delete | `200 OK` | Empty |

### Example create response

```json
{
  "isn": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
  "state": 1,
  "date": "2026-01-15",
  "documentNumber": "0000001",
  "customer": "P0001",
  "cashDesk": "01",
  "comment": "Created through the Public API",
  "storage": "01",
  "itemList": [
    {
      "type": "1",
      "storage": "01",
      "code": "1001",
      "quantity": 10,
      "price": 1000,
      "vat": true,
      "expenseAccount": "7110",
      "incomeAccount": "6110"
    }
  ]
}
```

## Field reference

### `RetailSale` fields

| Field | Type | Description |
|-------|------|-------------|
| `isn` | uuid | — |
| `date` | date | Date |
| `documentNumber` | string | Document N |
| `ecrCheckNumber` | string | — |
| `state` | integer | State |
| `customer` | string | Customer |
| `printExpenseConfirmingCheck` | boolean | Print expense confirming check |
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
| `useECRPos` | boolean | Use ECR POS |
| `prepaymentAmount` | number | Use of prepayment |
| `vatAmount` | number | — |
| `totalAmount` | number | Total amount |
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
| `citizenOfRA` | boolean | Citizen of RA, who carried made expenses |
| `socialExpensesType` | string | Type of social expenses |
| `socialExpenseSocialCard` | string | Soc. card/certificate of absence of soc. card |
| `socialExpenseCitizenName` | string | First name, last name |
| `socialExpenseIdentityDocument` | string | Identification document |
| `socialExpenseSerialNumber` | string | Series and/or number |
| `itemList` | array<RetailSaleSpecificationRow> | Items list |

### `RetailSaleSpecificationRow` fields

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
| `expenseAccount` | string | Expense account |
| `incomeAccount` | string | Income account |
| `markingList` | array<string> | Marking |
| `rowNumber` | integer | line N |
| `rowId` | integer | Line ID |
