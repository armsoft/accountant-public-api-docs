# Services - Get

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_services.htm)

## Description

Retrieves a single service record by its code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/services/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Service code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `Service` object. See the
[field reference](README.md#service-fields).

## Usage example

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/services/S001" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY"
```
