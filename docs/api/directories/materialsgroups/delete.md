# Materials Groups - Delete

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_materialsgroups.htm)

## Description

Deletes a materials group by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/materialsgroups/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Materials group code to remove |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json` (empty body)
