# Materials - Get

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materials.htm)

## Description

Retrieves a single material record by its code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/materials/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Material code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `Material` object. See the
[field reference](README.md#material-fields).

## Usage example

```bash
curl -X GET "https://api.armsoft.am/accountant/v1/directories/materials/1001" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY"
```
