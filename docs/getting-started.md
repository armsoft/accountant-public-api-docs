# Getting Started with ArmSoft SME Accountant Public API

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api.htm)

This guide will help you make your first API call in under 5 minutes.

## Prerequisites

- **API Key**: Obtain from your ArmSoft administrator
- **Base URL**: Your ArmSoft API endpoint (e.g., `https://api.armsoft.am/accountant/v1`)
- **.NET SDK**: .NET 10.0 or later (for C# examples)

## Quick Start

### Step 1: Check that the API is reachable

`GET /api/Version` needs no API key, so it is the quickest way to confirm connectivity:

```bash
curl -X GET "https://api.armsoft.am/accountant/api/Version"
```

**Expected Response:**

```json
"1.0"
```

### Step 2: Verify Your API Key

Test your API key with a simple request:

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/storages" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: en-US"
```

**Expected Response:**

```json
[
  {
    "code": "01",
    "name": "Main storage",
    "stockkeeper": "",
    "address": "",
    "isClosed": false
  }
]
```

### Step 3: Read a directory with filters

Most directories are read through a `POST .../list` call that accepts a filter object:

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/directories/materials/list" \
  -H "apiKey: your-api-key-here" \
  -H "Accept-Language: en-US" \
  -H "Content-Type: application/json" \
  -d '{"showAlsoClosed": false, "pageSize": 5000}'
```

The response carries a pagination context (`id`), a `hasMore` flag, and the `data` array.
When `hasMore` is `true`, keep calling `.../list/nextpage` with the returned `id` — see
[Pagination](pagination.md).

### Step 4: Create a document

```bash
curl -X POST "https://api.armsoft.am/accountant/v1/documents/memorialorder" \
  -H "apiKey: your-api-key-here" \
  -H "Content-Type: application/json" \
  -d '{
    "date": "2026-01-15",
    "amount": 10000,
    "currency": "AMD",
    "transactionsList": [
      { "debitAccount": "2110", "creditAccount": "5210", "amount": 10000 }
    ]
  }'
```

A successful create returns `201 Created` together with the document, including the `isn`
(internal serial number) you use for every subsequent `GET`, `PUT` or `DELETE` call.

## Next Steps

- Read the endpoint docs: [API Reference](api/README.md)
- Directories: [Materials](api/directories/materials/README.md), [Partners](api/directories/partners/README.md)
- Documents: [Documents API](api/documents/README.md)
- Import the OpenAPI file into Postman/Insomnia: [openapi/openapi.yaml](https://github.com/armsoft/accountant-public-api-docs/blob/main/openapi/openapi.yaml)
