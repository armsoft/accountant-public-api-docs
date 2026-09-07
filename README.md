# ArmSoft Accountant Public API Documentation

[![API Version](https://img.shields.io/badge/version-1.0-blue.svg)](https://github.com/armsoft/accountant-public-api-docs)
[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4)](https://dotnet.microsoft.com/)
[![OpenAPI](https://img.shields.io/badge/OpenAPI-3.0-green.svg)](./openapi/openapi.yaml)
[![Sync Swagger](https://github.com/armsoft/accountant-public-api-docs/actions/workflows/sync-swagger.yml/badge.svg)](https://github.com/armsoft/accountant-public-api-docs/actions/workflows/sync-swagger.yml)

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api.htm)

Official documentation for the ArmSoft Accountant Public API.

## 📋 Overview

The ArmSoft Accountant Public API provides programmatic access to:

- **Directories**: Partners, materials, services, employees and storages
- **Documents**: Invoices, retail sales, transfer invoices, memorial orders, payment orders, storage input/output orders, materials movement, materials kitting, overhead expense allocation, received services, fixed asset acquisition and disposal, cash input/output orders
- **Journals**: All documents, invoices, ECR checks
- **Reports**: Accounts balances and turnover, transactions, partners balances and transactions, materials balances and operations, purchases
- **Multi-language Support**: Armenian (hy-AM), English (en-US), Russian (ru-RU)

### Key Features

✅ RESTful design with JSON responses  
✅ API Key authentication (header-based)  
✅ Comprehensive error handling  
✅ OpenAPI/Swagger specification  
✅ Multi-language support  
✅ Built on ASP.NET Core 10 / C# 13  

## 🚀 Quick Start

### 1. Get Your API Key

Contact your ArmSoft administrator to obtain an API key.

### 2. Make Your First Request

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/materials/1001" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: hy-AM"
```

### 3. Response

```json
{
    "id": 100001,
    "code": "1001",
    "name": "Sample material",
    "unitMeasure": "001",
    "account": "2110",
    "vat": true,
    "isClosed": false
}
```

## 🔐 Authentication

All API requests require an API key in the request header:

```http
apiKey: your-api-key-here
Accept-Language: hy-AM
```

**API Key Types:**
- **Full Access**: Complete CRUD operations on all resources
- **Limited Access**: Restricted to read-only operations (directories, single documents, journals, reports)

📖 **[Full Authentication Guide](docs/authentication.md)**

## 📚 API Reference

### Base URL

```
https://api.armsoft.am/accountant/v{version}
```

Current version: **v1**

### Partners Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/partners/list` | Get all partners with filters |
| POST | `/directories/partners/list/nextpage` | Get next page of partners |
| GET | `/directories/partners/{code}` | Get partner by code |
| POST | `/directories/partners` | Create new partner |
| PUT | `/directories/partners/{code}` | Update partner |
| DELETE | `/directories/partners/{code}` | Delete partner |

### Materials Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/materials/list` | Get all materials with filters |
| POST | `/directories/materials/list/nextpage` | Get next page of materials |
| GET | `/directories/materials/{code}` | Get material by code |
| POST | `/directories/materials` | Create new material |
| PUT | `/directories/materials/{code}` | Update material |
| DELETE | `/directories/materials/{code}` | Delete material |

### Services Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/services/list` | Get all services with filters |
| POST | `/directories/services/list/nextpage` | Get next page of services |
| GET | `/directories/services/{code}` | Get service by code |
| POST | `/directories/services` | Create new service |
| PUT | `/directories/services/{code}` | Update service |
| DELETE | `/directories/services/{code}` | Delete service |

### Employees Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/directories/employees/list` | Get all employees with filters |
| POST | `/directories/employees/list/nextpage` | Get next page of employees |
| GET | `/directories/employees/{code}` | Get employee by code |
| POST | `/directories/employees` | Create new employee |
| PUT | `/directories/employees/{code}` | Update employee |
| DELETE | `/directories/employees/{code}` | Delete employee |

### Storages Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/directories/storages` | Get all storages (optional `?showAlsoClosed=false` hides closed ones) |
| GET | `/directories/storages/{code}` | Get storage by code |
| POST | `/directories/storages` | Create new storage |
| PUT | `/directories/storages/{code}` | Update storage |
| DELETE | `/directories/storages/{code}` | Delete storage |

### Documents Endpoints

Every document type supports the same four calls.

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/documents/{document}` | Create the document |
| GET | `/documents/{document}/{isn}` | Get the document by ISN |
| PUT | `/documents/{document}/{isn}` | Update the document |
| DELETE | `/documents/{document}/{isn}` | Delete the document |

| Document | `{document}` | Reference |
|----------|--------------|-----------|
| Invoice | `invoice` | [invoice.md](docs/api/documents/invoice.md) |
| Retail Sale | `retailsale` | [retailsale.md](docs/api/documents/retailsale.md) |
| Transfer Invoice | `transferinvoice` | [transferinvoice.md](docs/api/documents/transferinvoice.md) |
| Memorial Order | `memorialorder` | [memorialorder.md](docs/api/documents/memorialorder.md) |
| Payment Order | `paymentorder` | [paymentorder.md](docs/api/documents/paymentorder.md) |
| Storage Input Order | `storageinputorder` | [storageinputorder.md](docs/api/documents/storageinputorder.md) |
| Storage Output Order | `storageoutputorder` | [storageoutputorder.md](docs/api/documents/storageoutputorder.md) |
| Materials Movement | `materialsmovement` | [materialsmovement.md](docs/api/documents/materialsmovement.md) |
| Materials Kitting | `materialskitting` | [materialskitting.md](docs/api/documents/materialskitting.md) |
| Overhead Expense Allocation | `overheadexpenseallocation` | [overheadexpenseallocation.md](docs/api/documents/overheadexpenseallocation.md) |
| Received Service | `receivedservice` | [receivedservice.md](docs/api/documents/receivedservice.md) |
| Fixed Asset Acquisition | `fixedassetacquisition` | [fixedassetacquisition.md](docs/api/documents/fixedassetacquisition.md) |
| Fixed Asset Disposal Act | `fixedassetdisposalact` | [fixedassetdisposalact.md](docs/api/documents/fixedassetdisposalact.md) |
| Cash Input Order | `cashinputorder` | [cashinputorder.md](docs/api/documents/cashinputorder.md) |
| Cash Output Order | `cashoutputorder` | [cashoutputorder.md](docs/api/documents/cashoutputorder.md) |

### Journals Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/journals/alldocuments` | Get all documents journal rows |
| POST | `/journals/alldocuments/nextpage` | Next page for the documents journal |
| POST | `/journals/invoices` | Get invoice documents journal rows |
| POST | `/journals/invoices/nextpage` | Next page for the invoices journal |
| POST | `/journals/ecrchecks` | Get ECR checks journal rows |
| POST | `/journals/ecrchecks/nextpage` | Next page for the ECR checks journal |

### Reports Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | `/reports/accountsbalances` | Accounts balances report |
| POST | `/reports/accountsbalances/nextpage` | Accounts balances next page |
| POST | `/reports/accountsturnover` | Accounts turnover report |
| POST | `/reports/accountsturnover/nextpage` | Accounts turnover next page |
| POST | `/reports/transactions` | Transactions journal report |
| POST | `/reports/transactions/nextpage` | Transactions next page |
| POST | `/reports/partnersbalances` | Partners balances report |
| POST | `/reports/partnersbalances/nextpage` | Partners balances next page |
| POST | `/reports/partnerstransactions` | Partners transactions report |
| POST | `/reports/partnerstransactions/nextpage` | Partners transactions next page |
| POST | `/reports/materialsbalances` | Materials balances report |
| POST | `/reports/materialsbalances/nextpage` | Materials balances next page |
| POST | `/reports/materialsoperationsjournal` | Materials operations journal report |
| POST | `/reports/materialsoperationsjournal/nextpage` | Materials operations journal next page |
| POST | `/reports/storageinputordersandreceivedservices` | Storage input orders and received services report |
| POST | `/reports/storageinputordersandreceivedservices/nextpage` | Storage input orders and received services next page |
| POST | `/reports/calculateddata` | Calculated data (wages) report |
| POST | `/reports/calculateddata/nextpage` | Calculated data next page |

### System

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/Version` | API version (no API key required) |

📖 **[Code Examples](examples/README.md)**

## 📖 Documentation

| Document | Description |
|----------|-------------|
| [Getting Started](docs/getting-started.md) | Installation and setup guide |
| [Authentication](docs/authentication.md) | API key authentication details |
| [API Reference](docs/api/README.md) | Complete endpoint documentation |
| [Directories API](docs/api/directories/README.md) | Partners, materials, services, employees, storages |
| [Documents API](docs/api/documents/README.md) | Accounting document endpoints |
| [Journals API](docs/api/journals/README.md) | Journal endpoints |
| [Reports API](docs/api/reports/README.md) | Report endpoints |
| [Pagination](docs/pagination.md) | Pagination and filtering guide |
| [Localization](docs/localization.md) | Multi-language support details |
| [Error Handling](docs/error-handling.md) | Error codes and responses |
| [Changelog](CHANGELOG.md) | Version history and changes |

## 🛠️ OpenAPI Specification

Interactive API documentation available via Swagger:

- **Swagger UI**: `https://api.armsoft.am/accountant/swagger`
- **OpenAPI Spec**: [openapi/openapi.yaml](openapi/openapi.yaml)

Import the OpenAPI specification into:
- Postman
- SwaggerHub
- Any OpenAPI-compatible tool

## 🤖 Auto-Generated Documentation

This repository maintains automatically synchronized API documentation:

- **`swagger.json`** — Live OpenAPI specification fetched from `https://api.armsoft.am/accountant/swagger/v1/swagger.json`
- **`docs/api-reference.md`** — Auto-generated Markdown reference documentation

### How it works

A GitHub Actions workflow ([`.github/workflows/sync-swagger.yml`](.github/workflows/sync-swagger.yml)) can be run from the Actions tab to:

1. Fetch the latest `swagger.json` from the live API
2. Compare it with the committed version
3. If changes are detected:
   - Update `swagger.json`
   - Regenerate `docs/api-reference.md` using [widdershins](https://github.com/Mermade/widdershins)
   - Commit and push the changes automatically

### Manual sync

To manually trigger a documentation sync:

1. Go to the [Actions tab](https://github.com/armsoft/accountant-public-api-docs/actions/workflows/sync-swagger.yml)
2. Click "Run workflow" → "Run workflow"

The workflow runs in ~30 seconds and updates the docs if changes are detected.

**Note:** If the API endpoint ever requires authentication, add an `API_TOKEN` secret to the repository settings. The workflow includes commented placeholders for this.

## 🌍 Multi-Language Support

Set the `Accept-Language` header to receive localized responses:

| Language | Code | Example |
|----------|------|---------|
| Armenian | `hy-AM` | `Accept-Language: hy-AM` |
| English | `en-US` | `Accept-Language: en-US` |
| Russian | `ru-RU` | `Accept-Language: ru-RU` |

## 📊 HTTP Status Codes

| Code | Description |
|------|-------------|
| 200 | OK - Successful request |
| 201 | Created - Resource created successfully |
| 400 | Bad Request - Invalid request data |
| 401 | Unauthorized - Missing or invalid API key |
| 403 | Forbidden - Public API disabled for the key, or insufficient permissions |
| 404 | Not Found - Resource doesn't exist |
| 405 | Method Not Allowed |
| 409 | Conflict - Resource conflict (e.g., duplicate) |
| 429 | Too Many Requests - Rate limit exceeded |
| 500 | Internal Server Error |
| 503 | Service Unavailable |

## 🔄 Versioning

API version is specified in the URL:

```
/accountant/v1/directories/materials
```

- Current version: **v1**
- Backward compatibility maintained within major versions

## 📜 License

© 2026 ArmSoft - Armenian Software. All rights reserved.

This documentation is provided for API integration purposes. For licensing of the ArmSoft Accountant system, contact ArmSoft.

## 🏢 About ArmSoft

ArmSoft is a leading provider of enterprise resource planning (ERP) solutions for businesses in Armenia and beyond. The Accountant system is designed for small and medium enterprises to manage their accounting operations efficiently.

---

## 🤖 AI & LLM Usage

This repository includes machine-readable index files for AI tools and web crawlers:

- [llms.txt](llms.txt) — structured index of all docs and endpoints
- [llms-full.txt](llms-full.txt) — full inline content for AI tools that don't follow links
