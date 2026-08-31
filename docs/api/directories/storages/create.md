# Storages - Create

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storages.htm)

## Description

Creates a new storage.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `POST`
- **Route:** `/v1/directories/storages`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

## Request body (example)

A `Storage` object.

```json
{
  "code": "1001",
  "name": "Sample name",
  "stockkeeper": "",
  "address": "",
  "isClosed": false
}
```

## Successful response

- **Status:** `201 Created`
- **Content type:** `application/json`

Returns the created `Storage` object.
