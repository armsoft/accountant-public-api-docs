# Employees - Delete

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_employees.htm)

## Description

Deletes a employee record by code.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant/v1`
- **Method:** `DELETE`
- **Route:** `/v1/directories/employees/{code}`
- **Authorization:** API key in header `apiKey`

### Path parameters

| Name | Type | Required | Description |
|------|------|----------|-------------|
| code | string | Yes | Employee code to remove |

## Successful response

- **Status:** `200 OK`
- **Content type:** `application/json` (empty body)

The record is removed and the response body is empty. A record that is referenced by existing
documents cannot be deleted.

## Usage example

```bash
curl -X DELETE "https://api.armsoft.am/accountant/v1/directories/employees/0001" \
  -H "accept: application/json" \
  -H "Accept-Language: hy-AM" \
  -H "apiKey: YOUR_API_KEY"
```
