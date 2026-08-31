# Version

🔗 [Online documentation](https://online.armsoft.am/acc7/rest_api_get_version.htm)

Retrieves the current API version string.

## Endpoint

- **Base URL:** `https://api.armsoft.am/accountant`
- **Method:** `GET`
- **Route:** `/api/Version`
- **Authorization:** None

This endpoint is not versioned, does not sit under `/v1`, and does not require the `apiKey`
header.

## Successful response

- **Status:** `200 OK`
- **Content types:** `text/plain`, `application/json`, `text/json`

Returns a plain string containing the API version.

### Example response

```json
"1.0"
```

### Example request

```bash
curl -X GET "https://api.armsoft.am/accountant/api/Version"
```
