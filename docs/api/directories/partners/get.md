# Partners - Get

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_partners.htm)

## Description

Retrieves a single partner record by its code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/partners/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Partner code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `Partner` object. See the
[field reference](README.md#partner-fields).

## Usage example

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/partners/P0001" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY"
```
