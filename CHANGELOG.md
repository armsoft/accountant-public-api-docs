# Changelog

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api.htm)

All notable changes to the ArmSoft SME Accountant Public API are documented here.

## [1.2.0] - 2026-11-09

Matches the specification served at `https://api.armsoft.am/accountant/swagger/v1/swagger.json`
— 83 paths and 92 schemas.

### Added

#### Directories API
- Materials Groups (`/v1/directories/materialsgroups`) - `GET` list, plus Create, Get, Update
  and Delete by `code`. Like Storages, the list is a plain `GET` that returns the full array and
  does not paginate. New `MaterialsGroup` schema (`code`, `name`, `parent`, read-only `path`).
  The list and Get calls are reachable with a limited-access API key.

#### Documents API
- Non-cash Prepayment (`/v1/documents/noncashprepayment`) - non-cash (card) prepayments received
  from a customer through a cash desk's ECR. New `NonCashPrepayment` schema.
- Return From Customer (`/v1/documents/returnfromcustomer`) - goods, services or fixed assets
  returned by a customer, linked to the original sale through `baseDocumentISN`. New
  `ReturnFromCustomer` and `ReturnFromCustomerSpecificationRow` schemas (rows in `itemList`).
- Return To Supplier (`/v1/documents/returntosupplier`) - materials returned to a supplier,
  linked to the input document through `baseDocumentISN`. New `ReturnToSupplier` and
  `ReturnToSupplierSpecificationRow` schemas (rows in `materialsList`).
- Each supports Create, Get, Update and Delete; Get is reachable with a limited-access API key.

#### Reports API
- Sales Journal (`POST /v1/reports/salesjournal`, with its `/nextpage` call) - sales, retail
  sales and returns of materials, services and fixed assets for a period, with cost, sale
  amounts, profit and VAT figures. New `SalesJournalParam`, `SalesJournalDataRow` and
  `SalesJournalDataRowApiResponse` schemas. Reachable with a limited-access API key.

#### Examples
- C# `MaterialsGroupsClient.cs` with per-operation examples, `create-noncashprepayment.cs`,
  `create-returnfromcustomer.cs`, `create-returntosupplier.cs`, `salesjournal.cs` and
  `salesjournal-nextpage.cs`.

### Changed
- `purchasingType` on `ReceivedService` and `StorageInputOrder`: the Armenian caption is now
  spelled `ձեռքբերման` (was `ձեռք բերման`). The field itself is unchanged.
- `swagger.json` and the generated `docs/api-reference.md` re-synced from the live specification.
- Directory, document and report indexes, the authentication guide's limited-access tables,
  `docs/pagination.md`, `llms.txt` and `llms-full.txt` list the new endpoints.

### Fixed
- `llms-full.txt` still described Received Service, Fixed Asset Acquisition, Fixed Asset
  Disposal Act and Cash Input/Output Order as not yet published; they have been served since
  1.1.0.

---

## [1.1.1] - 2026-10-20

Matches the specification served at `https://api.armsoft.am/accountant/swagger/v1/swagger.json`
— 73 paths and 83 schemas.

### Added

#### Directories API
- Employees: new `annualVacationNorm` field (integer, Annual vacation norm). It is accepted and
  returned by Create, Get and Update (`Employee`, nullable) and returned in the List and Next Page
  rows (`EmployeeRow`). Added to the curated `openapi/` schemas, the Employees field table and the
  request/response examples.

### Changed
- `swagger.json` and the generated `docs/api-reference.md` re-synced from the live specification.

---

## [1.1.0] - 2026-09-07

Matches the specification served at `https://api.armsoft.am/accountant/swagger/v1/swagger.json`
after the September service release — 73 paths and 83 schemas.

### Added

#### Reports API
- Calculated Data (`POST /v1/reports/calculateddata`, with its `/nextpage` call) - the wages
  report of every accrual and deduction calculated for a period, per employee, with income tax,
  funded pension, stamp fee and insurance fee amounts and the accounting accounts of each row.
  Its `CalculatedDataParam`, `CalculatedDataRow` and `CalculatedDataRowApiResponse` schemas are
  added to the curated `openapi/` spec.
- The `extended` request flag is documented: it controls whether the accrual/deduction, employee
  and partner attribute fields (`amountCalculationMethodName`, `incomeTypeName`,
  `includeInAverageWageName`, `fundingSourceName`, `vacationType`, debit/credit partner code and
  name) are resolved.
- The endpoint is reachable with a limited-access API key, and is listed as such in the
  authentication guide.
- C# examples `calculateddata.cs` and `calculateddata-nextpage.cs`.

#### Now served by `api.armsoft.am`
- Received Service, Fixed Asset Acquisition, Fixed Asset Disposal Act, Cash Input Order and
  Cash Output Order — documented since 1.0.0 and now part of the published specification.

### Changed
- `swagger.json` and the generated `docs/api-reference.md` re-synced from the live
  specification (12 new paths, 10 new schemas).

---

## [1.0.0] - 2026-08-31

First published documentation set for the ArmSoft SME Accountant Public API, matching the
specification served at `https://api.armsoft.am/accountant/swagger/v1/swagger.json`
(`info.version` `1.0`). It covers all 61 paths and 73 schemas of the published API.

### Added

#### Directories API
- Partners, Materials, Services and Employees — list with filters, next page, get, create,
  update and delete.
- Storages — full list from `GET /directories/storages` (with the optional `showAlsoClosed`
  query parameter), plus get, create, update and delete.

#### Documents API
- Invoice, Retail Sale, Transfer Invoice, Memorial Order, Payment Order, Storage Input Order,
  Storage Output Order, Materials Movement, Materials Kitting, Overhead Expense Allocation,
  Received Service, Fixed Asset Acquisition, Fixed Asset Disposal Act, Cash Input Order and
  Cash Output Order — each with create, get by ISN, update and delete.

#### Journals API
- All Documents, Invoices and ECR Checks journals, each with a `/nextpage` call.

#### Reports API
- Accounts Balances, Accounts Turnover, Transactions, Partners Balances, Partners Transactions,
  Materials Balances, Materials Operations Journal, and Storage Input Orders and Received
  Services — each with a `/nextpage` call.

#### System
- `GET /api/Version`, documented as not requiring the `apiKey` header.

#### Documentation
- Endpoint documentation with request/response examples and per-schema field tables
- Every page links to its topic in the ArmSoft Accountant online manual (`https://online.armsoft.am/acc7/`)
- Getting started guide
- Authentication guide, including the endpoint list reachable with a limited-access API key
- Pagination guide
- Localization guide
- Error handling guide
- Curated modular OpenAPI specification under `openapi/`
- Generated reference `docs/api-reference.md`, produced from the live specification
- `llms.txt` and `llms-full.txt` indexes for AI tools

#### Code Examples
- C# client wrappers for directories, documents, journals and reports
- Per-operation C# usage examples
- cURL examples on every endpoint page

### Status Codes
- `200 OK` - Successful request
- `201 Created` - Resource created
- `400 Bad Request` - Invalid parameters
- `401 Unauthorized` - Missing or invalid API key
- `403 Forbidden` - Public API disabled for the key, or the key has limited access
- `404 Not Found` - Resource not found
- `409 Conflict` - Resource conflict
- `500 Server Error` - Internal error

### Security
- HTTPS/TLS required for all requests
- API key authentication via `apiKey` header
- API key management via administrative interface
- No sensitive data in logs

---

## Support

For questions or issues:
- Review [documentation](docs/)
- Contact support@armsoft.am
