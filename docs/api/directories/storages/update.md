# Storages - Update

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storages.htm)

## Description

Replaces an existing storage with the supplied values.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `PUT`
- **Route:** `/v1/directories/storages/{code}`
- **Request content type:** `application/json`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Storage code to update |

## Request body (example)

A complete `Storage` object.

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

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the updated `Storage` object.
