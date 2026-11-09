# Materials Groups - Get

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialsgroups.htm)

## Description

Retrieves a single materials group by its code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `GET`
- **Route:** `/v1/directories/materialsgroups/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Materials group code |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json`

Returns the `MaterialsGroup` object.

```json
{
  "code": "00002",
  "name": "Stationery",
  "parent": "",
  "path": "00002"
}
```
