# Changelog

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api.htm)

All notable changes to the ArmSoft SME Accountant Public API are documented here.

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
