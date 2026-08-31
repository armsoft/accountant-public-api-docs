# ArmSoft Accountant Public API

[![API Version](https://img.shields.io/badge/version-1.0-blue.svg)](https://github.com/armsoft/accountant-public-api-docs)
[![OpenAPI](https://img.shields.io/badge/OpenAPI-3.0-green.svg)](https://github.com/armsoft/accountant-public-api-docs/blob/main/openapi/openapi.yaml)

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api.htm)

Official documentation for the **ArmSoft Accountant Public API** — programmatic access to ArmSoft SME Accountant data including partners, materials, services, employees, accounting documents, journals, and reports.

## Quick Navigation

| Where to go | Description |
|---|---|
| [Getting Started](getting-started.md) | Set up your API key and make your first request |
| [Authentication](authentication.md) | API key types, headers, and access levels |
| [Error Handling](error-handling.md) | HTTP status codes and error response format |
| [Pagination](pagination.md) | Paginating large list responses |
| [Localization](localization.md) | Multi-language request headers |
| [API Reference](api/README.md) | All endpoints — directories, documents, journals, reports |
| [Generated Reference](api-reference.md) | Full reference generated from the live OpenAPI spec |
| [Examples](../examples/README.md) | Ready-to-use C# code samples |

## What You Can Do

| Category | Operations |
|---|---|
| **Directories** | Manage partners, materials, services, employees and storages |
| **Documents** | Create and maintain invoices, retail sales, transfer invoices, memorial orders, payment orders, storage input/output orders, materials movement, materials kitting, overhead expense allocation, received services, fixed asset acquisition and disposal, and cash input/output orders |
| **Journals** | Query the all-documents, invoices and ECR checks journals |
| **Reports** | Accounts balances and turnover, transactions, partners balances and transactions, materials balances, materials operations, storage input orders and received services |

## Base URL

```
https://api.armsoft.am/accountant/v1
```

## Authentication

Every request requires an `apiKey` header:

```http
GET /v1/directories/materials/1001
apiKey: your-api-key-here
Accept-Language: en-US
```

## Multi-Language Support

| Header value | Language |
|---|---|
| `hy-AM` | Armenian (default) |
| `en-US` | English |
| `ru-RU` | Russian |

## OpenAPI Specification

The authoritative API contract is maintained at [`openapi/openapi.yaml`](https://github.com/armsoft/accountant-public-api-docs/blob/main/openapi/openapi.yaml)
and [`swagger.json`](https://github.com/armsoft/accountant-public-api-docs/blob/main/swagger.json).
The live interactive view is at `https://api.armsoft.am/accountant/swagger/index.html`.
