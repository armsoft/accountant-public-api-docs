# Storages - Get

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storages.htm)

## Description

Retrieves a single storage by its code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/storages/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Storage code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `Storage` object.

```json
{
  "code": "1001",
  "name": "Sample name",
  "stockkeeper": "",
  "address": "",
  "isClosed": false
}
```
