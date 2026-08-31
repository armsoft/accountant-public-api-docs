# Storages - GetAll

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_storages.htm)

## Description

Returns every storage. Unlike the other directories this call is a plain `GET` - it returns the
full array in one response and does not paginate.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/storages`
- **Authorization:** API key in header `apiKey`

### Query parameters

| Name | Type | Required | Default | Description |
|------|------|----------|---------|-------------|
| showAlsoClosed | boolean | No | `true` | Pass `false` to return only storages that are not closed |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns an array of `Storage` objects.

### Sample response

```json
[
  {
    "code": "1001",
    "name": "Sample name",
    "stockkeeper": "",
    "address": "",
    "isClosed": false
  }
]
```

## Usage example

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/storages?showAlsoClosed=false" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY"
```
